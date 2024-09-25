namespace PTBac2
{
    partial class frmPTBac2
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
            groupBox1 = new GroupBox();
            tb3 = new TextBox();
            tb2 = new TextBox();
            tb1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbGiai = new Button();
            tbQuayLai = new Button();
            tbThoat = new Button();
            label4 = new Label();
            tbKQua = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGreen;
            groupBox1.Controls.Add(tb3);
            groupBox1.Controls.Add(tb2);
            groupBox1.Controls.Add(tb1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            groupBox1.Location = new Point(36, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 244);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập dữ liệu";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tb3
            // 
            tb3.Location = new Point(130, 187);
            tb3.Name = "tb3";
            tb3.Size = new Size(325, 41);
            tb3.TabIndex = 5;
            // 
            // tb2
            // 
            tb2.Location = new Point(130, 110);
            tb2.Name = "tb2";
            tb2.Size = new Size(325, 41);
            tb2.TabIndex = 4;
            // 
            // tb1
            // 
            tb1.Location = new Point(130, 41);
            tb1.Name = "tb1";
            tb1.Size = new Size(325, 41);
            tb1.TabIndex = 3;
            tb1.TextChanged += tb1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 187);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Nhập c :";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 114);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập b :";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 44);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập a :";
            label1.Click += label1_Click;
            // 
            // tbGiai
            // 
            tbGiai.AccessibleDescription = "";
            tbGiai.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tbGiai.ImageAlign = ContentAlignment.TopRight;
            tbGiai.Location = new Point(627, 122);
            tbGiai.Name = "tbGiai";
            tbGiai.Size = new Size(171, 58);
            tbGiai.TabIndex = 1;
            tbGiai.Text = "Giải";
            tbGiai.UseVisualStyleBackColor = true;
            tbGiai.Click += button1_Click;
            // 
            // tbQuayLai
            // 
            tbQuayLai.Location = new Point(727, 199);
            tbQuayLai.Name = "tbQuayLai";
            tbQuayLai.Size = new Size(94, 29);
            tbQuayLai.TabIndex = 2;
            tbQuayLai.Text = "Quay lại";
            tbQuayLai.UseVisualStyleBackColor = true;
            tbQuayLai.Click += tbQuayLai_Click;
            // 
            // tbThoat
            // 
            tbThoat.Location = new Point(605, 199);
            tbThoat.Name = "tbThoat";
            tbThoat.Size = new Size(94, 29);
            tbThoat.TabIndex = 3;
            tbThoat.Text = "Thoát";
            tbThoat.UseVisualStyleBackColor = true;
            tbThoat.Click += tbThoat_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(36, 324);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 6;
            label4.Text = "Kết quả";
            // 
            // tbKQua
            // 
            tbKQua.Location = new Point(36, 355);
            tbKQua.Multiline = true;
            tbKQua.Name = "tbKQua";
            tbKQua.Size = new Size(784, 61);
            tbKQua.TabIndex = 7;
            // 
            // frmPTBac2
            // 
            AcceptButton = tbGiai;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(891, 444);
            Controls.Add(tbKQua);
            Controls.Add(label4);
            Controls.Add(tbThoat);
            Controls.Add(tbQuayLai);
            Controls.Add(tbGiai);
            Controls.Add(groupBox1);
            Name = "frmPTBac2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giải Phương Trình Bậc 2 Cùng Hòa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tb3;
        private TextBox tb2;
        private TextBox tb1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button tbGiai;
        private Button tbQuayLai;
        private Button tbThoat;
        private Label label4;
        private TextBox tbKQua;
    }
}
