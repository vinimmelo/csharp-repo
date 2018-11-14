using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElephantSwap
{
    class Elephant
    {

        public int EarSize { get; set; }
        public string Name { get; set; }
        
        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + EarSize + " inches tall.",
                this.Name + " says...");
        }
    }
}
