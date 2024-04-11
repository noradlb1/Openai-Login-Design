using System.Windows.Forms;

namespace openai_login_design
{
    public partial class UserControlSignUp
    {
        public UserControlSignUp()
        {
            InitializeComponent();
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Clear();
            My.MyProject.Forms.Form1.Guna2Panel1.Controls.Add(new UserControlLogin());
        }
    }
}