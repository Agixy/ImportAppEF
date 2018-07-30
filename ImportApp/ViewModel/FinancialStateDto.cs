using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportApp.ViewModel
{
    class FinancialStateDto
    {
        public int Id { get; set; }
        public decimal OutstandingLiabilites { get; set; }
        public decimal Interests { get; set; }
        public decimal PenaltyInterests { get; set; }
        public decimal Fees { get; set; }
        public decimal CourtFees { get; set; }
        public decimal RepresentationCourtFees { get; set; }
        public decimal VindicationCosts { get; set; }
        public decimal RepresentationVindicationCosts { get; set; }

    
    }
}
