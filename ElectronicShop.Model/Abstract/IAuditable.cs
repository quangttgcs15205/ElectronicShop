using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShop.Model.Abstract
{
    interface IAuditable
    {
        DateTime CreatedDate { get; set; }
        String CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        String UpdatedBy { get; set; }
    }
}
