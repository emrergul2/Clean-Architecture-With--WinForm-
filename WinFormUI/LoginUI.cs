using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        UserManager userManager = new UserManager(new EfUserDal());


        private void LoginUI_Load(object sender, EventArgs e)
        {

        }

        AdminPanelUI adminPanelUI = new AdminPanelUI();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                UserName = tBoxUserName.Text,
                Password = tBoxPassword.Text
            };

            bool validUser = false;
            List<User> users = userManager.GetAll();
            foreach (var myUser in users)
            {
                if(myUser.UserName==tBoxUserName.Text && myUser.Password == tBoxPassword.Text)
                {
                   
                    validUser = true;
                }

            }
            if (validUser)
            {
                ClearTextBox();
                adminPanelUI.Visible = true;
                this.Visible = false;
            }
            else
            {
                ClearTextBox();
                MessageBox.Show("This username or password is not valid ");
            }
            
        }
        private void ClearTextBox()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }

    }
}
