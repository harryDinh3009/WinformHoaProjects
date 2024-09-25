namespace Calculator___lv_Medium
{
    partial class frmTongHop
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
            menuStrip1 = new MenuStrip();
            mnuTongHop = new ToolStripMenuItem();
            mnuTongHop_HoaCalculator = new ToolStripMenuItem();
            mnuTongHop_PTB2 = new ToolStripMenuItem();
            mnuTongHop_TachHoTen = new ToolStripMenuItem();
            mnuTongHop_Calculator = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuTongHop });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(795, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuTongHop
            // 
            mnuTongHop.DropDownItems.AddRange(new ToolStripItem[] { mnuTongHop_HoaCalculator, mnuTongHop_PTB2, mnuTongHop_TachHoTen, mnuTongHop_Calculator });
            mnuTongHop.Name = "mnuTongHop";
            mnuTongHop.Size = new Size(87, 24);
            mnuTongHop.Text = "Tổng hợp";
            // 
            // mnuTongHop_HoaCalculator
            // 
            mnuTongHop_HoaCalculator.Name = "mnuTongHop_HoaCalculator";
            mnuTongHop_HoaCalculator.ShortcutKeys = Keys.Control | Keys.D1;
            mnuTongHop_HoaCalculator.Size = new Size(267, 26);
            mnuTongHop_HoaCalculator.Text = "HoaCalculator";
            mnuTongHop_HoaCalculator.Click += mnuTongHop_Calculator_Click;
            // 
            // mnuTongHop_PTB2
            // 
            mnuTongHop_PTB2.Name = "mnuTongHop_PTB2";
            mnuTongHop_PTB2.ShortcutKeys = Keys.Control | Keys.D2;
            mnuTongHop_PTB2.Size = new Size(267, 26);
            mnuTongHop_PTB2.Text = "Phương trình bậc 2";
            mnuTongHop_PTB2.Click += mnuTongHop_PTB2_Click;
            // 
            // mnuTongHop_TachHoTen
            // 
            mnuTongHop_TachHoTen.Name = "mnuTongHop_TachHoTen";
            mnuTongHop_TachHoTen.ShortcutKeys = Keys.Control | Keys.D3;
            mnuTongHop_TachHoTen.Size = new Size(267, 26);
            mnuTongHop_TachHoTen.Text = "Tách họ tên";
            mnuTongHop_TachHoTen.Click += mnuTongHop_TachHoTen_Click;
            // 
            // mnuTongHop_Calculator
            // 
            mnuTongHop_Calculator.Name = "mnuTongHop_Calculator";
            mnuTongHop_Calculator.ShortcutKeys = Keys.Control | Keys.D4;
            mnuTongHop_Calculator.Size = new Size(267, 26);
            mnuTongHop_Calculator.Text = "Calculator";
            mnuTongHop_Calculator.Click += mnuTongHop_Calculator_Click_1;
            // 
            // frmTongHop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 459);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmTongHop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TongHopcs";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuTongHop;
        private ToolStripMenuItem mnuTongHop_HoaCalculator;
        private ToolStripMenuItem mnuTongHop_PTB2;
        private ToolStripMenuItem mnuTongHop_TachHoTen;
        private ToolStripMenuItem mnuTongHop_Calculator;
    }
}