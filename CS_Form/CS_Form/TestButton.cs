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
        Form1 _form1;

        //コンストラクタ
        //クラスを生成したときに呼び出される

        public TestButton(Form1 form1, int id,int x, int y, int width, int height)
        {
            _form1 = form1;

            //ClickイベントにOnClick関数を登録
            //ボタンをクリックしたときに登録した関数を実行します
            Click += OnCliick;
            string[] unk = new string[10] {"あ","い","う","え","お","か","き","く","け","こ"} ;
            
            Text = unk[id].ToString();　//ボタン内の名前

            Location = new Point(x,y); //ボタンの位置

            Size = new Size(width,height); //ボタンのサイズ
        }
        
        public void OnCliick(object sender, EventArgs e)
        {
            _form1.LabelTextUodate(Text);
        }
    }
}
