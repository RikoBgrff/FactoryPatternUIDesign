using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternUIDesign
{
    class RetroButton : Button
    {
        public RetroButton()
        {
            Text = "OK";
            Style = "Retro Design";
        }
        public string Text { get; set; }
        public string Style { get; set; }
    }
}