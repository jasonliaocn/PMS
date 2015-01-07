using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PMS.Models
{
    [Table("Pay")]
    public class PayModels
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "工程")]
        public int gc { get; set; }

        [Display(Name = "收到发票日期")]
        public DateTime? receive { get; set; }

        [Display(Name = "支出款额")]
        public double pay { get; set; }

        [Display(Name = "发票文本")]
        public string voucher { get; set; }

        [Display(Name = "付款日期")]
        public DateTime? paydate { get; set; }

        [Display(Name = "状态")]
        [MaxLength(1)]
        public string status { get; set; }

        [Display(Name = "收款单位")]
        [MaxLength(100)]
        public string receiver { get; set; }

        [Display(Name = "发票编号")]
        [MaxLength(40)]
        public string no { get; set; }

        [Display(Name = "付款内容")]
        public string content { get; set; }

        [Display(Name = "付款性质")]
        [MaxLength(30)]
        public string type { get; set; }

        [Display(Name = "发票金额")]
        public double invoice { get; set; }
    }
}