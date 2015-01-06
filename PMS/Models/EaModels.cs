using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PMS.Models
{
    [Table("ea")]
    public class EaModels
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "工程")]
        public int eainfo { get; set; }

        [Display(Name = "材料名称")]
        [MaxLength(40)]
        public string name { get; set; }

        [Display(Name = "材料类型")]
        [MaxLength(40)]
        public string type { get; set; }

        [Display(Name = "材料数量")]
        public int amount { get; set; }

        [Display(Name = "附加信息")]
        [MaxLength(40)]
        public string addition { get; set; }

        [Display(Name = "使用日期")]
        public DateTime? date { get; set; }
    }
}