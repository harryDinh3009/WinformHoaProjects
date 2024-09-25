using System.Data;
using System.Text.RegularExpressions;

namespace Calculator19
{
    public partial class frmHoaCalculator : Form
    {
        public frmHoaCalculator()
        {
            InitializeComponent();
        }
        double Ans = 0;
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int curPositon = txtPhepTinh.SelectionStart;
            if (lblKQ.Text != "" && (btn == btnCong || btn == btnTru || btn == btnNhan || btn == btnChia))
            {
                txtPhepTinh.Text = "ANS" + btn.Text;
                txtPhepTinh.SelectionStart = txtPhepTinh.Text.Length;
            }
            else if (lblKQ.Text != "")
            {
                txtPhepTinh.Text = btn.Text;
                txtPhepTinh.SelectionStart = btn.Text.Length;
            }
            else
            {
                txtPhepTinh.Text = txtPhepTinh.Text.Insert(curPositon, btn.Text);
                txtPhepTinh.SelectionStart = curPositon + btn.Text.Length;
            }
            lblKQ.Text = "";
            txtPhepTinh.Focus();

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
            btnCong.Click += new EventHandler(Button_Click);
            btnTru.Click += new EventHandler(Button_Click);
            btnNhan.Click += new EventHandler(Button_Click);
            btnChia.Click += new EventHandler(Button_Click);

        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtPhepTinh.Text = "";
            lblKQ.Text = "";
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string expression = txtPhepTinh.Text;
            expression = expression.Replace("ANS", Ans.ToString());
            var result = dt.Compute(expression, string.Empty);

            double computedResult;
            if (result != null && double.TryParse(result.ToString(), out computedResult))
            {
                lblKQ.Text = computedResult.ToString();
                Ans = computedResult;
            }
            else
            {
                lblKQ.Text = "L?i phép tính";
            }
        }

        private void txtPhepTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '+') && (e.KeyChar != '-') &&
    (e.KeyChar != '*') && (e.KeyChar != '/') &&
    (e.KeyChar != '(') && (e.KeyChar != ')') &&
    (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }

        }

        private void btnDoiDau_Click(object sender, EventArgs e)
        {
            int cursorPosition = txtPhepTinh.SelectionStart;
            if (string.IsNullOrWhiteSpace(txtPhepTinh.Text) || cursorPosition == 0)
                return;

            string text = txtPhepTinh.Text;
            string pattern = @"(-?\d+\.?\d*)";

            MatchCollection matches = Regex.Matches(text.Substring(0, cursorPosition), pattern);
            if (matches.Count > 0)
            {
                Match lastMatch = matches[matches.Count - 1];
                string numberStr = lastMatch.Value;

                if (double.TryParse(numberStr, out double number))
                {
                    number = -number;
                    txtPhepTinh.Text = text.Substring(0, lastMatch.Index) + number.ToString() + text.Substring(lastMatch.Index + numberStr.Length);
                    txtPhepTinh.SelectionStart = cursorPosition + (number.ToString().Length - numberStr.Length);
                }
            }
        }

        private void btnSolve_MouseHover(object sender, EventArgs e)
        {
            btnSolve.BackColor = Color.BlueViolet;
        }

        private void btnSolve_MouseLeave(object sender, EventArgs e)
        {
            btnSolve.BackColor = Color.Blue;
        }
    }
}