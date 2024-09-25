namespace TachHoTen
{
    partial class frmTachHoTen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTachHoTen));
            gbTach = new GroupBox();
            btnClear = new Button();
            txtTen = new TextBox();
            txtDem = new TextBox();
            txtHo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnTach = new Button();
            txtFullName = new TextBox();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            gbTach.SuspendLayout();
            SuspendLayout();
            // 
            // gbTach
            // 
            gbTach.BackColor = SystemColors.ActiveCaption;
            gbTach.Controls.Add(btnClear);
            gbTach.Controls.Add(txtTen);
            gbTach.Controls.Add(txtDem);
            gbTach.Controls.Add(txtHo);
            gbTach.Controls.Add(label5);
            gbTach.Controls.Add(label4);
            gbTach.Controls.Add(label3);
            gbTach.Controls.Add(btnTach);
            gbTach.Controls.Add(txtFullName);
            gbTach.Controls.Add(label2);
            gbTach.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbTach.ForeColor = Color.Red;
            gbTach.Location = new Point(59, 85);
            gbTach.Name = "gbTach";
            gbTach.Size = new Size(664, 283);
            gbTach.TabIndex = 0;
            gbTach.TabStop = false;
            gbTach.Text = "TÁCH THÀNH HỌ, ĐỆM VÀ TÊN";
            // 
            // btnClear
            // 
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.Location = new Point(591, 250);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(67, 27);
            btnClear.TabIndex = 9;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button1_Click;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.WhiteSmoke;
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.Location = new Point(275, 222);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(144, 31);
            txtTen.TabIndex = 8;
            // 
            // txtDem
            // 
            txtDem.BackColor = Color.WhiteSmoke;
            txtDem.BorderStyle = BorderStyle.FixedSingle;
            txtDem.Location = new Point(275, 180);
            txtDem.Name = "txtDem";
            txtDem.Size = new Size(144, 31);
            txtDem.TabIndex = 7;
            // 
            // txtHo
            // 
            txtHo.BackColor = Color.WhiteSmoke;
            txtHo.BorderStyle = BorderStyle.FixedSingle;
            txtHo.Location = new Point(275, 141);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(144, 31);
            txtHo.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(220, 222);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 5;
            label5.Text = "Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(216, 180);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 4;
            label4.Text = "Đệm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(222, 143);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 3;
            label3.Text = "Họ";
            label3.Click += label3_Click;
            // 
            // btnTach
            // 
            btnTach.BackColor = Color.Gainsboro;
            btnTach.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTach.ForeColor = SystemColors.ActiveCaptionText;
            btnTach.Location = new Point(304, 95);
            btnTach.Name = "btnTach";
            btnTach.Size = new Size(91, 30);
            btnTach.TabIndex = 2;
            btnTach.Text = "TÁCH";
            btnTach.UseVisualStyleBackColor = false;
            btnTach.Click += btnTach_Click;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(275, 54);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(290, 31);
            txtFullName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(38, 56);
            label2.Name = "label2";
            label2.Size = new Size(220, 20);
            label2.TabIndex = 0;
            label2.Text = "Nhập họ và tên đầy đủ tại đây:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // frmTachHoTen
            // 
            AcceptButton = btnTach;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(gbTach);
            Name = "frmTachHoTen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TachHoTen";
            gbTach.ResumeLayout(false);
            gbTach.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTach;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnTach;
        private TextBox txtFullName;
        private TextBox txtTen;
        private TextBox txtDem;
        private TextBox txtHo;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnClear;
    }
}
