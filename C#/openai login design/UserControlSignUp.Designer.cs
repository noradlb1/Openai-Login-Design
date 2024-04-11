using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace openai_login_design
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class UserControlSignUp : UserControl
    {

        // UserControl overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            Label1 = new Label();
            LinkLabel3 = new LinkLabel();
            LinkLabel2 = new LinkLabel();
            Guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            Guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            LinkLabel1 = new LinkLabel();
            LinkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
            Guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            Guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            Guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            Guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            Guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(components);
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Guna2PictureBox1
            // 
            Guna2PictureBox1.BackColor = Color.Transparent;
            Guna2PictureBox1.Image = My.Resources.Resources.openai_logo_DmWoKcI3;
            Guna2PictureBox1.ImageRotate = 0f;
            Guna2PictureBox1.Location = new Point(145, 15);
            Guna2PictureBox1.Name = "Guna2PictureBox1";
            Guna2PictureBox1.Size = new Size(74, 68);
            Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox1.TabIndex = 31;
            Guna2PictureBox1.TabStop = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(177, 492);
            Label1.Name = "Label1";
            Label1.Size = new Size(9, 13);
            Label1.TabIndex = 45;
            Label1.Text = "|";
            // 
            // LinkLabel3
            // 
            LinkLabel3.ActiveLinkColor = Color.FromArgb(3, 123, 94);
            LinkLabel3.AutoSize = true;
            LinkLabel3.LinkColor = Color.FromArgb(16, 163, 127);
            LinkLabel3.Location = new Point(184, 492);
            LinkLabel3.Name = "LinkLabel3";
            LinkLabel3.Size = new Size(73, 13);
            LinkLabel3.TabIndex = 44;
            LinkLabel3.TabStop = true;
            LinkLabel3.Text = "Privacy Policy";
            // 
            // LinkLabel2
            // 
            LinkLabel2.ActiveLinkColor = Color.FromArgb(3, 123, 94);
            LinkLabel2.AutoSize = true;
            LinkLabel2.LinkColor = Color.FromArgb(16, 163, 127);
            LinkLabel2.Location = new Point(107, 492);
            LinkLabel2.Name = "LinkLabel2";
            LinkLabel2.Size = new Size(70, 13);
            LinkLabel2.TabIndex = 43;
            LinkLabel2.TabStop = true;
            LinkLabel2.Text = "Terms of Use";
            // 
            // Guna2Separator2
            // 
            Guna2Separator2.Location = new Point(200, 311);
            Guna2Separator2.Name = "Guna2Separator2";
            Guna2Separator2.Size = new Size(118, 10);
            Guna2Separator2.TabIndex = 39;
            // 
            // Guna2HtmlLabel3
            // 
            Guna2HtmlLabel3.BackColor = Color.Transparent;
            Guna2HtmlLabel3.Location = new Point(175, 308);
            Guna2HtmlLabel3.Name = "Guna2HtmlLabel3";
            Guna2HtmlLabel3.Size = new Size(19, 15);
            Guna2HtmlLabel3.TabIndex = 38;
            Guna2HtmlLabel3.Text = "OR";
            // 
            // Guna2Separator1
            // 
            Guna2Separator1.Location = new Point(49, 311);
            Guna2Separator1.Name = "Guna2Separator1";
            Guna2Separator1.Size = new Size(120, 10);
            Guna2Separator1.TabIndex = 37;
            // 
            // LinkLabel1
            // 
            LinkLabel1.ActiveLinkColor = Color.FromArgb(3, 123, 94);
            LinkLabel1.AutoSize = true;
            LinkLabel1.LinkColor = Color.FromArgb(16, 163, 127);
            LinkLabel1.Location = new Point(229, 281);
            LinkLabel1.Name = "LinkLabel1";
            LinkLabel1.Size = new Size(33, 13);
            LinkLabel1.TabIndex = 36;
            LinkLabel1.TabStop = true;
            LinkLabel1.Text = "Login";
            // 
            // Guna2HtmlLabel2
            // 
            Guna2HtmlLabel2.BackColor = Color.Transparent;
            Guna2HtmlLabel2.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Guna2HtmlLabel2.Location = new Point(98, 279);
            Guna2HtmlLabel2.Name = "Guna2HtmlLabel2";
            Guna2HtmlLabel2.Size = new Size(142, 17);
            Guna2HtmlLabel2.TabIndex = 35;
            Guna2HtmlLabel2.Text = "Already have an account?";
            // 
            // Guna2Button1
            // 
            Guna2Button1.BackColor = Color.Transparent;
            Guna2Button1.BorderRadius = 4;
            Guna2Button1.Cursor = Cursors.Hand;
            Guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2Button1.FillColor = Color.FromArgb(16, 163, 127);
            Guna2Button1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guna2Button1.ForeColor = Color.White;
            Guna2Button1.Location = new Point(49, 228);
            Guna2Button1.Name = "Guna2Button1";
            Guna2Button1.Size = new Size(269, 37);
            Guna2Button1.TabIndex = 34;
            Guna2Button1.Text = "Continue";
            // 
            // Guna2TextBox1
            // 
            Guna2TextBox1.BackColor = Color.Transparent;
            Guna2TextBox1.BorderRadius = 3;
            Guna2TextBox1.BorderThickness = 2;
            Guna2TextBox1.Cursor = Cursors.IBeam;
            Guna2TextBox1.DefaultText = "";
            Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Guna2TextBox1.FillColor = Color.FromArgb(240, 240, 240);
            Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2TextBox1.Font = new Font("Segoe UI", 9.0f);
            Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2TextBox1.Location = new Point(49, 160);
            Guna2TextBox1.Name = "Guna2TextBox1";
            Guna2TextBox1.PasswordChar = '\0';
            Guna2TextBox1.PlaceholderForeColor = Color.FromArgb(111, 119, 128);
            Guna2TextBox1.PlaceholderText = "Email address";
            Guna2TextBox1.SelectedText = "";
            Guna2TextBox1.Size = new Size(269, 36);
            Guna2TextBox1.TabIndex = 33;
            // 
            // Guna2HtmlLabel1
            // 
            Guna2HtmlLabel1.BackColor = Color.Transparent;
            Guna2HtmlLabel1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guna2HtmlLabel1.Location = new Point(84, 115);
            Guna2HtmlLabel1.Name = "Guna2HtmlLabel1";
            Guna2HtmlLabel1.Size = new Size(196, 27);
            Guna2HtmlLabel1.TabIndex = 32;
            Guna2HtmlLabel1.Text = "Create an account";
            // 
            // Guna2GradientButton3
            // 
            Guna2GradientButton3.BackColor = Color.Transparent;
            Guna2GradientButton3.BorderColor = Color.FromArgb(194, 200, 208);
            Guna2GradientButton3.BorderRadius = 1;
            Guna2GradientButton3.BorderThickness = 1;
            Guna2GradientButton3.Cursor = Cursors.Hand;
            Guna2GradientButton3.DisabledState.BorderColor = Color.Maroon;
            Guna2GradientButton3.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2GradientButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2GradientButton3.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Guna2GradientButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2GradientButton3.FillColor = Color.Transparent;
            Guna2GradientButton3.FillColor2 = Color.Transparent;
            Guna2GradientButton3.Font = new Font("Segoe UI", 9.0f);
            Guna2GradientButton3.ForeColor = Color.Black;
            Guna2GradientButton3.Image = My.Resources.Resources.icons8_apple_48;
            Guna2GradientButton3.ImageAlign = HorizontalAlignment.Left;
            Guna2GradientButton3.Location = new Point(49, 419);
            Guna2GradientButton3.Name = "Guna2GradientButton3";
            Guna2GradientButton3.Size = new Size(269, 37);
            Guna2GradientButton3.TabIndex = 42;
            Guna2GradientButton3.Text = "Continue with Apple";
            // 
            // Guna2GradientButton2
            // 
            Guna2GradientButton2.BackColor = Color.Transparent;
            Guna2GradientButton2.BorderColor = Color.FromArgb(194, 200, 208);
            Guna2GradientButton2.BorderRadius = 1;
            Guna2GradientButton2.BorderThickness = 1;
            Guna2GradientButton2.Cursor = Cursors.Hand;
            Guna2GradientButton2.DisabledState.BorderColor = Color.Maroon;
            Guna2GradientButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2GradientButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2GradientButton2.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Guna2GradientButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2GradientButton2.FillColor = Color.Transparent;
            Guna2GradientButton2.FillColor2 = Color.Transparent;
            Guna2GradientButton2.Font = new Font("Segoe UI", 9.0f);
            Guna2GradientButton2.ForeColor = Color.Black;
            Guna2GradientButton2.Image = My.Resources.Resources.icons8_microsoft_48;
            Guna2GradientButton2.ImageAlign = HorizontalAlignment.Left;
            Guna2GradientButton2.Location = new Point(49, 374);
            Guna2GradientButton2.Name = "Guna2GradientButton2";
            Guna2GradientButton2.Size = new Size(269, 37);
            Guna2GradientButton2.TabIndex = 41;
            Guna2GradientButton2.Text = "Continue with Microsoft Account";
            // 
            // Guna2GradientButton1
            // 
            Guna2GradientButton1.BackColor = Color.Transparent;
            Guna2GradientButton1.BorderColor = Color.FromArgb(194, 200, 208);
            Guna2GradientButton1.BorderRadius = 1;
            Guna2GradientButton1.BorderThickness = 1;
            Guna2GradientButton1.Cursor = Cursors.Hand;
            Guna2GradientButton1.DisabledState.BorderColor = Color.Maroon;
            Guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2GradientButton1.FillColor = Color.Transparent;
            Guna2GradientButton1.FillColor2 = Color.Transparent;
            Guna2GradientButton1.Font = new Font("Segoe UI", 9.0f);
            Guna2GradientButton1.ForeColor = Color.Black;
            Guna2GradientButton1.Image = My.Resources.Resources.icons8_google_48;
            Guna2GradientButton1.ImageAlign = HorizontalAlignment.Left;
            Guna2GradientButton1.Location = new Point(49, 329);
            Guna2GradientButton1.Name = "Guna2GradientButton1";
            Guna2GradientButton1.Size = new Size(269, 37);
            Guna2GradientButton1.TabIndex = 40;
            Guna2GradientButton1.Text = "Continue with Google";
            // 
            // Guna2DragControl1
            // 
            Guna2DragControl1.DockIndicatorTransparencyValue = 0.6d;
            Guna2DragControl1.TargetControl = Guna2PictureBox1;
            Guna2DragControl1.UseTransparentDrag = true;
            // 
            // Guna2DragControl2
            // 
            Guna2DragControl2.DockIndicatorTransparencyValue = 0.6d;
            Guna2DragControl2.TargetControl = this;
            Guna2DragControl2.UseTransparentDrag = true;
            // 
            // UserControlSignUp
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Label1);
            Controls.Add(LinkLabel3);
            Controls.Add(LinkLabel2);
            Controls.Add(Guna2GradientButton3);
            Controls.Add(Guna2GradientButton2);
            Controls.Add(Guna2GradientButton1);
            Controls.Add(Guna2Separator2);
            Controls.Add(Guna2HtmlLabel3);
            Controls.Add(Guna2Separator1);
            Controls.Add(LinkLabel1);
            Controls.Add(Guna2HtmlLabel2);
            Controls.Add(Guna2Button1);
            Controls.Add(Guna2TextBox1);
            Controls.Add(Guna2HtmlLabel1);
            Controls.Add(Guna2PictureBox1);
            Name = "UserControlSignUp";
            Size = new Size(375, 508);
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
        internal Label Label1;
        internal LinkLabel LinkLabel3;
        internal LinkLabel LinkLabel2;
        internal Guna.UI2.WinForms.Guna2GradientButton Guna2GradientButton3;
        internal Guna.UI2.WinForms.Guna2GradientButton Guna2GradientButton2;
        internal Guna.UI2.WinForms.Guna2GradientButton Guna2GradientButton1;
        internal Guna.UI2.WinForms.Guna2Separator Guna2Separator2;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel3;
        internal Guna.UI2.WinForms.Guna2Separator Guna2Separator1;
        internal LinkLabel LinkLabel1;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel2;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button1;
        internal Guna.UI2.WinForms.Guna2TextBox Guna2TextBox1;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel1;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl1;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl2;
    }
}