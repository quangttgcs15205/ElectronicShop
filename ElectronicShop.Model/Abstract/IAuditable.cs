using System;

namespace ElectronicShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        String CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        String UpdatedBy { get; set; }

        string MetaKeyWord { get; set; }
        string MetaDescription { get; set; }


        bool Status { get; set; }
    }
}