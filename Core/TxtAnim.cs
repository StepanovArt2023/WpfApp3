using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.Windows;

namespace WpfApp3.Core
{
    public partial class OpasAnim
    {
        public DoubleAnimation OpasAnim1() {
            DoubleAnimation gs = new DoubleAnimation();
            gs.From = 0;
            gs.To = 1;
            gs.Duration = new Duration(TimeSpan.FromSeconds(2));
            return gs;
        
    }
    }
}
