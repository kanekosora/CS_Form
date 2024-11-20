using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    internal class Test_Label : Label
    {
        //コンストラクタ
        //クラスを生成したときに呼び出される

        public Test_Label( string str, int x,
            int y, int width, int height)
        {
            Text = str;　//ボタン内の名前

            Location = new Point(x, y); //ボタンの位置

            Size = new Size(width, height); //ボタンのサイズ
        }
        /// <summary>
        /// ラベルの文字変更関数
        /// </summary>
        /// <param name="str"></param>
        public void TextUpdate(string str)
        {
            Text = str;
        }
    }
}
