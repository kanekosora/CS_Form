using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CS_Form
{
    internal class TestButton : Button
    {
        //コンストラクタ
        //クラスを生成したときに呼び出される

        public TestButton(int id,int x, int y, int width, int height)
        {
            //ClickイベントにOnClick関数を登録
            //ボタンをクリックしたときに登録した関数を実行します
            Click += OnCliick;

                Text = id.ToString();　//ボタン内の名前


            Location = new Point(x,y); //ボタンの位置

            Size = new Size(width,height); //ボタンのサイズ
        }
        
        public void OnCliick(object sender, EventArgs e)
        {
            
                MessageBox.Show($"{(Text)}::|'''' ＼\r\n::| 、＿ ＼\r\n::|　(●)　＼\r\n::|人_)⌒:::: ｜\r\n::|⌒´　　／\r\n(⌒ー―′ )\r\n::|");
            
            

        }
    }
}
