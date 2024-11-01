using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CS_Form
{
    internal class TestButton : Button
    {

        public TestButton()
        {
            //ClickイベントにOnClick関数を登録
            //ボタンをクリックしたときに登録した関数を実行します
            Click += OnCliick;
        }

        public void OnCliick(object sender, EventArgs e)
        {
            MessageBox.Show("眠い");
        }
    }
}
