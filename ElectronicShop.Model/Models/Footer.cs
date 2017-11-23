using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ElectronicShop.Model.Models
{
    [Table("Footers")]
    class Footer
    {
        [Key]
        public string ID { set; get;}

        [Required]
        public string content { set; get; }

    }
}
