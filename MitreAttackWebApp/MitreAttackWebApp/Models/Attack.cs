using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MitreAttackWebApp.Models
{
    public class Attack
    {
        [Key]
        public int AtackID { get; set; }
        public string AttackCode { get; set; }
        public string AttackResult { get; set; }
        public DateTime AttackDate { get; set; }
        public TimeSpan AttackTime { get; set; }
    }
}