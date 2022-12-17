using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Deloitte.Portal.Model.ClaimForms
{
    public class ClaimFile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("claimID")]
        public virtual ClaimFormsModel claimId { get; set; }

        [ForeignKey("fileId")]
        public virtual File fileID { get; set; }


    }
}
