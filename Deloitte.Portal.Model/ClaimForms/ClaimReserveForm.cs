using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Deloitte.Portal.Model.ClaimForms
{
    public class ClaimReserveForm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CRId { get; set; }

        //Navigation Property
        [ForeignKey("claimID")]
        public virtual ClaimFormsModel ClaimId { get; set; }

        [ForeignKey("reserveID")]
        public virtual ReserveFormModel reserveId { get; set; }

        public string nameOfFirstNation { get; set; }
        public string provinceOrTerritory { get; set; }
        public string firstNationBandNumber { get; set; }
        public DateTime waterAdvisoryStartDate { get; set; }
        public DateTime waterAdvisoryEndDate { get; set; }

        public string fromMonth { get; set; }
        public int fromYear { get; set; }
        public string toMonth { get; set; }
        public int toYear { get; set; }

    }
}
