namespace _201504040_조권식_기말프로젝트
{
    partial class 신용카드
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.신용카드비밀번호 = new System.Windows.Forms.TextBox();
            this.결제예정금액 = new System.Windows.Forms.Label();
            this.결제대상금액 = new System.Windows.Forms.Label();
            this.로열티할인금액 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.결제요청 = new System.Windows.Forms.Button();
            this.ㅍ = new System.Windows.Forms.Button();
            this.취소 = new System.Windows.Forms.Button();
            this.결제요청시간 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_201504040_조권식_기말프로젝트.Properties.Resources.카드결제2;
            this.pictureBox1.Location = new System.Drawing.Point(221, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(688, 838);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // 신용카드비밀번호
            // 
            this.신용카드비밀번호.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.신용카드비밀번호.Location = new System.Drawing.Point(483, 151);
            this.신용카드비밀번호.Multiline = true;
            this.신용카드비밀번호.Name = "신용카드비밀번호";
            this.신용카드비밀번호.PasswordChar = '*';
            this.신용카드비밀번호.Size = new System.Drawing.Size(189, 31);
            this.신용카드비밀번호.TabIndex = 3;
            // 
            // 결제예정금액
            // 
            this.결제예정금액.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.결제예정금액.Location = new System.Drawing.Point(543, 207);
            this.결제예정금액.Name = "결제예정금액";
            this.결제예정금액.Size = new System.Drawing.Size(185, 30);
            this.결제예정금액.TabIndex = 4;
            // 
            // 결제대상금액
            // 
            this.결제대상금액.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.결제대상금액.Location = new System.Drawing.Point(543, 301);
            this.결제대상금액.Name = "결제대상금액";
            this.결제대상금액.Size = new System.Drawing.Size(185, 30);
            this.결제대상금액.TabIndex = 5;
            // 
            // 로열티할인금액
            // 
            this.로열티할인금액.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.로열티할인금액.Location = new System.Drawing.Point(545, 251);
            this.로열티할인금액.Multiline = true;
            this.로열티할인금액.Name = "로열티할인금액";
            this.로열티할인금액.Size = new System.Drawing.Size(183, 31);
            this.로열티할인금액.TabIndex = 6;
            this.로열티할인금액.TextChanged += new System.EventHandler(this.로열티할인금액_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(483, 428);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 31);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox2.Location = new System.Drawing.Point(483, 476);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 31);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox3.Location = new System.Drawing.Point(483, 522);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 31);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // 결제요청
            // 
            this.결제요청.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.결제요청.ForeColor = System.Drawing.Color.White;
            this.결제요청.Location = new System.Drawing.Point(702, 617);
            this.결제요청.Name = "결제요청";
            this.결제요청.Size = new System.Drawing.Size(97, 45);
            this.결제요청.TabIndex = 10;
            this.결제요청.Text = "결제요청";
            this.결제요청.UseVisualStyleBackColor = false;
            this.결제요청.Click += new System.EventHandler(this.결제요청_Click);
            // 
            // ㅍ
            // 
            this.ㅍ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ㅍ.ForeColor = System.Drawing.Color.White;
            this.ㅍ.Location = new System.Drawing.Point(702, 687);
            this.ㅍ.Name = "ㅍ";
            this.ㅍ.Size = new System.Drawing.Size(97, 45);
            this.ㅍ.TabIndex = 11;
            this.ㅍ.Text = "서명요청";
            this.ㅍ.UseVisualStyleBackColor = false;
            // 
            // 취소
            // 
            this.취소.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.취소.ForeColor = System.Drawing.Color.White;
            this.취소.Location = new System.Drawing.Point(702, 763);
            this.취소.Name = "취소";
            this.취소.Size = new System.Drawing.Size(97, 45);
            this.취소.TabIndex = 12;
            this.취소.Text = "취소";
            this.취소.UseVisualStyleBackColor = false;
            // 
            // 결제요청시간
            // 
            this.결제요청시간.Enabled = true;
            this.결제요청시간.Interval = 4000;
            this.결제요청시간.Tick += new System.EventHandler(this.결제요청시간_Tick);
            // 
            // 신용카드
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 808);
            this.Controls.Add(this.취소);
            this.Controls.Add(this.ㅍ);
            this.Controls.Add(this.결제요청);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.로열티할인금액);
            this.Controls.Add(this.결제대상금액);
            this.Controls.Add(this.결제예정금액);
            this.Controls.Add(this.신용카드비밀번호);
            this.Controls.Add(this.pictureBox1);
            this.Name = "신용카드";
            this.Text = "신용카드";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox 신용카드비밀번호;
        private System.Windows.Forms.Label 결제예정금액;
        private System.Windows.Forms.Label 결제대상금액;
        private System.Windows.Forms.TextBox 로열티할인금액;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button 결제요청;
        private System.Windows.Forms.Button ㅍ;
        private System.Windows.Forms.Button 취소;
        private System.Windows.Forms.Timer 결제요청시간;
    }
}