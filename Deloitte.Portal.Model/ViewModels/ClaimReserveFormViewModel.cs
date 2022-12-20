using Deloitte.Portal.Model.ClaimForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deloitte.Portal.Model.ViewModels
{
    public class ClaimReserveFormViewModel
    {
        public int claimID { get; set; }
        public string nameOfFirstNation { get; set; }
        public string provinceOrTerritory { get; set; }
        public string firstNationBandNumber { get; set; }
        public string waterAdvisoryStartDate { get; set; }
        public string waterAdvisoryEndDate { get; set; }
        public string fromMonth { get; set; }
        public string fromYear { get; set; }
        public string toMonth { get; set; }
        public string toYear { get; set; }
    }
}
