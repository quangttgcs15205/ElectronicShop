﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectronicShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public string ID { set; get; }

        [Required]
        public string content { set; get; }
    }
}