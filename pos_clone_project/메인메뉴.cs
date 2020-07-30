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
    public partial class 메인메뉴 : Form
    {
        
        public 메인메뉴()
        {
            InitializeComponent();
        }


        public int rossocount = 0;          //수량 카운트할 변수 초기화
        public int piccantecount = 0;          //수량 카운트할 변수 초기화
        public int dellalpecount = 0;          //수량 카운트할 변수 초기화

        private void 로쏘증가_Click(object sender, EventArgs e)
        {
           
            rossocount++;
            로쏘갯수.Text = 로쏘갯수.Text+ rossocount.ToString();  
        }

        private void 로쏘감소_Click(object sender, EventArgs e)
        {
           
            rossocount--;
            로쏘갯수.Text = 로쏘갯수.Text + rossocount.ToString();
        }
        
       



        private void 피칸테증가_Click(object sender, EventArgs e)
        {
           
            piccantecount++;
            피칸테갯수.Text = 피칸테갯수.Text + piccantecount.ToString();
        }

        private void 피칸테감소_Click(object sender, EventArgs e)
        {
            piccantecount--;
            피칸테갯수.Text = 피칸테갯수.Text + piccantecount.ToString();
        }

      



        private void 델랄페증가_Click(object sender, EventArgs e)
        {
            
            dellalpecount++;
            델랄페갯수.Text = 델랄페갯수.Text + dellalpecount.ToString();
        }

        private void 델랄페감소_Click(object sender, EventArgs e)
        {
            
            dellalpecount--;
            델랄페갯수.Text = 델랄페갯수.Text + dellalpecount.ToString();
        }

        

        private void 메인메뉴닫기_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
