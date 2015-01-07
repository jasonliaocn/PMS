using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PMS.Models
{
    [Table("Titem")]
    public class TitemModels
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "模板")]
        public int template { get; set; }

        [Display(Name = "项名")]
        [MaxLength(40)]
        public string key { get; set; }

        [Display(Name = "序号")]
        public int order { get; set; }

        [Display(Name = "父节点")]
        public int? parent { get; set; }

    }
}