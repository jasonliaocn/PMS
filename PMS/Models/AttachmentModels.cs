using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PMS.Models
{
    [Table("Attach")]
    public class AttachmentModels
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "系统文件名")]
        [MaxLength(200)]
        public string sysfilename { get; set; }

        [Display(Name = "文件名")]
        [MaxLength(100)]
        public string filename { get; set; }

        [Display(Name = "元类型")]
        [MaxLength(100)]
        public string mimetype { get; set; }

    }
}