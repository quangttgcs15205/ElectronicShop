using System;
using System.ComponentModel.DataAnnotations;

namespace ElectronicShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    // mot lop ao trien khai interface Iauditable//
    {
        public DateTime? CreatedDate { get; set; }

        [MaxLength(256)]
        public String CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]
        public String UpdatedBy { get; set; }


        [MaxLength(256)]
        public string MetaKeyWord { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }


    }
}