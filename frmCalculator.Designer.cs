namespace Calculator___lv_Medium
{
    partial class frmCalculator
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
            txtPhepTinh = new TextBox();
            lblKQ = new Label();
            btnNgoacTrai = new Button();
            btnNgoacPhai = new Button();
            btnInvX = new Button();
            btnSqrX = new Button();
            btnSqrtX = new Button();
            btnAC = new Button();
            btnDEL = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnChia = new Button();
            btnNhan = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnTru = new Button();
            btnCong = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnSolve = new Button();
            btnANS = new Button();
            btnPi = new Button();
            btnDecimal = new Button();
            btn0 = new Button();
            btnRight = new Button();
            btnLeft = new Button();
            btnPow = new Button();
            btnC = new Button();
            btnB = new Button();
            btnA = new Button();
            btnSTO = new Button();
            lblTenSP = new Label();
            SuspendLayout();
            // 
            // txtPhepTinh
            // 
            txtPhepTinh.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhepTinh.Location = new Point(23, 88);
            txtPhepTinh.Multiline = true;
            txtPhepTinh.Name = "txtPhepTinh";
            txtPhepTinh.ScrollBars = ScrollBars.Horizontal;
            txtPhepTinh.Size = new Size(577, 245);
            txtPhepTinh.TabIndex = 0;
            txtPhepTinh.WordWrap = false;
            txtPhepTinh.KeyPress += txtPhepTinh_KeyPress;
            // 
            // lblKQ
            // 
            lblKQ.BackColor = SystemColors.Window;
            lblKQ.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKQ.Location = new Point(34, 228);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(553, 70);
            lblKQ.TabIndex = 1;
            lblKQ.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnNgoacTrai
            // 
            btnNgoacTrai.BackColor = Color.Black;
            btnNgoacTrai.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNgoacTrai.ForeColor = SystemColors.ControlLightLight;
            btnNgoacTrai.Location = new Point(23, 563);
            btnNgoacTrai.Name = "btnNgoacTrai";
            btnNgoacTrai.Size = new Size(110, 90);
            btnNgoacTrai.TabIndex = 2;
            btnNgoacTrai.Text = "(";
            btnNgoacTrai.UseVisualStyleBackColor = false;
            // 
            // btnNgoacPhai
            // 
            btnNgoacPhai.BackColor = Color.Black;
            btnNgoacPhai.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNgoacPhai.ForeColor = SystemColors.ControlLightLight;
            btnNgoacPhai.Location = new Point(139, 563);
            btnNgoacPhai.Name = "btnNgoacPhai";
            btnNgoacPhai.Size = new Size(110, 90);
            btnNgoacPhai.TabIndex = 3;
            btnNgoacPhai.Text = ")";
            btnNgoacPhai.UseVisualStyleBackColor = false;
            // 
            // btnInvX
            // 
            btnInvX.BackColor = Color.Black;
            btnInvX.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInvX.ForeColor = SystemColors.ControlLightLight;
            btnInvX.Location = new Point(255, 563);
            btnInvX.Name = "btnInvX";
            btnInvX.Size = new Size(110, 90);
            btnInvX.TabIndex = 4;
            btnInvX.Text = "1/x";
            btnInvX.UseVisualStyleBackColor = false;
            btnInvX.Click += btnInvX_Click;
            // 
            // btnSqrX
            // 
            btnSqrX.BackColor = Color.Black;
            btnSqrX.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSqrX.ForeColor = SystemColors.ControlLightLight;
            btnSqrX.Location = new Point(370, 563);
            btnSqrX.Name = "btnSqrX";
            btnSqrX.Size = new Size(110, 90);
            btnSqrX.TabIndex = 5;
            btnSqrX.Text = "x^2";
            btnSqrX.UseVisualStyleBackColor = false;
            btnSqrX.Click += btnSqrX_Click;
            // 
            // btnSqrtX
            // 
            btnSqrtX.BackColor = Color.Black;
            btnSqrtX.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSqrtX.ForeColor = SystemColors.ControlLightLight;
            btnSqrtX.Location = new Point(486, 563);
            btnSqrtX.Name = "btnSqrtX";
            btnSqrtX.Size = new Size(110, 90);
            btnSqrtX.TabIndex = 6;
            btnSqrtX.Text = "√x";
            btnSqrtX.UseVisualStyleBackColor = false;
            btnSqrtX.Click += btnSqrtX_Click;
            // 
            // btnAC
            // 
            btnAC.BackColor = Color.FromArgb(67, 121, 242);
            btnAC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAC.ForeColor = SystemColors.ControlLightLight;
            btnAC.Location = new Point(486, 659);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(110, 90);
            btnAC.TabIndex = 11;
            btnAC.Text = "AC";
            btnAC.UseVisualStyleBackColor = false;
            btnAC.Click += button6_Click;
            // 
            // btnDEL
            // 
            btnDEL.BackColor = Color.FromArgb(67, 121, 242);
            btnDEL.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDEL.ForeColor = SystemColors.ControlLightLight;
            btnDEL.Location = new Point(370, 659);
            btnDEL.Name = "btnDEL";
            btnDEL.Size = new Size(110, 90);
            btnDEL.TabIndex = 10;
            btnDEL.Text = "DEL";
            btnDEL.UseVisualStyleBackColor = false;
            btnDEL.Click += btnDEL_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn9.Location = new Point(255, 659);
            btn9.Name = "btn9";
            btn9.Size = new Size(110, 90);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn8.Location = new Point(139, 659);
            btn8.Name = "btn8";
            btn8.Size = new Size(110, 90);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn7.Location = new Point(23, 659);
            btn7.Name = "btn7";
            btn7.Size = new Size(110, 90);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            btnChia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnChia.Location = new Point(486, 755);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(110, 90);
            btnChia.TabIndex = 16;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // btnNhan
            // 
            btnNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNhan.Location = new Point(370, 755);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(110, 90);
            btnNhan.TabIndex = 15;
            btnNhan.Text = "x";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn6.Location = new Point(255, 755);
            btn6.Name = "btn6";
            btn6.Size = new Size(110, 90);
            btn6.TabIndex = 14;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn5.Location = new Point(139, 755);
            btn5.Name = "btn5";
            btn5.Size = new Size(110, 90);
            btn5.TabIndex = 13;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn4.Location = new Point(23, 755);
            btn4.Name = "btn4";
            btn4.Size = new Size(110, 90);
            btn4.TabIndex = 12;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btnTru
            // 
            btnTru.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTru.Location = new Point(486, 851);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(110, 90);
            btnTru.TabIndex = 21;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnCong
            // 
            btnCong.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCong.Location = new Point(370, 851);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(110, 90);
            btnCong.TabIndex = 20;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn3.Location = new Point(255, 851);
            btn3.Name = "btn3";
            btn3.Size = new Size(110, 90);
            btn3.TabIndex = 19;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn2.Location = new Point(139, 851);
            btn2.Name = "btn2";
            btn2.Size = new Size(110, 90);
            btn2.TabIndex = 18;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn1.Location = new Point(23, 851);
            btn1.Name = "btn1";
            btn1.Size = new Size(110, 90);
            btn1.TabIndex = 17;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btnSolve
            // 
            btnSolve.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSolve.Location = new Point(486, 947);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(110, 90);
            btnSolve.TabIndex = 26;
            btnSolve.Text = "=";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += btnSolve_Click;
            // 
            // btnANS
            // 
            btnANS.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnANS.Location = new Point(370, 947);
            btnANS.Name = "btnANS";
            btnANS.Size = new Size(110, 90);
            btnANS.TabIndex = 25;
            btnANS.Text = "ANS";
            btnANS.UseVisualStyleBackColor = true;
            // 
            // btnPi
            // 
            btnPi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPi.Location = new Point(255, 947);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(110, 90);
            btnPi.TabIndex = 24;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = true;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDecimal.Location = new Point(139, 947);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(110, 90);
            btnDecimal.TabIndex = 23;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn0.Location = new Point(23, 947);
            btn0.Name = "btn0";
            btn0.Size = new Size(110, 90);
            btn0.TabIndex = 22;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            btnRight.BackColor = Color.FromArgb(67, 121, 242);
            btnRight.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Bold);
            btnRight.ForeColor = SystemColors.ControlLightLight;
            btnRight.Location = new Point(332, 364);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(113, 74);
            btnRight.TabIndex = 29;
            btnRight.Text = ">";
            btnRight.UseVisualStyleBackColor = false;
            btnRight.Click += btnRight_Click;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = Color.FromArgb(67, 121, 242);
            btnLeft.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Bold);
            btnLeft.ForeColor = SystemColors.ControlLightLight;
            btnLeft.Location = new Point(179, 364);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(113, 74);
            btnLeft.TabIndex = 30;
            btnLeft.Text = "<";
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.Black;
            btnPow.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPow.ForeColor = SystemColors.ControlLightLight;
            btnPow.Location = new Point(486, 467);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(110, 90);
            btnPow.TabIndex = 35;
            btnPow.Text = "x^n";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Black;
            btnC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnC.ForeColor = SystemColors.ControlLightLight;
            btnC.Location = new Point(370, 467);
            btnC.Name = "btnC";
            btnC.Size = new Size(110, 90);
            btnC.TabIndex = 34;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnB
            // 
            btnB.BackColor = Color.Black;
            btnB.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnB.ForeColor = SystemColors.ControlLightLight;
            btnB.Location = new Point(255, 467);
            btnB.Name = "btnB";
            btnB.Size = new Size(110, 90);
            btnB.TabIndex = 33;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnB_Click;
            // 
            // btnA
            // 
            btnA.BackColor = Color.Black;
            btnA.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnA.ForeColor = SystemColors.ControlLightLight;
            btnA.Location = new Point(139, 467);
            btnA.Name = "btnA";
            btnA.Size = new Size(110, 90);
            btnA.TabIndex = 32;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnA_Click;
            // 
            // btnSTO
            // 
            btnSTO.BackColor = Color.Black;
            btnSTO.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSTO.ForeColor = SystemColors.ControlLightLight;
            btnSTO.Location = new Point(23, 467);
            btnSTO.Name = "btnSTO";
            btnSTO.Size = new Size(110, 90);
            btnSTO.TabIndex = 31;
            btnSTO.Text = "STO";
            btnSTO.UseVisualStyleBackColor = false;
            btnSTO.Click += btnSTO_Click;
            btnSTO.MouseDown += btnSTO_MouseDown;
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenSP.ForeColor = Color.FromArgb(67, 121, 242);
            lblTenSP.Location = new Point(148, 5);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(331, 65);
            lblTenSP.TabIndex = 36;
            lblTenSP.Text = "CALCULATOR";
            // 
            // frmCalculator
            // 
            AcceptButton = btnSolve;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 244, 249);
            ClientSize = new Size(624, 1071);
            Controls.Add(lblTenSP);
            Controls.Add(btnPow);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(btnSTO);
            Controls.Add(btnLeft);
            Controls.Add(btnRight);
            Controls.Add(btnSolve);
            Controls.Add(btnANS);
            Controls.Add(btnPi);
            Controls.Add(btnDecimal);
            Controls.Add(btn0);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnAC);
            Controls.Add(btnDEL);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnSqrtX);
            Controls.Add(btnSqrX);
            Controls.Add(btnInvX);
            Controls.Add(btnNgoacPhai);
            Controls.Add(btnNgoacTrai);
            Controls.Add(lblKQ);
            Controls.Add(txtPhepTinh);
            Name = "frmCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MANHTOAN";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhepTinh;
        private Label lblKQ;
        private Button btnNgoacTrai;
        private Button btnNgoacPhai;
        private Button btnInvX;
        private Button btnSqrX;
        private Button btnSqrtX;
        private Button btnAC;
        private Button btnDEL;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnChia;
        private Button btnNhan;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnTru;
        private Button btnCong;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnSolve;
        private Button btnANS;
        private Button btnPi;
        private Button btnDecimal;
        private Button btn0;
        private Button btnRight;
        private Button btnLeft;
        private Button btnPow;
        private Button btnC;
        private Button btnB;
        private Button btnA;
        private Button btnSTO;
        private Label lblTenSP;
    }
}
