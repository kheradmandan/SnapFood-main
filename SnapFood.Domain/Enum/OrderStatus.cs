using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFood.Domain.Enum
{
    public enum OrderStatus
    {
        Preview = 0,
        GettingReady = 1,
        Delivered = 2,
        CancelByRest = 3,
        CancelByUser = 4
    }
}
