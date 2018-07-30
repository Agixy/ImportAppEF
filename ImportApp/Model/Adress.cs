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
    public class Adress //: BaseModel
    {
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        public string StreetName { get; set; }
        [Column(TypeName = "VARCHAR")]
        public string StreetNumber { get; set; }
        [Column(TypeName = "VARCHAR")]
        public string FlatNumber { get; set; }
        [Column(TypeName = "VARCHAR")]
        public string PostCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        public string PostOfficeCity { get; set; }
        [Column(TypeName = "VARCHAR")]
        public string CorrespondenceStreetName { get; set; }
        [Column(TypeName = "VARCHAR")]
        public string CorrespondenceStreetNumber { get; set; }
        [Column(TypeName = "VARCHAR")]
        public string CorrespondenceFlatNumber { get; set; }
        [Column(TypeName = "VARCHAR")]
        public string CorrespondencePostCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        public string CorrespondencePostOfficeCity { get; set; }

        public virtual List<Person> Persons { get; set; }
        
      

    }
}
