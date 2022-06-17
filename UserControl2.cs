using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            label1.Parent = this;
            label1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 EditUsersUC = new UserControl1();
            EditUsersUC.Dock = DockStyle.Fill;
            Main.Instance.PnlContainer.Controls.Clear();
            Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
            Main.Instance.PnlContainer.Controls["UserControl1"].BringToFront();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            label1.Parent = this;
            label1.BackColor = Color.Transparent;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
        }
    }
}
