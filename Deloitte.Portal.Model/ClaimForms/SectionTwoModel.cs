using System;
using System.Collections.Generic;
using System.Text;

namespace Deloitte.Portal.Model.ClaimForms
{
    public class SectionTwoModel
    {
        public string nameOfFirstNation { get; set; }
        public string Proviences { get; set; }
        public string firstNationBandNumber { get; set; }
        public DateTime startDateOfWaterAdvisory { get; set; }
        public DateTime endDateOfWaterAdvisory { get; set; }
        public string impactedFirstNationFromMonth { get; set; }
        public int impactedFirstNationFromYear { get; set; }
        public string impactedFirstNationToMonth { get; set; }
        public int impactedFirstNationToYear { get; set; }
    }
}
