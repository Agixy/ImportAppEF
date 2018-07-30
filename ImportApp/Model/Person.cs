using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportApp.Model
{
    public class Person //: BaseModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string NationalIdentificationNumber { get; set; }       
        public string PhoneNumber { get; set; }
        public string PhoneNumber2 { get; set; }
        public virtual Adress Adress { get; set; }



    }

}

