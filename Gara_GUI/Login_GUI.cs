using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gara_DTO;
using Gara_BUS;

namespace Gara_GUI
{
    public partial class Login_GUI : Form
    {
        Login_BUS login_BUS = new Login_BUS();

        public Login_GUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text != "" && txtMatKhau.Text != "")
            {
                Login_DTO login_DTO = new Login_DTO(txtMatKhau.Text, txtMatKhau.Text);
                if(login_BUS.CheckLogin(login_DTO))
                {
                    Home_GUI home_GUI = new Home_GUI(txtTaiKhoan.Text);
                    home_GUI.ShowDialog();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Sai mật khẩu hoặc tài khoản. Vui lòng nhập lại!", "Thông báo");
                }
            } else
            {
                MessageBox.Show("Còn thiếu tài khoản hoặc mật khẩu. Vui lòng nhập lại!", "Thông báo");
            }
        }
   

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
          
        }

   
    }
}
