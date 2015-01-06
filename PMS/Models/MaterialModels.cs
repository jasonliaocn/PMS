using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PMS.Models
{
    [Table("cl")]
    public class MaterialModels
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "工程")]
        public int gc { get; set; }

        [Display(Name = "输入者")]
        public int user { get; set; }

        [Display(Name = "输入日期")]
        public DateTime? time { get; set; }

        [Display(Name = "合同签订日期")]
        public DateTime? done { get; set; }

        [Display(Name = "合同价格")]
        public double cost { get; set; }

        [Display(Name = "签合同单位名称")]
        [MaxLength(100)]
        public string partner { get; set; }

        [Display(Name = "对方盖章日期")]
        public DateTime? agreed { get; set; }

        [Display(Name = "合同签订者")]
        [MaxLength(20)]
        public string president { get; set; }

        [Display(Name = "签订者手机")]
        [MaxLength(11)]
        public string phone { get; set; }

        [Display(Name = "签订者固话")]
        [MaxLength(8)]
        public string telephone { get; set; }

        [Display(Name = "状态")]
        [MaxLength(1)]
        public string status { get; set; }
    }
}