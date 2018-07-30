using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportApp.Model
{
    public class Agreement
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public virtual int PersonId { get; set; }
        public virtual int FinancialStateId { get; set; }
    }
}
