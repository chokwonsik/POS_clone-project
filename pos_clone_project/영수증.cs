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
    public partial class 영수증 : Form
    {
        public 영수증()
        {
            InitializeComponent();
        }
        신용카드 sky = new 신용카드();
        현금 sky2 = new 현금();

        private void 영수증_Load(object sender, EventArgs e)
        {
            영수증현금영수증.Text = sky2.현금영수증확인;
            영수증오캐이캐시백.Text = sky2.오캐이캐시백확인;
            카드번호확인.Text = sky.carnumber;
            할부.Text = sky.month;


        }
    }
}
