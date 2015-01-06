using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PMS.Models
{
    [Table("Iitem")]
    public class IitemModels
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "工程")]
        public int gc { get; set; }

        [Display(Name = "项名")]
        [MaxLength(40)]
        public string key { get; set; }

        [Display(Name = "值")]
        public DateTime? value { get; set; }

        [Display(Name = "序号")]
        public int order { get; set; }

        [Display(Name = "父节点")]
        public int? parent { get; set; }

    }
}