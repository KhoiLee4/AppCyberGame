using AppCyberGame.Service;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCyberGame.View.LoginLogout
{
    public partial class RegisterManuallyForm : Form
    {
        private FormAction _action;
        public RegisterManuallyForm()
        {
            InitializeComponent();
            _action = new FormAction();
            this.Dock = DockStyle.Fill;
        }

        private void lblAsk_Click(object sender, EventArgs e)
        {
            _action.LoadCreate();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _action.LoadLogin();
        }

        private void lblAsk_MouseHover(object sender, EventArgs e)
        {
            lblAsk.Cursor = Cursors.Hand;
        }

        private bool checkEmail(Guna2Button messege)
        {
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txbEmail.Text) || txbEmail.Text == "Email")
            {
                messege.Text = "Please enter email";
                return false;
            }
            // Kiểm tra định dạng
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txbEmail.Text, emailPattern))
            {
                messege.Text = "Email format incorrect";
                return false;
            }
            else
            {
                messege.Text = "";
                return true;
            }
        }
        private bool checkUsername(Guna2Button messege)
        {
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txbUsername.Text) || txbUsername.Text == "Username")
            {
                messege.Text = "Please enter username";
                return false;
            }
            else if (txbUsername.Text.Length < 3)
            {
                messege.Text = "Username must be at least 3 characters long";
                return false;
            }
            else if (txbUsername.Text.Length > 20)
            {
                messege.Text = "Username must be less than 20 characters long";
                return false;
            }
            // Kiểm tra định dạng
            var namePattern = @"^[a-zA-Z0-9\s]+$";
            if (!Regex.IsMatch(txbUsername.Text, namePattern))
            {
                messege.Text = "Username must contain only letters, numbers and spaces, no special characters";
                return false;
            }
            else
            {
                messege.Text = "";
                return true;
            }
        }
        private bool checkPassword(Guna2Button messege)
        {
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txbPassword.Text) || txbPassword.Text == "Password")
            {
                messege.Text = "Please enter password";
                return false;
            }
            else if (txbPassword.Text.Length < 5)
            {
                messege.Text = "Password must be at least 5 characters long";
                return false;
            }
            else if (txbPassword.Text.Length > 20)
            {
                messege.Text = "Password must be less than 20 characters long";
                return false;
            }
            // Kiểm tra định dạng
            var passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            if (!Regex.IsMatch(txbPassword.Text, passwordPattern))
            {
                messege.Text = "Password must contain uppercase, lowercase, numbers and special characters";
                return false;
            }
            else
            {
                messege.Text = "";
                return true;
            }
        }
        private bool checkConfirmPassword(Guna2Button messege)
        {
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txbConfirmPassword.Text) || txbConfirmPassword.Text == "Confirm Password")
            {
                messege.Text = "Please confirm password";
                return false;
            }
            if (!txbConfirmPassword.Text.Equals(txbPassword.Text))
            {
                messege.Text = "Password confirm incorrect";
                return false;
            }
            else
            {
                messege.Text = "";
                return true;
            }
        }
        // Sự kiện bấm vào mắt ở Password
        //private void picEyeOfPass_Click(object sender, EventArgs e)
        //{
        //    openEyeFor(picEyeOfPass);
        //}
        // Sự kiện bấm vào mắt ở ConfirmPassword
        //private void picEyeOfConfirm_Click(object sender, EventArgs e)
        //{
        //    openEyeFor(picEyeOfConfirm);
        //}
        // Thực hiện đóng mắt
        //void closeEye(PictureBox pic)
        //{
        //    try
        //    {
        //        pic.Image = global::App_Library.Properties.Resources.eye_slash;
        //        if (pic.Name.Contains("Confirm"))
        //        {
        //            if (!(txtConfirm.Text == "Confirm Password"))
        //            {
        //                txtConfirm.PasswordChar = '*';
        //            }
        //            picEyeOfConfirm.Click += new EventHandler(this.picEyeOfConfirm_Click);
        //        }
        //        else
        //        {
        //            if (!(txtPassword.Text == "Password"))
        //            {
        //                txtPassword.PasswordChar = '*';
        //            }
        //            picEyeOfPass.Click += new EventHandler(this.picEyeOfPass_Click);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}
        // Thực hiện mở mắt
        //void openEyeFor(PictureBox pic)
        //{
        //    try
        //    {
        //        pic.Image = global::App_Library.Properties.Resources.eye;
        //        if (pic.Name.Contains("Confirm"))
        //        {
        //            txtConfirm.PasswordChar = '\0';
        //            timerOpenEyeForConfirm.Start();
        //            picEyeOfConfirm.Click -= new EventHandler(this.picEyeOfConfirm_Click);
        //        }
        //        else
        //        {
        //            txtPassword.PasswordChar = '\0';
        //            timerOpenEyeForPassWord.Start();
        //            picEyeOfPass.Click -= new EventHandler(this.picEyeOfPass_Click);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}
        // Hiệu ứng mắt ở Password
        //private void timerOpenEyeForPassWord_Tick(object sender, EventArgs e)
        //{
        //    if (second > 0)
        //    {
        //        second--;
        //    }
        //    else
        //    {
        //        second = 2;
        //        timerOpenEyeForPassWord.Stop();
        //        closeEye(picEyeOfPass);
        //    }
        //}
        // Hiệu ứng mắt ở ConfirmPassword
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (second > 0)
        //    {
        //        second--;
        //    }
        //    else
        //    {
        //        second = 2;
        //        timerOpenEyeForConfirm.Stop();
        //        closeEye(picEyeOfConfirm);
        //    }
        //}
        //private void lbGG_MouseHover(object sender, EventArgs e)
        //{
        //    lbGG.Text = "";
        //    timerHoverGg.Start();
        //}

        //private void timerHoverGg_Tick(object sender, EventArgs e)
        //{
        //    if (picGG.Location.X < lbGG.Width / 2)
        //    {
        //        picGG.Location = new Point(picGG.Location.X + 5, lbGG.Location.Y);
        //    }
        //    else
        //    {
        //        timerHoverGg.Stop();
        //    }
        //}
        //private void lbGG_MouseLeave(object sender, EventArgs e)
        //{
        //    timerHoverGg.Stop();
        //    timerLeaveGG.Start();
        //}
        //private void timerLeaveGG_Tick(object sender, EventArgs e)
        //{
        //    if (picGG.Location.X > xPicGG)
        //    {
        //        picGG.Location = new Point(picGG.Location.X - 5, lbGG.Location.Y);
        //    }
        //    else
        //    {
        //        lbGG.Text = "Continue with Google";
        //        timerLeaveGG.Stop();
        //    }
        //}

        //private void txbEmail_MouseHover(object sender, EventArgs e)
        //{
        //    Guna2Panel pn = sender as Guna2Panel; pn.BorderColor = Color.Aqua;
        //}

        //private void gnPanelEmail_MouseLeave(object sender, EventArgs e)
        //{
        //    Guna2Panel pn = sender as Guna2Panel;
        //    foreach (Control txb in pn.Controls)
        //    {
        //        if (txb is TextBox)
        //        {
        //            if (txb.Text == "" || txb.Text.Equals("Email") || txb.Text.Equals("Username") || txb.Text.Equals("Password") || txb.Text.Equals("Confirm Password"))
        //            {
        //                pn.BorderColor = Color.DarkGray;
        //            }
        //        }
        //    }
        //}

        private void txbEmail_MouseLeave(object sender, EventArgs e)
        {
            txbEmail.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbEmail_MouseHover(object sender, EventArgs e)
        {
            txbEmail.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbEmail_Leave(object sender, EventArgs e)
        {
            if (txbEmail.Text == string.Empty)
            {
                txbEmail.Text = "Email Address";
                txbEmail.ForeColor = Color.Silver;
                txbEmail.BorderColor = Color.FromArgb(52, 52, 116);
            }
        }

        private void txbEmail_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text == "Email Address")
            {
                txbEmail.Text = string.Empty;
                txbEmail.ForeColor = Color.FromArgb(60, 211, 252);
                txbEmail.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
        private void txbUsername_MouseLeave(object sender, EventArgs e)
        {
            txbUsername.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbUsername_MouseHover(object sender, EventArgs e)
        {
            txbUsername.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbUsername_Leave(object sender, EventArgs e)
        {
            if (txbUsername.Text == string.Empty)
            {
                txbUsername.Text = "Username";
                txbUsername.ForeColor = Color.Silver;
            }
        }

        private void txbUserName_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "Username")
            {
                txbUsername.Text = string.Empty;
                txbUsername.ForeColor = Color.FromArgb(60, 211, 252);
                txbUsername.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
        private void txbPassword_MouseLeave(object sender, EventArgs e)
        {
            txbPassword.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbPassword_MouseHover(object sender, EventArgs e)
        {
            txbPassword.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == string.Empty)
            {
                txbPassword.Text = "Password";
                txbPassword.PasswordChar = '\0';
                txbPassword.ForeColor = Color.Silver;
            }
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text == "Password")
            {
                txbPassword.Text = string.Empty;
                txbPassword.ForeColor = Color.FromArgb(60, 211, 252);
                txbPassword.BorderColor = Color.FromArgb(60, 211, 252);
                txbPassword.PasswordChar = '*';
            }
        }
        private void txbConfirmPassword_MouseLeave(object sender, EventArgs e)
        {
            txbConfirmPassword.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbConfirmPassword_MouseHover(object sender, EventArgs e)
        {
            txbConfirmPassword.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txbConfirmPassword.Text == string.Empty)
            {
                txbConfirmPassword.Text = "Confirm Password";
                txbConfirmPassword.PasswordChar = '\0';
                txbConfirmPassword.ForeColor = Color.Silver;
            }
        }

        private void txbConfirmPassword_Click(object sender, EventArgs e)
        {
            if (txbConfirmPassword.Text == "Confirm Password")
            {
                txbConfirmPassword.Text = string.Empty;
                txbConfirmPassword.ForeColor = Color.FromArgb(60, 211, 252);
                txbConfirmPassword.BorderColor = Color.FromArgb(60, 211, 252);
                txbConfirmPassword.PasswordChar = '*';
            }
        }

        private void txbFullName_MouseLeave(object sender, EventArgs e)
        {
            txbFullName.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbFullName_MouseHover(object sender, EventArgs e)
        {
            txbFullName.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbFullName_Leave(object sender, EventArgs e)
        {
            if (txbFullName.Text == string.Empty)
            {
                txbFullName.Text = "Full name";
                txbFullName.ForeColor = Color.Silver;
            }
        }

        private void txbFullName_Click(object sender, EventArgs e)
        {
            if (txbFullName.Text == "Full name")
            {
                txbFullName.Text = string.Empty;
                txbFullName.ForeColor = Color.FromArgb(60, 211, 252);
                txbFullName.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
        private void txbPhone_MouseLeave(object sender, EventArgs e)
        {
            txbPhone.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbPhone_MouseHover(object sender, EventArgs e)
        {
            txbPhone.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbPhone_Leave(object sender, EventArgs e)
        {
            if (txbPhone.Text == string.Empty)
            {
                txbPhone.Text = "Phone number (Optional)";
                txbPhone.ForeColor = Color.Silver;
            }
        }

        private void txbPhone_Click(object sender, EventArgs e)
        {
            if (txbPhone.Text == "Phone number (Optional)")
            {
                txbPhone.Text = string.Empty;
                txbPhone.ForeColor = Color.FromArgb(60, 211, 252);
                txbPhone.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
    }
}
