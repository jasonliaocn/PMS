using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PMS.Models
{
    [Table("Ys")]
    public class BudgetModels
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "工程")]
        public int gc { get; set; }

        [Display(Name = "类型")]
        [MaxLength(16)]
        public string type { get; set; }

        [Display(Name = "工程造价")]
        public double price { get; set; }

        [Display(Name = "完成日期")]
        public DateTime? finish { get; set; }

        [Display(Name = "决算审定价格")]
        public double account { get; set; }

        [Display(Name = "决算审定报告签署日期")]
        public DateTime? accassdate { get; set; }

        [Display(Name = "决算审定日期")]
        public DateTime? accdate { get; set; }

        [Display(Name = "审价费")]
        public double acccost { get; set; }

        [Display(Name = "审价费付款日期")]
        public DateTime? paydate { get; set; }

        [Display(Name = "审价单位")]
        [MaxLength(40)]
        public string accorg { get; set; }

        [Display(Name = "审价员")]
        [MaxLength(16)]
        public string accounter { get; set; }

        [Display(Name = "审价员手机号")]
        [MaxLength(8)]
        public string phone { get; set; }

        [Display(Name = "审价员固定电话")]
        [MaxLength(11)]
        public string telephone { get; set; }

        [Display(Name = "状态")]
        [MaxLength(1)]
        public string status { get; set; }

        [Display(Name = "审核时间")]
        public DateTime? audit { get; set; }

        [Display(Name = "预算价格")]
        public double ysdone { get; set; }

    }
}