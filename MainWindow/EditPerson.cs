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
    public partial class EditPerson : Form
    {
        private bool isCorrectFirstName;
        private bool isCorrectMidName;
        private bool isCorrectLastName;
        private bool isCorrectGender;
        internal EditPerson()
        {
            InitializeComponent();
        }
        internal AccountInfo GetInfoNewAcc(AccountInfo _curData)
        {
            FillFields(_curData);           
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
                AccountInfo nAccount = new AccountInfo(nPerson, choosePicDialog.FileName);
                return nAccount;
            }
            return null;
        }
        private void FillFields(AccountInfo _curData)
        {
            try
            {
                Bitmap bmp;
                ControlActPerson.LoadPic(_curData.ProfilePic, out bmp);
                profilePicture.Image = bmp;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string[] splittedFullName = _curData.PersonData.FullName.Split(' ');
            textLastName.Text = splittedFullName[0];
            textFirstName.Text = splittedFullName[1];
            textMidName.Text = splittedFullName[2];
            listMaritalStatus.SelectedIndex = (int)_curData.PersonData.MaritalStatus;
            chooseDateOfBirth.Value = _curData.PersonData.DateOfBirth;
            if (_curData.PersonData.Gender == TGender.MAN)
                radioButMan.Checked = true;
            else
                radioButWoman.Checked = true;
            isCorrectFirstName = isCorrectMidName = isCorrectLastName = isCorrectGender = true;
            buttonCreate.Enabled = true;
            textSchool.Text = _curData.PersonData.School;
            textHighSchool.Text = _curData.PersonData.HighSchool;
        }
        private void buttonChoosePicture_Click(object sender, EventArgs e)
        {
            if (choosePicDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap bmp;
                    ControlActPerson.LoadPic(choosePicDialog.FileName, out bmp);
                    profilePicture.Image = bmp;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void textLastName_TextChanged(object sender, EventArgs e)
        {
            textLastName.Text = ControlActPerson.CheckInputName(textLastName.Text);

            isCorrectLastName = ControlActPerson.CheckNameRegex(textLastName.Text);
            buttonCreate.Enabled = isCorrectFirstName && isCorrectLastName && isCorrectMidName && isCorrectGender;
        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {
            textFirstName.Text = ControlActPerson.CheckInputName(textFirstName.Text);

            isCorrectFirstName = ControlActPerson.CheckNameRegex(textFirstName.Text);
            buttonCreate.Enabled = isCorrectFirstName && isCorrectLastName && isCorrectMidName && isCorrectGender;
        }

        private void textMidName_TextChanged(object sender, EventArgs e)
        {
            textMidName.Text = ControlActPerson.CheckInputName(textMidName.Text);

            isCorrectMidName = ControlActPerson.CheckNameRegex(textMidName.Text);
            buttonCreate.Enabled = isCorrectFirstName && isCorrectLastName && isCorrectMidName && isCorrectGender;
        }

        private void radioButMan_CheckedChanged(object sender, EventArgs e)
        {
            isCorrectGender = true;
            int ind = listMaritalStatus.SelectedIndex;
            listMaritalStatus.Items.Clear();
            if (radioButMan.Checked)
                listMaritalStatus.Items.AddRange(Adapter.strMaritalStatusM);
            else
                listMaritalStatus.Items.AddRange(Adapter.strMaritalStatusW);
            listMaritalStatus.SelectedIndex = ind;
            buttonCreate.Enabled = isCorrectFirstName && isCorrectLastName && isCorrectMidName && isCorrectGender;
        }

        private void radioButWoman_CheckedChanged(object sender, EventArgs e)
        {
            isCorrectGender = true;
            int ind = listMaritalStatus.SelectedIndex;
            listMaritalStatus.Items.Clear();
            if (radioButMan.Checked)
                listMaritalStatus.Items.AddRange(Adapter.strMaritalStatusM);
            else
                listMaritalStatus.Items.AddRange(Adapter.strMaritalStatusW);
            listMaritalStatus.SelectedIndex = ind;
            buttonCreate.Enabled = isCorrectFirstName && isCorrectLastName && isCorrectMidName && isCorrectGender;
        }
    }
}
