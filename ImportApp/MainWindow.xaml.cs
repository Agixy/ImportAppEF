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
    public partial class MainWindow : Window
    {
        private readonly ImportInitializer importInitializer;

        public MainWindow()
        {
            InitializeComponent();
            importInitializer = new ImportInitializer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var path = ChooseFile();
           importInitializer.Start(path);
        }
     
        private string ChooseFile()
        {
            var fileDialog = new OpenFileDialog { Filter = "Excel files|*.xls;*.xlsx;*.xlsm" };
            string path = null;
            if (fileDialog.ShowDialog() == true)
            {
                path = fileDialog.FileName;
            }
            return path;
        }
    }
}
