using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetwork
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
        internal TPerson GetInfoNewAcc()
        {
            if (ShowDialog() == DialogResult.OK)
            {
                string fullName = string.Format($"{textLastName.Text.Trim()} {textFirstName.Text.Trim()} " +
                    $"{textMidName.Text.Trim()}");
                TGender chosenGender = radioButMan.Checked ? TGender.MAN : TGender.WOMAN;
                TStatus chosenStatus = (TStatus)listMaritalStatus.SelectedIndex;
                string school = textSchool.Text.Trim();
                string highSchool = textHighSchool.Text.Trim();
                TPerson nPerson = new TPerson(fullName, chooseDateOfBirth.Value, chosenGender, chosenStatus, school,
                    highSchool);
                return nPerson;
            }
            return null;
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
            buttonCreate.Enabled = false;
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

            isCorrectLastName = ControlAddPersonDialog.CheckNameRegex(textLastName.Text);
            buttonCreate.Enabled = isCorrectFirstName && isCorrectLastName && isCorrectMidName && isCorrectGender;
        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {
            textFirstName.Text = ControlAddPersonDialog.CheckInputName(textFirstName.Text);

            isCorrectFirstName = ControlAddPersonDialog.CheckNameRegex(textFirstName.Text);
            buttonCreate.Enabled = isCorrectFirstName && isCorrectLastName && isCorrectMidName && isCorrectGender;
        }

        private void textMidName_TextChanged(object sender, EventArgs e)
        {
            textMidName.Text = ControlAddPersonDialog.CheckInputName(textMidName.Text);

            isCorrectMidName = ControlAddPersonDialog.CheckNameRegex(textMidName.Text);
            buttonCreate.Enabled = isCorrectFirstName && isCorrectLastName && isCorrectMidName && isCorrectGender;
        }

        private void radioButMan_CheckedChanged(object sender, EventArgs e)
        {
            isCorrectGender = true;
            listMaritalStatus.Items.Clear();
            if (radioButMan.Checked)
                listMaritalStatus.Items.AddRange(Adapter.strMaritalStatusM);
            else
                listMaritalStatus.Items.AddRange(Adapter.strMaritalStatusW);
            listMaritalStatus.SelectedIndex = 0;
        }
    }
}
