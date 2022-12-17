using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Deloitte.Portal.Model.ClaimForms
{
    public class SpecifiedInjuries
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int SPID { get; set; }
        public string Name { get; set; }
    }
}
