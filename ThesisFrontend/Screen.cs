using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesisFrontend
{
    public class Screen
    {
        public TableLayoutPanel screen;

        public Screen()
        {
            screen.Show();
        }

        public void Close()
        {
            Close();
        }

        public virtual void Run()
        {

        }
    }
}
