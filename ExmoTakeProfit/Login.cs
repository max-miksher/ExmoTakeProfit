using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
namespace ExmoTakeProfit
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cancle_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Keys a = new Keys();
            a.key = this.key.Text;
            a.secret = this.secret.Text;
            if(WorkWithLocalFiles.WriteFile(a))
            {
                this.Close();
            }
        }
    }
}
