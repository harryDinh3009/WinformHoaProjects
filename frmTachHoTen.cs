namespace TachHoTen
{
    public partial class frmTachHoTen : Form
    {
        public frmTachHoTen()
        {
            InitializeComponent();
        }

        private void btnTach_Click(object sender, EventArgs e)
        {
            // Lấy chuỗi họ tên từ TextBox "txtFullName"
            string fullName = txtFullName.Text.Trim();

            // Khai báo biến chứa Họ, Đệm và Tên
            string ho, dem, ten;

            // Gọi hàm tách họ, đệm và tên
            TachHoDemTen(fullName, out ho, out dem, out ten);

            // Hiển thị kết quả lên các TextBox tương ứng
            txtHo.Text = ho;
            txtDem.Text = dem;
            txtTen.Text = ten;
        }

        private void TachHoDemTen(string fullName, out string ho, out string dem, out string ten)
        {
            // Xóa khoảng trắng thừa ở đầu và cuối chuỗi
            fullName = fullName.Trim();

            // Tách chuỗi thành mảng các từ dựa trên khoảng trắng
            string[] parts = fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Nếu chuỗi chỉ có 1 từ, chỉ có tên
            if (parts.Length == 1)
            {
                ho = parts[0];
                dem = "";
                ten = "";
            }
            // Nếu chuỗi có 2 từ, có họ và tên, không có đệm
            else if (parts.Length == 2)
            {
                ho = parts[0];
                dem = "";
                ten = parts[1];
            }
            // Nếu chuỗi có từ 3 từ trở lên, có họ, đệm và tên
            else
            {
                ho = parts[0]; // Họ là phần tử đầu tiên
                ten = parts[parts.Length - 1]; // Tên là phần tử cuối cùng
                dem = string.Join(" ", parts, 1, parts.Length - 2); // Đệm là các phần tử ở giữa
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHo.Text = "";
            txtDem.Text = "";
            txtTen.Text = "";
            txtFullName.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
