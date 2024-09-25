using System.Data;
using System.Text.RegularExpressions;
using NCalc;
namespace Calculator___lv_Medium
{
    public partial class frmCalculator : Form
    {
        double A = 0;
        double B = 0;
        double C = 0;
        double ANS = 0;
        bool isStoring = false;
        public frmCalculator()
        {
            InitializeComponent();
        }
        private void AppendToExpression(string value)
        {
            if (lblKQ.Text == "")
            {
                int curPosition = txtPhepTinh.SelectionStart;
                txtPhepTinh.Text = txtPhepTinh.Text.Insert(curPosition, value);
                txtPhepTinh.SelectionStart = curPosition + value.Length;
            }
            else
            {
                txtPhepTinh.Text = "ANS";
                txtPhepTinh.Text = txtPhepTinh.Text.Insert(3, value);
                txtPhepTinh.SelectionStart = 3 + value.Length;
            }
            txtPhepTinh.Focus();
            lblKQ.Text = "";
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                if ((btn == btnA || btn == btnB || btn == btnC) && isStoring)
                {
                    // Không làm gì khi isStoring là true và nút nhấn là A, B, hoặc C
                    return;
                }
                int curPositon = txtPhepTinh.SelectionStart;

                if (lblKQ.Text != "")
                {
                    lblKQ.Text = "";
                    txtPhepTinh.Text = btn.Text;
                    txtPhepTinh.SelectionStart = btn.Text.Length;
                }
                else
                {
                    txtPhepTinh.Text = txtPhepTinh.Text.Insert(curPositon, btn.Text);
                    txtPhepTinh.SelectionStart = curPositon + btn.Text.Length;
                }
                txtPhepTinh.Focus();
            }
        }
        private string ReplaceExponentiation(string expression)
        {
            return Regex.Replace(expression, @"(\d+(\.\d+)?|\d+/\d+)\^(\((\d+/\d+|\d+(\.\d+)?)\)|\d+(\.\d+)?)", match =>
            {
                string baseNumber = match.Groups[1].Value;   // Cơ số
                string exponent = match.Groups[3].Value;    // Số mũ, bao gồm cả phân số trong dấu ngoặc
                return $"Pow({baseNumber}, {exponent})";    // Thay thế thành Pow(base, exponent)
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn0.Click += new EventHandler(Button_Click);
            btn1.Click += new EventHandler(Button_Click);
            btn2.Click += new EventHandler(Button_Click);
            btn3.Click += new EventHandler(Button_Click);
            btn4.Click += new EventHandler(Button_Click);
            btn5.Click += new EventHandler(Button_Click);
            btn6.Click += new EventHandler(Button_Click);
            btn7.Click += new EventHandler(Button_Click);
            btn8.Click += new EventHandler(Button_Click);
            btn9.Click += new EventHandler(Button_Click);
            btnDecimal.Click += new EventHandler(Button_Click);
            btnNgoacPhai.Click += new EventHandler(Button_Click);
            btnNgoacTrai.Click += new EventHandler(Button_Click);
            btnPi.Click += new EventHandler(Button_Click);
            btnANS.Click += new EventHandler(Button_Click);
        }

        private void txtPhepTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '+') && (e.KeyChar != '-') &&
                (e.KeyChar != '*') && (e.KeyChar != '/') &&
                (e.KeyChar != '(') && (e.KeyChar != ')') &&
                (e.KeyChar != '.') && (e.KeyChar != ' ') &&
                (e.KeyChar != '^') && (e.KeyChar != 'A') &&
                (e.KeyChar != 'B') && (e.KeyChar != 'C'))
            {
                e.Handled = true;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (txtPhepTinh.SelectionStart > 0)
            {
                txtPhepTinh.SelectionStart -= 1;
            }
            lblKQ.Text = "";
            txtPhepTinh.Focus();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (txtPhepTinh.SelectionStart == txtPhepTinh.Text.Length)
            {
                txtPhepTinh.SelectionStart = 0;
            }
            else if (txtPhepTinh.SelectionStart < txtPhepTinh.Text.Length)
            {
                txtPhepTinh.SelectionStart += 1;
            }
            lblKQ.Text = "";
            txtPhepTinh.Focus();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            AppendToExpression("+");
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            AppendToExpression("-");
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            AppendToExpression("*");
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            AppendToExpression("/");
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                // Gọi hàm xử lý và cập nhật giá trị ANS và kết quả
                ANS = Solve(txtPhepTinh.Text);
                lblKQ.Text = ANS.ToString();
                txtPhepTinh.SelectionStart = txtPhepTinh.TextLength;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double Solve(string expression)
        {
            try
            {
                // Thay thế các ký hiệu đặc biệt trong biểu thức
                expression = expression.Replace("π", Math.Round(Math.PI, 5).ToString());
                expression = expression.Replace("ANS", ANS.ToString());
                expression = expression.Replace("A", A.ToString());
                expression = expression.Replace("B", B.ToString());
                expression = expression.Replace("C", C.ToString());
                expression = ReplaceExponentiation(expression);

                Expression exp = new Expression(expression);
                var result = exp.Evaluate();
                return Convert.ToDouble(result);
            }
            catch
            {
                throw;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtPhepTinh.Text = "";
            lblKQ.Text = "";
            txtPhepTinh.Focus();
        }

        private void btnInvX_Click(object sender, EventArgs e)
        {
            AppendToExpression("1/");
        }

        private void btnSqrX_Click(object sender, EventArgs e)
        {
            AppendToExpression("^2");
        }

        private void btnSqrtX_Click(object sender, EventArgs e)
        {
            AppendToExpression("^(1/2)");
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            AppendToExpression("^");
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            int curPosition = txtPhepTinh.SelectionStart;
            if (curPosition > 0)
            {
                if (curPosition >= 3 && txtPhepTinh.Text.Substring(curPosition - 3, 3) == "ANS")
                {
                    txtPhepTinh.Text = txtPhepTinh.Text.Remove(curPosition - 3, 3);
                    txtPhepTinh.SelectionStart = curPosition - 3;
                }
                else if (curPosition >= 2 && txtPhepTinh.Text.Substring(curPosition - 2, 2) == "1/")
                {
                    txtPhepTinh.Text = txtPhepTinh.Text.Remove(curPosition - 2, 2);
                    txtPhepTinh.SelectionStart = curPosition - 2;
                }
                else if (curPosition >= 2 && txtPhepTinh.Text.Substring(curPosition - 2, 2) == "^2")
                {
                    txtPhepTinh.Text = txtPhepTinh.Text.Remove(curPosition - 2, 2);
                    txtPhepTinh.SelectionStart = curPosition - 2;
                }
                else if (curPosition >= 6 && txtPhepTinh.Text.Substring(curPosition - 6, 6) == "^(1/2)")
                {
                    txtPhepTinh.Text = txtPhepTinh.Text.Remove(curPosition - 6, 6);
                    txtPhepTinh.SelectionStart = curPosition - 6;
                }
                else
                {
                    txtPhepTinh.Text = txtPhepTinh.Text.Remove(curPosition - 1, 1);
                    txtPhepTinh.SelectionStart = curPosition - 1;
                }
            }
            txtPhepTinh.Focus();
            lblKQ.Text = "";
        }

        private void btnSTO_Click(object sender, EventArgs e)
        {
            isStoring = true;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (isStoring)
            {
                A = Solve(txtPhepTinh.Text);
                isStoring = false;
                MessageBox.Show("Đã lưu vào A");
            }
            else
            {
                Button_Click(sender, e);
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (isStoring)
            {
                B = Solve(txtPhepTinh.Text);
                isStoring = false;
                MessageBox.Show("Đã lưu vào B");
            }
            else
            {
                Button_Click(sender, e);
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (isStoring)
            {
                C = Solve(txtPhepTinh.Text);
                isStoring = false;
                MessageBox.Show("Đã lưu vào C");
            }
            else
            {
                Button_Click(sender, e);
            }
        }

        private void btnSTO_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string message = $"A = {A}\nB = {B}\nC = {C}";
                MessageBox.Show(message, "Giá trị hiện tại của biến", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
