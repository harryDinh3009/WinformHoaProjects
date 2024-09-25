namespace PTBac2
{
    public partial class frmPTBac2 : Form
    {
        public frmPTBac2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu đầu vào
            if (!int.TryParse(tb1.Text, out int a) || !int.TryParse(tb2.Text, out int b) || !int.TryParse(tb3.Text, out int c))
            {
                tbKQua.Text = "Vui lòng nhập số hợp lệ.";
                return;
            }
            // Tính delta
            double denta = 0;
            denta = b * b - 4 * a * c;

            // Xử lý phương trình bậc nhất khi a = 0
            if (a == 0)
            {
                if (b == 0)
                {
                    tbKQua.Text = c == 0 ? "Phương trình vô số nghiệm" : "Phương trình vô nghiệm";
                }
                else
                {
                    double rs = (-c / (double)b);
                    if (rs == 0)
                    { rs = 0; }
                    tbKQua.Text = "Phương trình có nghiệm duy nhất: x = " + rs;
                }
            }
            else
            { // Kiểm tra các trường hợp của delta
                if (denta < 0)
                {
                    tbKQua.Text = "Phương trình vô nghiệm";
                }
                else if (denta == 0)
                {
                    tbKQua.Text = "Phương trình có nghiệm kép là: " + (-b / (2 * a));
                }
                else
                {
                    tbKQua.Text = "Phương trình có 2 nghiệm phân biệt là: x1 = "
                                  + (-b + Math.Sqrt(denta)) / (2 * a)
                                  + " và x2 = "
                                  + (-b - Math.Sqrt(denta)) / (2 * a);
                }
            }
        }

        private void tbThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát ra không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tbQuayLai_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tbKQua.Text = "";
            tb1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
