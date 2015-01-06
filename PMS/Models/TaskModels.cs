using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PMS.Models
{
    [Table("Task")]
    public class TaskModels
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "任务名")]
        [MaxLength(40)]
        public string Name { get; set; }

        [Display(Name = "组")]
        public int Who { get; set; }

        [Display(Name = "状态")]
        [MaxLength(1)]
        public string status { get; set; }

        [Display(Name = "类型")]
        [MaxLength(4)]
        public string type { get; set; }

        [Display(Name = "待处理项Id")]
        public int item { get; set; }
    }
}