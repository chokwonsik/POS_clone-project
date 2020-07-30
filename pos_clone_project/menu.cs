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
    public partial class menu : Form
    {

        메인메뉴 mainmenu = new 메인메뉴();
        현금 cash = new 현금();
        신용카드 credit = new 신용카드();
        
        private void 신용카드_Click(object sender, EventArgs e)
        {
            credit.Show();
        }

        private void 현금_Click(object sender, EventArgs e)
        {
            
            cash.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mainmenu.ShowDialog();
        }

        public menu()
        {
            InitializeComponent();
          
        }

        
        


        private void label1_Click(object sender, EventArgs e) //날짜출력 이벤트
        {
            DateTime today = DateTime.Now; //날짜,시간을 표시해주는 매서드 선언
            clock.Text = string.Format("{0:yyyy/mm/dd HH:mm:ss}", today); //년 월 일 시 분 초 표시
        }
        
        
        private void button5_Click(object sender, EventArgs e) // 전체취소 버튼
        {
            상품명1.Text = "";          //초기화
            단가1.Text = "";             //초기화
            수량1.Text = "";            //초기화
            금액1.Text = "";            //초기화
            총수량.Text = "";           //초기화
            합계.Text = "";              //초기화
            총금액.Text = "";           //초기화
        }

        public int rosso = 13000;
        public int piccante = 15500;
        public int dellalpe = 18500;
        private int allcount = 0;
        public int all = 0;

        public void rossofood()
        {
            
            상품명1.Text = 상품명1.Text + "로쏘\n";
            단가1.Text = 단가1.Text + "13000\n";
            수량1.Text = 수량1.Text + mainmenu.rossocount.ToString() + "\n";
            금액1.Text = 금액1.Text + (rosso * mainmenu.rossocount).ToString() + "\n";
            
            allcount = allcount + mainmenu.rossocount;
            총수량.Text = allcount.ToString();

            all = all + (rosso * mainmenu.rossocount);
            합계.Text = all.ToString();
            총금액.Text = all.ToString();

        }

        public void piccantefood()
        {
            상품명1.Text = 상품명1.Text + "피칸테\n";
            단가1.Text = 단가1.Text + "15500\n";
            수량1.Text = 수량1.Text + mainmenu.piccantecount.ToString() + "\n";
            금액1.Text = 금액1.Text + (piccante * mainmenu.piccantecount).ToString() + "\n";

            allcount = allcount + mainmenu.piccantecount;
            총수량.Text = allcount.ToString();

            all = all + (piccante * mainmenu.piccantecount);
            합계.Text = all.ToString();
            총금액.Text = all.ToString();
        }

        public void dellalpefood()
        {
            상품명1.Text = 상품명1.Text + "델랄페\n";
            단가1.Text = 단가1.Text + "18500\n";
            수량1.Text = 수량1.Text + mainmenu.dellalpecount.ToString() + "\n";
            금액1.Text = 금액1.Text + (dellalpe * mainmenu.dellalpecount).ToString() + "\n";

            allcount = allcount + mainmenu.dellalpecount;
            총수량.Text = allcount.ToString();

            all = all + (dellalpe * mainmenu.dellalpecount);
            합계.Text = all.ToString();
            총금액.Text = all.ToString();
        }


        //로쏘     13000
        //피칸테   15500
        //델랄페   18500




    }
}
