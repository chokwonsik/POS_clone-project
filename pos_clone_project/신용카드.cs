using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201504040_조권식_기말프로젝트
{
    public partial class 신용카드 : Form
    {
        public 신용카드()
        {
            InitializeComponent();
        }
        menu card = new menu();
        카드결제 cardreading = new 카드결제();
        영수증 cardreceipt = new 영수증();

        public int cardall = 0;
        public string carnumber = " ";
        public string month = " " ;

        private void 결제예정금액_Load(object sender, EventArgs e) //프로그램실행시 실행
        {
            결제예정금액.Text = card.all.ToString();               //결제예정금액.Text에 메뉴 클래스의 all 값을 넣는다
            결제대상금액.Text = card.all.ToString();               //결제대상금액.Text에 메뉴 클래스의 all 값을 넣는다
        }


        private void 로열티할인금액_TextChanged(object sender, EventArgs e) //로열티할인발생할경우실행
        {
            
            cardall = card.all - int.Parse(로열티할인금액.Text);           // 메뉴 클래스의 all 값을  로열티할인금액.Text 뺀값을 카드올 변수에 넣는다.
            결제대상금액.Text = cardall.ToString();                        //결제대상금액.Text에 카드올을 넣어준다.
        }

        private void 결제요청_Click(object sender, EventArgs e)
        {
            cardreading.Show();
 
        }

        private void 결제요청시간_Tick(object sender, EventArgs e)     //결제요청후 4초가 지나면 카드결제창을종료한다.
        {
            cardreading.Hide();
            cardreceipt.Show();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            month = textBox3.Text.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            carnumber = textBox1.Text.ToString();
        }
    }
}
