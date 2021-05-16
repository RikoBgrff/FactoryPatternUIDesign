using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternUIDesign
{
    class FlatCheckBox : CheckBox
    {
        public FlatCheckBox()
        {
            IsChecked = false;
            Style = "Flat";
        }
        public bool IsChecked { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Style { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
