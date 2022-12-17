using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Deloitte.Portal.Model.ClaimForms
{
    public class File
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int fileId { get; set; }
        public string fileName  { get; set; }
        public string fileLocation { get; set; }
        public string  fileSize { get; set; }
        public string  documentType { get; set; }
        public string fileExtension { get; set; }

        public virtual ICollection<ClaimFile> ClaimFiles { get; set; }
    }
}
