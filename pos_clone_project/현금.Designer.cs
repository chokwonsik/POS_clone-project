namespace _201504040_조권식_기말프로젝트
{
    partial class 현금
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
            this.받을금액 = new System.Windows.Forms.Label();
            this.거스름돈 = new System.Windows.Forms.Label();
            this.받은금액 = new System.Windows.Forms.TextBox();
            this.현금영수중 = new System.Windows.Forms.TextBox();
            this.오캐이캐시백 = new System.Windows.Forms.TextBox();
            this.단순결제요청 = new System.Windows.Forms.Button();
            this.승인요청 = new System.Windows.Forms.Button();
            this.승인요쳥시간 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // 받을금액
            // 
            this.받을금액.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.받을금액.ForeColor = System.Drawing.Color.White;
            this.받을금액.Location = new System.Drawing.Point(237, 92);
            this.받을금액.Name = "받을금액";
            this.받을금액.Size = new System.Drawing.Size(202, 30);
            this.받을금액.TabIndex = 1;
            this.받을금액.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 거스름돈
            // 
            this.거스름돈.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.거스름돈.ForeColor = System.Drawing.Color.White;
            this.거스름돈.Location = new System.Drawing.Point(237, 186);
            this.거스름돈.Name = "거스름돈";
            this.거스름돈.Size = new System.Drawing.Size(202, 30);
            this.거스름돈.TabIndex = 2;
            this.거스름돈.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 받은금액
            // 
            this.받은금액.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.받은금액.Cursor = System.Windows.Forms.Cursors.No;
            this.받은금액.ForeColor = System.Drawing.Color.White;
            this.받은금액.Location = new System.Drawing.Point(239, 143);
            this.받은금액.Multiline = true;
            this.받은금액.Name = "받은금액";
            this.받은금액.Size = new System.Drawing.Size(200, 32);
            this.받은금액.TabIndex = 3;
            this.받은금액.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.받은금액.TextChanged += new System.EventHandler(this.받은금액_TextChanged);
            // 
            // 현금영수중
            // 
            this.현금영수중.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.현금영수중.Cursor = System.Windows.Forms.Cursors.No;
            this.현금영수중.ForeColor = System.Drawing.Color.White;
            this.현금영수중.Location = new System.Drawing.Point(239, 389);
            this.현금영수중.Multiline = true;
            this.현금영수중.Name = "현금영수중";
            this.현금영수중.Size = new System.Drawing.Size(200, 32);
            this.현금영수중.TabIndex = 4;
            this.현금영수중.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.현금영수중.TextChanged += new System.EventHandler(this.현금영수중_TextChanged);
            // 
            // 오캐이캐시백
            // 
            this.오캐이캐시백.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.오캐이캐시백.Cursor = System.Windows.Forms.Cursors.No;
            this.오캐이캐시백.ForeColor = System.Drawing.Color.White;
            this.오캐이캐시백.Location = new System.Drawing.Point(239, 623);
            this.오캐이캐시백.Multiline = true;
            this.오캐이캐시백.Name = "오캐이캐시백";
            this.오캐이캐시백.Size = new System.Drawing.Size(200, 32);
            this.오캐이캐시백.TabIndex = 5;
            this.오캐이캐시백.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.오캐이캐시백.TextChanged += new System.EventHandler(this.오캐이캐시백_TextChanged);
            // 
            // 단순결제요청
            // 
            this.단순결제요청.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.단순결제요청.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.단순결제요청.ForeColor = System.Drawing.Color.White;
            this.단순결제요청.Location = new System.Drawing.Point(466, 92);
            this.단순결제요청.Name = "단순결제요청";
            this.단순결제요청.Size = new System.Drawing.Size(127, 124);
            this.단순결제요청.TabIndex = 6;
            this.단순결제요청.Text = "단순결제요청";
            this.단순결제요청.UseVisualStyleBackColor = false;
            this.단순결제요청.Click += new System.EventHandler(this.단순결제요청_Click);
            // 
            // 승인요청
            // 
            this.승인요청.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.승인요청.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.승인요청.ForeColor = System.Drawing.Color.White;
            this.승인요청.Location = new System.Drawing.Point(516, 532);
            this.승인요청.Name = "승인요청";
            this.승인요청.Size = new System.Drawing.Size(95, 133);
            this.승인요청.TabIndex = 7;
            this.승인요청.Text = "승인요청";
            this.승인요청.UseVisualStyleBackColor = false;
            this.승인요청.Click += new System.EventHandler(this.승인요청_Click);
            // 
            // 승인요쳥시간
            // 
            this.승인요쳥시간.Enabled = true;
            this.승인요쳥시간.Interval = 4000;
            this.승인요쳥시간.Tick += new System.EventHandler(this.승인요쳥시간_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_201504040_조권식_기말프로젝트.Properties.Resources.현금결제;
            this.pictureBox1.Location = new System.Drawing.Point(1, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 786);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // 현금
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 780);
            this.Controls.Add(this.승인요청);
            this.Controls.Add(this.단순결제요청);
            this.Controls.Add(this.오캐이캐시백);
            this.Controls.Add(this.현금영수중);
            this.Controls.Add(this.받은금액);
            this.Controls.Add(this.거스름돈);
            this.Controls.Add(this.받을금액);
            this.Controls.Add(this.pictureBox1);
            this.Name = "현금";
            this.Text = "현금";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label 받을금액;
        private System.Windows.Forms.Label 거스름돈;
        private System.Windows.Forms.TextBox 받은금액;
        private System.Windows.Forms.TextBox 현금영수중;
        private System.Windows.Forms.TextBox 오캐이캐시백;
        private System.Windows.Forms.Button 단순결제요청;
        private System.Windows.Forms.Button 승인요청;
        private System.Windows.Forms.Timer 승인요쳥시간;
    }
}