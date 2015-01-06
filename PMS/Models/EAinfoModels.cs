using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PMS.Models
{
    [Table("eainfo")]
    public class EAinfoModels
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "工程")]
        public int gc { get; set; }

        [Display(Name = "施工单位")]
        [MaxLength(100)]
        public string builder { get; set; }

        [Display(Name = "合同签订日期")]
        public DateTime? agreed { get; set; }

        [Display(Name = "合同价格")]
        [MaxLength(100)]
        public double price { get; set; }

        [Display(Name = "合同签订单位")]
        [MaxLength(100)]
        public string partner { get; set; }

        [Display(Name = "合同签订者姓名")]
        [MaxLength(16)]
        public string man { get; set; }

        [Display(Name = "合同签订者手机号码")]
        [MaxLength(11)]
        public string phone { get; set; }

        [Display(Name = "合同签订者联系固定电话")]
        [MaxLength(8)]
        public string telephone { get; set; }

        [Display(Name = "状态")]
        [MaxLength(1)]
        public string status { get; set; }

        [Display(Name = "开工日期")]
        public DateTime? begin { get; set; }

        [Display(Name = "试压日期")]
        public DateTime? test { get; set; }

        [Display(Name = "竣工日期")]
        public DateTime? finish { get; set; }

        [Display(Name = "竣工草图")]
        public DateTime? design { get; set; }

        [Display(Name = "验收日期")]
        public DateTime? accept { get; set; }

    }
}