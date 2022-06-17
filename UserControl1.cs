using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        int[,] arr = new int[3, 3];
        bool turn = false;
        bool checkX()
        {
            int check = 1;
            for (int i = 0; i < 3; i++)
            {
                check = 1;
                for (int j = 0; j < 3; j++)
                {
                    if (arr[i, j] != 1) check = 0;
                }
                if (check == 1) return true;
                check = 1;
                for (int j = 0; j < 3; j++)
                {
                    if (arr[j, i] != 1) check = 0;
                }
                if (check == 1) return true;
            }
            check = 1;
            for (int i = 0, j = 0; i < 3; i++, j++)
            {
                if (arr[i, j] != 1) check = 0;
            }
            if (check == 1) return true;
            check = 1;
            for (int i = 0, j = 2; i < 3; i++, j--)
            {
                if (arr[i, j] != 1) check = 0;
            }
            if (check == 1) return true;
            return false;
        }
        bool checkY()
        {
            int check = 1;
            for (int i = 0; i < 3; i++)
            {
                check = 1;
                for (int j = 0; j < 3; j++)
                {
                    if (arr[i, j] != 2) check = 0; ;
                }
                if (check == 1) return true;
                check = 1;
                for (int j = 0; j < 3; j++)
                {
                    if (arr[j, i] != 2) check = 0;
                }
                if (check == 1) return true;
            }
            check = 1;
            for (int i = 0, j = 0; i < 3; i++, j++)
            {
                if (arr[i, j] != 2) check = 0;
            }
            if (check == 1) return true;
            check = 1;
            for (int i = 0, j = 2; i < 3; i++, j--)
            {
                if (arr[i, j] != 2) check = 0;
            }
            if (check == 1) return true;
            return false;
        }
        bool check_Draw()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arr[i, j] == 0) return false;
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (turn == false)
            {
                arr[2, 0] = 1;
                button1.Text = "X";
                label1.Text = "It's O turn";
                if (checkX() == true)
                {

                    UserControl2 EditUsersUC = new UserControl2();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            else
            {
                arr[2, 0] = 2;
                button1.Text = "O";
                label1.Text = "It's X turn"; ;
                if (checkY() == true)
                {
                    UserControl4 EditUsersUC = new UserControl4();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            button1.Show();
            button1.Enabled = false;
            turn = !turn;
            if (!checkX() && !checkY() && check_Draw())
            {
                UserControl3 EditUsersUC = new UserControl3();
                EditUsersUC.Dock = DockStyle.Fill;
                Main.Instance.PnlContainer.Controls.Clear();
                Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                EditUsersUC.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turn == false)
            {
                arr[2, 1] = 1;
                button2.Text = "X";
                label1.Text = "It's O turn";
                if (checkX() == true)
                {
                    UserControl2 EditUsersUC = new UserControl2();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            else
            {
                arr[2, 1] = 2;
                button2.Text = "O";
                label1.Text = "It's X turn"; ;
                if (checkY() == true)
                {
                    UserControl4 EditUsersUC = new UserControl4();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            button2.Show();
            button2.Enabled = false;
            turn = !turn;
            if (!checkX() && !checkY() && check_Draw())
            {
                UserControl3 EditUsersUC = new UserControl3();
                EditUsersUC.Dock = DockStyle.Fill;
                Main.Instance.PnlContainer.Controls.Clear();
                Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                EditUsersUC.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turn == false)
            {
                arr[2, 2] = 1;
                button3.Text = "X";
                label1.Text = "It's O turn";
                if (checkX() == true)
                {
                    UserControl2 EditUsersUC = new UserControl2();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            else
            {
                arr[2, 2] = 2;
                button3.Text = "O";
                label1.Text = "It's X turn"; ;
                if (checkY() == true)
                {
                    UserControl4 EditUsersUC = new UserControl4();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            button3.Show();
            button3.Enabled = false;
            turn = !turn;
            if (!checkX() && !checkY() && check_Draw())
            {
                UserControl3 EditUsersUC = new UserControl3();
                EditUsersUC.Dock = DockStyle.Fill;
                Main.Instance.PnlContainer.Controls.Clear();
                Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                EditUsersUC.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turn == false)
            {
                arr[1, 2] = 1;
                button4.Text = "X";
                label1.Text = "It's O turn";
                if (checkX() == true)
                {
                    UserControl2 EditUsersUC = new UserControl2();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            else
            {
                arr[1, 2] = 2;
                button4.Text = "O";
                label1.Text = "It's X turn"; ;
                if (checkY() == true)
                {
                    UserControl4 EditUsersUC = new UserControl4();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            button4.Show();
            button4.Enabled = false;
            turn = !turn;
            if (!checkX() && !checkY() && check_Draw())
            {
                UserControl3 EditUsersUC = new UserControl3();
                EditUsersUC.Dock = DockStyle.Fill;
                Main.Instance.PnlContainer.Controls.Clear();
                Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                EditUsersUC.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (turn == false)
            {
                arr[1, 1] = 1;
                button5.Text = "X";
                label1.Text = "It's O turn";
                if (checkX() == true)
                {
                    UserControl2 EditUsersUC = new UserControl2();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            else
            {
                arr[1, 1] = 2;
                button5.Text = "O";
                label1.Text = "It's X turn"; ;
                if (checkY() == true)
                {
                    UserControl4 EditUsersUC = new UserControl4();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            button5.Show();
            button5.Enabled = false;
            turn = !turn;
            if (!checkX() && !checkY() && check_Draw())
            {
                UserControl3 EditUsersUC = new UserControl3();
                EditUsersUC.Dock = DockStyle.Fill;
                Main.Instance.PnlContainer.Controls.Clear();
                Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                EditUsersUC.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (turn == false)
            {
                arr[1, 0] = 1;
                button6.Text = "X";
                label1.Text = "It's O turn";
                if (checkX() == true)
                {
                    UserControl2 EditUsersUC = new UserControl2();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            else
            {
                arr[1, 0] = 2;
                button6.Text = "O";
                label1.Text = "It's X turn"; ;
                if (checkY() == true)
                {
                    UserControl4 EditUsersUC = new UserControl4();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            button6.Show();
            button6.Enabled = false;
            turn = !turn;
            if (!checkX() && !checkY() && check_Draw())
            {
                UserControl3 EditUsersUC = new UserControl3();
                EditUsersUC.Dock = DockStyle.Fill;
                Main.Instance.PnlContainer.Controls.Clear();
                Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                EditUsersUC.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (turn == false)
            {
                arr[0, 0] = 1;
                button9.Text = "X";
                label1.Text = "It's O turn";
                if (checkX() == true)
                {
                    UserControl2 EditUsersUC = new UserControl2();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            else
            {
                arr[0, 0] = 2;
                button9.Text = "O";
                label1.Text = "It's X turn"; ;
                if (checkY() == true)
                {
                    UserControl4 EditUsersUC = new UserControl4();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            button9.Show();
            button9.Enabled = false;
            turn = !turn;
            if (!checkX() && !checkY() && check_Draw())
            {
                UserControl3 EditUsersUC = new UserControl3();
                EditUsersUC.Dock = DockStyle.Fill;
                Main.Instance.PnlContainer.Controls.Clear();
                Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                EditUsersUC.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (turn == false)
            {
                arr[0, 1] = 1;
                button8.Text = "X";
                label1.Text = "It's O turn";
                if (checkX() == true)
                {
                    UserControl2 EditUsersUC = new UserControl2();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            else
            {
                arr[0, 1] = 2;
                button8.Text = "O";
                label1.Text = "It's X turn"; ;
                if (checkY() == true)
                {
                    UserControl4 EditUsersUC = new UserControl4();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            button8.Show();
            button8.Enabled = false;
            turn = !turn;
            if (!checkX() && !checkY() && check_Draw())
            {
                UserControl3 EditUsersUC = new UserControl3();
                EditUsersUC.Dock = DockStyle.Fill;
                Main.Instance.PnlContainer.Controls.Clear();
                Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                EditUsersUC.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (turn == false)
            {
                arr[0, 2] = 1;
                button7.Text = "X";
                label1.Text = "It's O turn";
                if (checkX() == true)
                {
                    UserControl2 EditUsersUC = new UserControl2();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            else
            {
                arr[0, 2] = 2;
                button7.Text = "O";
                label1.Text = "It's X turn"; ;
                if (checkY() == true)
                {
                    UserControl4 EditUsersUC = new UserControl4();
                    EditUsersUC.Dock = DockStyle.Fill;
                    Main.Instance.PnlContainer.Controls.Clear();
                    Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                    EditUsersUC.Show();
                }
            }
            button7.Show();
            button7.Enabled = false;
            turn = !turn;
            if (!checkX() && !checkY() && check_Draw())
            {
                UserControl3 EditUsersUC = new UserControl3();
                EditUsersUC.Dock = DockStyle.Fill;
                Main.Instance.PnlContainer.Controls.Clear();
                Main.Instance.PnlContainer.Controls.Add(EditUsersUC);
                EditUsersUC.Show();
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            label1.Parent = this;
            label1.BackColor = Color.Transparent;
            button1.Parent = this;
            button1.BackColor = Color.Transparent;
            button2.Parent = this;
            button2.BackColor = Color.Transparent;
            button3.Parent = this;
            button3.BackColor = Color.Transparent;
            button4.Parent = this;
            button4.BackColor = Color.Transparent;
            button5.Parent = this;
            button5.BackColor = Color.Transparent;
            button6.Parent = this;
            button6.BackColor = Color.Transparent;
            button7.Parent = this;
            button7.BackColor = Color.Transparent;
            button8.Parent = this;
            button8.BackColor = Color.Transparent;
            button9.Parent = this;
            button9.BackColor = Color.Transparent;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.Cursor = Cursors.Hand;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Cursor = Cursors.Hand;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.Cursor = Cursors.Hand;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.Cursor = Cursors.Hand;
            button5.Cursor = Cursors.Hand;
            button6.Cursor = Cursors.Hand;
            button8.Cursor = Cursors.Hand;
            button9.Cursor = Cursors.Hand;
        }
    }
}
