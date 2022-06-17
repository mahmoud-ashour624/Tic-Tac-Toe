using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Main : Form
    {
        static Main _obj;
        
        public static Main Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new Main();
                return _obj;
            }
        }
        public Panel PnlContainer
        {

            get { return panel1; }
            set { panel1 = value; }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _obj = this;
            UserControl1 loginUC = new UserControl1();
            loginUC.Dock = DockStyle.Fill;
            PnlContainer.Controls.Clear();
            PnlContainer.Controls.Add(loginUC);
            loginUC.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}