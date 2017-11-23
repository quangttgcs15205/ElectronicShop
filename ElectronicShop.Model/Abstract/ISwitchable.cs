using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShop.Model.Abstract
{
    public interface ISwitchable
    {
        bool Status { get; set; }
    }
}
