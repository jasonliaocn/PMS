using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PMS.Models
{
    [Table("cldtl")]
    public class MaterialDTLModels
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "已购材料编号")]
        public int cl { get; set; }

        [Display(Name = "材料名称")]
        [MaxLength(100)]
        public string name { get; set; }

        [Display(Name = "材料规格")]
        [MaxLength(40)]
        public string type { get; set; }

        [Display(Name = "材料属性")]
        [MaxLength(40)]
        public string addtion { get; set; }

        [Display(Name = "材料数量")]
        public int amount { get; set; }

        [Display(Name = "材料价格")]
        public double price { get; set; }

        [Display(Name = "材料品牌")]
        [MaxLength(40)]
        public string company { get; set; }

        [Display(Name = "材料生产厂家")]
        [MaxLength(100)]
        public string deliver { get; set; }

        [Display(Name = "材料供货商")]
        [MaxLength(100)]
        public string vendor { get; set; }

        [Display(Name = "单位")]
        public int unit { get; set; }


    }
}