using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternUIDesign
{
    class RetroCheckBox : CheckBox
    {
        public RetroCheckBox()
        {
            IsChecked = true;
            Style = "Retro";
        }
        public bool IsChecked { get; set; }
        public string Style { get; set; }
    }
}
