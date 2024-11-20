using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        Test_Label _test_Label;

        TestTextBox _textBox; 


        public Form1()
        {
            InitializeComponent();

            /*  for(int x = 1;  x<= 100; x++)
              {

                      TestButton testButton  = new TestButton (x, 10, 50, 50);
                      Controls.Add(testButton);
              }*/
            for (int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton(this, i, i % 5 * 100, (i / 5) * 100, 100, 100);
                Controls.Add(testButton);
            }

            _test_Label =
                  new Test_Label("らべるです", 10, 300, 100, 500);

            /*Label label = new Label();
            label.Location = new Point(39, 400);
            label.Text = "ラベルです";*/

            Controls.Add(_test_Label);

            _textBox = new TestTextBox(Text, 150, 300, 500, 100);

                Controls.Add(_textBox);


        }
        /// <summary>
        /// ラベルの文字変更
        /// </summary>
        /// <param name="str"></param>
        /// 

        public void LabelTextUodate(string str)
        {
            _test_Label.TextUpdate(str);
        }
        public string ButtonLabelReplacement(string str)
        {
           string s = _textBox.TextReplacement(str);

            return s;
        }
    }
}
