using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PMS.Controllers
{
    [Table("Yscl")]
    public class BudgetMaterialModels
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "预决算")]
        public int ys { get; set; }

        [Display(Name = "材料名称")]
        [MaxLength(40)]
        public string name { get; set; }

        [Display(Name = "材料规格")]
        public int amount { get; set; }

        [Display(Name = "附加信息")]
        [MaxLength(40)]
        public string addition { get; set; }
    }
}