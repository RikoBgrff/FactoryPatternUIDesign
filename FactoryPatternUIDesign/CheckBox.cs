using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternUIDesign
{
    interface CheckBox
    {
        bool IsChecked { get; set; }
        string Style { get; set; }
    }
}
