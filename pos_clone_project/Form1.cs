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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
       
        private void Login_Click(object sender, EventArgs e) //로그인 버튼 클릭시 발생하는 이벤트
        {
            if (ID.Text == "admin" && PASSWORD.Text == "성서대10")  //로그인 성공시 실행
            {
                Table Table = new Table(); // 테이블 클래스 객체화
                this.Hide();   //로그인은 성공시 다시로그인할 필요가 없기때문에 숨긴다.
                Table.Show();              //객체화한 table를 실행
            }
            else //로그인 실패시 실행
            {
                MessageBox.Show(" 아이디와와 패스워드를 다시 입력해주세요."); //아이디와패스워드실패시 출력할 메시지박스창
                
                
                 
            }

        }
    }
}
