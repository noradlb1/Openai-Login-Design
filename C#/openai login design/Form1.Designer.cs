using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace openai_login_design
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            Guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            Guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            Guna2ControlBox1.Click += new EventHandler(Guna2ControlBox1_Click);
            Guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            Guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Guna2Elipse1
            // 
            Guna2Elipse1.TargetControl = this;
            // 
            // Guna2DragControl1
            // 
            Guna2DragControl1.DockIndicatorTransparencyValue = 0.6d;
            Guna2DragControl1.TargetControl = Guna2Panel1;
            Guna2DragControl1.UseTransparentDrag = true;
            // 
            // Guna2ControlBox1
            // 
            Guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Guna2ControlBox1.BackColor = Color.Transparent;
            Guna2ControlBox1.Cursor = Cursors.Hand;
            Guna2ControlBox1.FillColor = Color.Transparent;
            Guna2ControlBox1.IconColor = Color.Black;
            Guna2ControlBox1.Location = new Point(335, 3);
            Guna2ControlBox1.Name = "Guna2ControlBox1";
            Guna2ControlBox1.Size = new Size(37, 27);
            Guna2ControlBox1.TabIndex = 15;
            // 
            // Guna2Panel1
            // 
            Guna2Panel1.Controls.Add(Guna2ControlBox1);
            Guna2Panel1.Dock = DockStyle.Fill;
            Guna2Panel1.Location = new Point(0, 0);
            Guna2Panel1.Name = "Guna2Panel1";
            Guna2Panel1.Size = new Size(375, 508);
            Guna2Panel1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 508);
            Controls.Add(Guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Guna2Panel1.ResumeLayout(false);
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);

        }

        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl1;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox1;
        internal Guna.UI2.WinForms.Guna2Panel Guna2Panel1;
    }
}