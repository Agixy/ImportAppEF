using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using ExcelDataReader;
using ImportApp.Model;
using ImportApp.ViewModel.Mappers;
using Microsoft.Win32;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;

namespace ImportApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PersonMapper PersonMapper { get; set; }
        private readonly MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=mycontext;uid=root;password=****");
        private readonly ImportContext context;// = new ImportContext();

      
        public MainWindow()
        {
            InitializeComponent();
            context = new ImportContext();
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());
            context.Database.CreateIfNotExists();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var pathToFile = ChooseFile();
            DataTable dataTable;

          

            //Create database if not exists                    
            //using (ImportContext context = new ImportContext(connection, false))  
            //{
            //    context.Database.CreateIfNotExists();
            //}

            using (var stream = File.Open(pathToFile, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
 
                var excelReadResult = reader.AsDataSet(ExcelDataSetConfig());

                dataTable = excelReadResult.Tables[0]; 

                foreach (DataColumn column in dataTable.Columns)
                {
                    ListBox1.Items.Add(column.Caption);
                }

                
                

                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // DbConnection that is already opened
                    using (ImportContext context = new ImportContext(connection, false))
                    {

                        // Interception/SQL logging
                        //context.Database.Log = (string message) => { Console.WriteLine(message); };

                        // Passing an existing transaction to the context
                        context.Database.UseTransaction(transaction);

                        // DbSet.AddRange

                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            Adress adress = CreateAdressObject(dataTable, i);

                            context.Adresses.Add(adress);
                            context.SaveChanges();
                        }

                        Person person = new Person()
                        {
                            FirstName = "aaa",
                            SecondName = "bbb",
                            Surname = "xxx",                           
                            NationalIdentificationNumber = "12345",
                            PhoneNumber = "111",
                            //Adress = context.Adresses.FirstOrDefault(a => a.Id == 5)
                        };

                        context.Persons.Add(person);
                        context.SaveChanges();

                        //for (int i = 0; i < dataTable.Rows.Count; i++)
                        //{
                        //    Person person = CreatePersonObject(dataTable, i);

                        //    context.Persons.Add(person);
                        //    context.SaveChanges();
                        //}
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }

                


                //TextBox2.Text = adress.StreetName;

               

                //for (int row = 0; row < dataTablet.Rows.Count; row++)
                //{
                //    var person = new Person();

                //    for (int column = 0; column < dataTablet.Columns.Count; column++)
                //    {
                //        TextBox3.Text = dataTablet.Rows[row][column].ToString();
                //    }
                //}

                TextBox3.Text = dataTable.Rows[0][0].ToString();

            }
        }

        private Person CreatePersonObject(DataTable dataTable, int objNumber)
        {
            Person person = new Person()
            {
                FirstName = GetValueFromColumn(dataTable, "imie", objNumber),
                SecondName = null,
                Surname = GetValueFromColumn(dataTable, "nazwisko", objNumber),
                NationalIdentificationNumber = ValidatePesel(GetValueFromColumn(dataTable, "PESEL", objNumber)),
                PhoneNumber = GetValueFromColumn(dataTable, "Telefon 1", objNumber),
                PhoneNumber2 = GetValueFromColumn(dataTable, "Telefon 2", objNumber),
                //Adress = 
             };

            return person;
        }

        private Adress CreateAdressObject(DataTable dataTable, int objNumber)
        {
            Adress adress = new Adress()
            {
                StreetName = GetValueFromColumn(dataTable, "MAIN_STREET_NAME", objNumber),
                StreetNumber = GetValueFromColumn(dataTable, "MAIN_STREET_NUMBER", objNumber),
                FlatNumber = GetValueFromColumn(dataTable, "MAIN_STREET_FLAT_NUMBER", objNumber),
                PostCode = GetValueFromColumn(dataTable, "MAIN_POST_CODE", objNumber),
                PostOfficeCity = GetValueFromColumn(dataTable, "MAIN_POST_OFFICE_CITY", objNumber),
                CorrespondenceStreetName = GetValueFromColumn(dataTable, "CORRESPONDENCE_STREET_NAME", objNumber),
                CorrespondenceStreetNumber = GetValueFromColumn(dataTable, "CORRESPONDENCE_STREET_NUMBER", objNumber),
                CorrespondenceFlatNumber = GetValueFromColumn(dataTable, "CORRESPONDENCE_STREET_FLAT_NUMBER", objNumber),
                CorrespondencePostCode = GetValueFromColumn(dataTable, "CORRESPONDENCE_POST_CODE", objNumber),
                CorrespondencePostOfficeCity = GetValueFromColumn(dataTable, "CORRESPONDENCE_POST_OFFICE_CITY", objNumber)
            };

            return adress;
        }

        private string ValidatePesel(string pesel)    //11 znakow cyfr
        {
            bool correctLength = pesel.Length == 11;
            int peselNumber = int.Parse(pesel);
            

            return pesel;
        }

        private string GetValueFromColumn(DataTable dataTable, string columnName, int objNumber)
        {
            foreach (DataColumn column in dataTable.Columns)
            {
                if (column.Caption == columnName)
                    return dataTable.Rows[objNumber][column.Caption].ToString();            
            }

            return "Blad pobierania wartosci";
        }

        private string ChooseFile()
        {
            // Set filter for file extension and default file extension 
            OpenFileDialog fileDialog = new OpenFileDialog { Filter = "Excel files|*.xls;*.xlsx;*.xlsm" };

            // Display OpenFileDialog by calling ShowDialog method 
            var fileDialogResult = fileDialog.ShowDialog();

            string pathToFile = null;
            // Get the selected file name
           // if (fileDialogResult == true)
           // {
                // Open document 
                pathToFile = fileDialog.FileName;
                TextBox1.Text = pathToFile;
                return pathToFile;
            //}
            //else
            //    return Exception;
        }

        private ExcelDataSetConfiguration ExcelDataSetConfig()
        {
           return new ExcelDataSetConfiguration()
           {
                // Gets or sets a value indicating whether to set the DataColumn.DataType 
                // property in a second pass.
                UseColumnDataType = true,

                // Gets or sets a callback to obtain configuration options for a DataTable. 
                ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                {

                    // Gets or sets a value indicating the prefix of generated column names.
                    //EmptyColumnNamePrefix = "Column",

                    // Gets or sets a value indicating whether to use a row from the 
                    // data as column names.
                    UseHeaderRow = true,

                    // Gets or sets a callback to determine which row is the header row. 
                    // Only called when UseHeaderRow = true.
                    //ReadHeaderRow = (rowReader) =>
                    //{
                    //    // F.ex skip the first row and use the 2nd row as column headers:
                    //    rowReader.Read();
                    //},

                    // Gets or sets a callback to determine whether to include the 
                    // current row in the DataTable.
                    FilterRow = (rowReader) => { return true; },

                    // Gets or sets a callback to determine whether to include the specific
                    // column in the DataTable. Called once per column after reading the 
                    // headers.
                    FilterColumn = (rowReader, columnIndex) => { return true; }
                }
           };
        }

        public static void ExecuteExample()
        {
            string connectionString = "server=localhost;port=3306;database=mycontext;uid=root;password=gekon666";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                //Create database if not exists                    // BO NIE DZIALA    
                using (Parking contextDB = new Parking(connection, false))
                {
                    contextDB.Database.CreateIfNotExists();
                }

                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // DbConnection that is already opened
                    using (Parking context = new Parking(connection, false))
                    {

                        // Interception/SQL logging
                        context.Database.Log = (string message) => { Console.WriteLine(message); };

                        // Passing an existing transaction to the context
                        context.Database.UseTransaction(transaction);

                        // DbSet.AddRange
                        List<Car> cars = new List<Car>();

                        cars.Add(new Car { Manufacturer = "Nissan", Model = "370Z", Year = 2012 });
                        cars.Add(new Car { Manufacturer = "Ford", Model = "Mustang", Year = 2013 });
                        cars.Add(new Car { Manufacturer = "Chevrolet", Model = "Camaro", Year = 2012 });
                        cars.Add(new Car { Manufacturer = "Dodge", Model = "Charger", Year = 2013 });

                        context.Cars.AddRange(cars);

                        context.SaveChanges();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

    }


    
        // Code-Based Configuration and Dependency resolution
        [DbConfigurationType(typeof(MySqlEFConfiguration))]
        public class Parking : DbContext
        {
            public DbSet<Car> Cars { get; set; }

            public Parking()
                : base()
            {

            }

            // Constructor to use on a DbConnection that is already opened
            public Parking(DbConnection existingConnection, bool contextOwnsConnection)
                : base(existingConnection, contextOwnsConnection)
            {

            }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Car>().MapToStoredProcedures();

                
            }
        }

        public class Car
        {
            public int CarId { get; set; }

            public string Model { get; set; }

            public int Year { get; set; }

            public string Manufacturer { get; set; }
        }

    

}
