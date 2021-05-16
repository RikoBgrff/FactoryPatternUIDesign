﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternUIDesign
{
    class RetroUI : UIToolKit_AbstractFactory
    {
        public override Button CreateButton()
        {
            return new RetroButton();
        }

        public override CheckBox CreateCheckBox()
        {
            return new RetroCheckBox();
        }
    }
}
