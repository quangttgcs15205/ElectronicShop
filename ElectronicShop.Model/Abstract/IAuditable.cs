using System;

namespace ElectronicShop.Model.Abstract
{
    internal interface IAuditable
    {
        DateTime CreatedDate { get; set; }
        String CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        String UpdatedBy { get; set; }
    }
}