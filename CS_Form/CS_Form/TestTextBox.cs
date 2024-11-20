using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CS_Form
{
    internal class TestTextBox : TextBox
    {
        public TestTextBox(string str, int x,
          int y, int width, int height)
        { 
            Text = str;　//ボタン内の名前

            Location = new Point(x, y); //ボタンの位置

            Size = new Size(width, height); //ボタンのサイズ
        }

        public string TextReplacement(string str)
        {
            string tenp = Text;

            Text = str;

            return tenp;
        }
    }
}
