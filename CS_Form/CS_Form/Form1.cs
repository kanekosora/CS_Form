using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          /*  for(int x = 1;  x<= 100; x++)
            {
                
                    TestButton testButton  = new TestButton (x, 10, 50, 50);
                    Controls.Add(testButton);
            }*/
          for (int i = 0; i < 100; i++)
            {
                TestButton testButton = new TestButton(i,i%10*100, (i/10)*100, 100, 100);
                Controls.Add(testButton);
            }
            
        }
    }
}
