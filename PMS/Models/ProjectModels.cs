using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PMS.Models
{
    [Table("gc")]
    public class ProjectModels
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set;}

        [Display(Name = "工程编号")]
        [MaxLength(18)]
        public string gcno { get; set; }

        [Display(Name = "工程名称")]
        [MaxLength(100)]
        public string name { get; set; }

        [Display(Name = "建设单位名称")]
        [MaxLength(100)]
        public string builder { get; set; }

        [Display(Name = "工程地址")]
        [MaxLength(100)]
        public string location { get; set; }

        [Display(Name = "输入者")]
        [MaxLength(20)]
        public string user { get; set; }

        [Display(Name = "创建日期")]
        public DateTime? when { get; set; }

        [Display(Name = "状态")]
        [MaxLength(1)]
        public string status { get; set; }

        [Display(Name = "模板")]
        [MaxLength(40)]
        public string temp { get; set; }

        [Display(Name = "自来水编号")]
        [MaxLength(40)]
        public string water { get; set; }

    }
}