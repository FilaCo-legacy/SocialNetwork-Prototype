using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
    public partial class AddPersonDialog : Form
    {
        private bool isCorrectFirstName;
        private bool isCorrectMidName;
        private bool isCorrectLastName;
        private bool isCorrectGender;
        public AddPersonDialog()
        {
            InitializeComponent();
            CorrectForm();
            MakeEmpty();
        }
        private void CorrectForm()
        {
            profilePicture.Location = new Point(30, 35);
            buttonChoosePicture.Location = new Point(profilePicture.Location.X + (profilePicture.Width -
                buttonChoosePicture.Width) / 2, buttonChoosePicture.Location.Y);
            labelEmptyPic.Location = new Point(profilePicture.Location.X + (profilePicture.Width -
                labelEmptyPic.Width) / 2, profilePicture.Location.Y + (profilePicture.Height -
                labelEmptyPic.Height) / 2);
        }
        private void MakeEmpty()
        {
            profilePicture.Image = null;
            labelEmptyPic.Show();
            foreach(var cur in tableData.Controls)
            {
                if (cur as TextBox != null)
                {
                    (cur as TextBox).Text = "";
                }
            }
            listMaritalStatus.SelectedIndex = 0;
            chooseDateOfBirth.Value = chooseDateOfBirth.MaxDate;
            radioButMan.Checked = radioButWoman.Checked = false;
            isCorrectFirstName = isCorrectMidName = isCorrectLastName = isCorrectGender = false;
        }
        private void buttonChoosePicture_Click(object sender, EventArgs e)
        {
            if (choosePicDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap bmp;
                    ControlAddPersonDialog.AddProfilePic(choosePicDialog.FileName, out bmp);
                    profilePicture.Image = bmp;
                    labelEmptyPic.Hide();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void AddPersonDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            MakeEmpty();
        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {
            textLastName.Text = ControlAddPersonDialog.CheckInputName(textLastName.Text);            
        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {
            textFirstName.Text = ControlAddPersonDialog.CheckInputName(textFirstName.Text);
        }

        private void textMidName_TextChanged(object sender, EventArgs e)
        {
            textMidName.Text = ControlAddPersonDialog.CheckInputName(textMidName.Text);
        }
        private void textLastName_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
