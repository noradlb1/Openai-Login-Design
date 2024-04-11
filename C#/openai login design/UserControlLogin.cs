using System.Windows.Forms;

namespace openai_login_design
{
    public partial class UserControlLogin
    {
        public UserControlLogin()
        {
            InitializeComponent();
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Clear();
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Add(new UserControlSignUp());
        }
    }
}