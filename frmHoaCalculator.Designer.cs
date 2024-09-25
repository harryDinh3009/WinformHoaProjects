namespace Calculator19
{
    partial class frmHoaCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNgoacTrai = new Button();
            btnNgoacPhai = new Button();
            btnAC = new Button();
            btnChia = new Button();
            btnNhan = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnTru = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnCong = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnSolve = new Button();
            btnDecimal = new Button();
            btn0 = new Button();
            btnDoiDau = new Button();
            txtPhepTinh = new TextBox();
            lblKQ = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // btnNgoacTrai
            // 
            btnNgoacTrai.BackColor = Color.LightGray;
            btnNgoacTrai.Location = new Point(28, 186);
            btnNgoacTrai.Name = "btnNgoacTrai";
            btnNgoacTrai.Size = new Size(89, 39);
            btnNgoacTrai.TabIndex = 0;
            btnNgoacTrai.Text = "(";
            btnNgoacTrai.UseVisualStyleBackColor = false;
            // 
            // btnNgoacPhai
            // 
            btnNgoacPhai.BackColor = Color.LightGray;
            btnNgoacPhai.Location = new Point(117, 186);
            btnNgoacPhai.Name = "btnNgoacPhai";
            btnNgoacPhai.Size = new Size(89, 39);
            btnNgoacPhai.TabIndex = 1;
            btnNgoacPhai.Text = ")";
            btnNgoacPhai.UseVisualStyleBackColor = false;
            // 
            // btnAC
            // 
            btnAC.BackColor = Color.LightGray;
            btnAC.Location = new Point(206, 186);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(89, 39);
            btnAC.TabIndex = 2;
            btnAC.Text = "AC";
            btnAC.UseVisualStyleBackColor = false;
            btnAC.Click += btnAC_Click;
            // 
            // btnChia
            // 
            btnChia.BackColor = Color.LightGray;
            btnChia.Location = new Point(295, 186);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(89, 39);
            btnChia.TabIndex = 3;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = false;
            // 
            // btnNhan
            // 
            btnNhan.BackColor = Color.LightGray;
            btnNhan.Location = new Point(295, 225);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(89, 39);
            btnNhan.TabIndex = 7;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.Location = new Point(206, 225);
            btn9.Name = "btn9";
            btn9.Size = new Size(89, 39);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(117, 225);
            btn8.Name = "btn8";
            btn8.Size = new Size(89, 39);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(28, 225);
            btn7.Name = "btn7";
            btn7.Size = new Size(89, 39);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btnTru
            // 
            btnTru.BackColor = Color.LightGray;
            btnTru.Location = new Point(295, 264);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(89, 39);
            btnTru.TabIndex = 11;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.Location = new Point(206, 264);
            btn6.Name = "btn6";
            btn6.Size = new Size(89, 39);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(117, 264);
            btn5.Name = "btn5";
            btn5.Size = new Size(89, 39);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(28, 264);
            btn4.Name = "btn4";
            btn4.Size = new Size(89, 39);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btnCong
            // 
            btnCong.BackColor = Color.LightGray;
            btnCong.Location = new Point(295, 303);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(89, 39);
            btnCong.TabIndex = 15;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.Location = new Point(206, 303);
            btn3.Name = "btn3";
            btn3.Size = new Size(89, 39);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(117, 303);
            btn2.Name = "btn2";
            btn2.Size = new Size(89, 39);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(28, 303);
            btn1.Name = "btn1";
            btn1.Size = new Size(89, 39);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btnSolve
            // 
            btnSolve.BackColor = SystemColors.Highlight;
            btnSolve.Location = new Point(295, 342);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(89, 39);
            btnSolve.TabIndex = 19;
            btnSolve.Text = "=";
            btnSolve.UseVisualStyleBackColor = false;
            btnSolve.Click += btnSolve_Click;
            btnSolve.MouseLeave += btnSolve_MouseLeave;
            btnSolve.MouseHover += btnSolve_MouseHover;
            // 
            // btnDecimal
            // 
            btnDecimal.Location = new Point(206, 342);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(89, 39);
            btnDecimal.TabIndex = 18;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(117, 342);
            btn0.Name = "btn0";
            btn0.Size = new Size(89, 39);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnDoiDau
            // 
            btnDoiDau.Location = new Point(28, 342);
            btnDoiDau.Name = "btnDoiDau";
            btnDoiDau.Size = new Size(89, 39);
            btnDoiDau.TabIndex = 16;
            btnDoiDau.Text = "+/-";
            btnDoiDau.UseVisualStyleBackColor = true;
            btnDoiDau.Click += btnDoiDau_Click;
            // 
            // txtPhepTinh
            // 
            txtPhepTinh.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            txtPhepTinh.Location = new Point(26, 12);
            txtPhepTinh.Multiline = true;
            txtPhepTinh.Name = "txtPhepTinh";
            txtPhepTinh.ScrollBars = ScrollBars.Horizontal;
            txtPhepTinh.Size = new Size(356, 157);
            txtPhepTinh.TabIndex = 20;
            txtPhepTinh.WordWrap = false;
            txtPhepTinh.KeyPress += txtPhepTinh_KeyPress;
            // 
            // lblKQ
            // 
            lblKQ.BackColor = SystemColors.ControlLightLight;
            lblKQ.Font = new Font("Segoe UI", 20F);
            lblKQ.Location = new Point(26, 81);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(341, 53);
            lblKQ.TabIndex = 21;
            lblKQ.TextAlign = ContentAlignment.BottomRight;
            // 
            // frmHoaCalculator
            // 
            AcceptButton = btnSolve;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 403);
            Controls.Add(lblKQ);
            Controls.Add(txtPhepTinh);
            Controls.Add(btnSolve);
            Controls.Add(btnDecimal);
            Controls.Add(btn0);
            Controls.Add(btnDoiDau);
            Controls.Add(btnCong);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnTru);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnNhan);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnChia);
            Controls.Add(btnAC);
            Controls.Add(btnNgoacPhai);
            Controls.Add(btnNgoacTrai);
            Name = "frmHoaCalculator";
            Text = "Hoa Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNgoacTrai;
        private Button btnNgoacPhai;
        private Button btnAC;
        private Button btnChia;
        private Button btnNhan;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnTru;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnCong;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnSolve;
        private Button btnDecimal;
        private Button btn0;
        private Button btnDoiDau;
        private TextBox txtPhepTinh;
        private Label lblKQ;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
