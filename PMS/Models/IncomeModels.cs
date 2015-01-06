using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PMS.Models
{
    [Table("Income")]
    public class IncomeModels
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "工程")]
        public int gc { get; set; }

        [Display(Name = "工程合同林高盖章日期")]
        public DateTime? done { get; set; }

        [Display(Name = "合同价格")]
        public double price { get; set; }

        [Display(Name = "合同签订单位")]
        [MaxLength(100)]
        public string partner { get; set; }

        [Display(Name = "盖章日期")]
        public DateTime? agreed { get; set; }

        [Display(Name = "状态")]
        [MaxLength(1)]
        public string status { get; set; }

        [Display(Name = "开发票日期")]
        public DateTime? send { get; set; }

        [Display(Name = "发票编号")]
        [MaxLength(40)]
        public string no { get; set; }

        [Display(Name = "收入款额")]
        public double income { get; set; }

        [Display(Name = "收款日期")]
        public DateTime? incdate { get; set; }

        [Display(Name = "付款单位")]
        [MaxLength(100)]
        public string payer { get; set; }

        [Display(Name = "收款内容")]
        public string desc { get; set; }

        [Display(Name = "收款类型")]
        [MaxLength(10)]
        public string type { get; set; }

    }
}