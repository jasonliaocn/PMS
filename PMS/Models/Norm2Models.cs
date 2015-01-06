using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PMS.Models
{
    [Table("Norm2")]
    public class Norm2Models
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "名称")]
        [MaxLength(40)]
        public string name { get; set; }

        [Display(Name = "类型")]
        [MaxLength(40)]
        public string type { get; set; }

        [Display(Name = "数量")]
        [MaxLength(40)]
        public string addition { get; set; }
    }
}