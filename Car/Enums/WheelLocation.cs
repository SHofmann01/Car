using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Enums
{
    public enum WheelLocation
    {
        [Description("Vorne links")]
        FrontLeft,
        
        [Description("Vorne rechts")]
        FrontRight,

        [Description("Hinten links")]
        RearLeft,

        [Description("Hinten rechts")]
        RearRight
    }
}
