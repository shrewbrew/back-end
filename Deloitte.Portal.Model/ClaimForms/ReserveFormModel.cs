using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Deloitte.Portal.Model.ClaimForms
{
    public class ReserveFormModel
    {
        //Lookup Records
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int reserveID { get; set; }
        public string Name { get; set; }
        public string Proviences { get; set; }
        public string firstNationBandNumber { get; set; }
        public DateTime startDateOfWaterAdvisory { get; set; }
        public DateTime endDateOfWaterAdvisory { get; set; }

        public virtual ICollection<ClaimReserveForm> ClaimReserve { get; set; }

    }
}
