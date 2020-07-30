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
    public partial class 현금 : Form
    {
        public 현금()
        {
            InitializeComponent();
        }

        영수증 cashreceipt = new 영수증();
        menu cashreading = new menu();

        카드결제 cardreading2 = new 카드결제();

        public int cashall = 0;
        public string 현금영수증확인 = " ";
        public string 오캐이캐시백확인 = " ";

        

        private void 받을금액_load(object sender, EventArgs e)
        {
            받을금액.Text = cashreading.all.ToString();
        }

        private void 받은금액_TextChanged(object sender, EventArgs e)
        {
            cashall = cashreading.all - int.Parse(받은금액.Text);
            거스름돈.Text = cashall.ToString();
        }
        
        private void 단순결제요청_Click(object sender, EventArgs e)
        {
            
        }

        private void 현금영수중_TextChanged(object sender, EventArgs e)
        {
            현금영수증확인 = 현금영수중.Text.ToString();
        }

        private void 오캐이캐시백_TextChanged(object sender, EventArgs e)
        {
            오캐이캐시백확인 = 오캐이캐시백.Text.ToString();
        }

        

        private void 승인요청_Click(object sender, EventArgs e)
        {
            cardreading2.Show();
        }

        private void 승인요쳥시간_Tick(object sender, EventArgs e)
        {
            cardreading2.Hide();
            cashreceipt.Show();
        }
    }
}
