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
        public EditPerson()
        {
            InitializeComponent();
        }
        public void EditAcc(ref TPerson curData)
        {
            FillFields(curData);
            if (ShowDialog() == DialogResult.OK)
            {
                string fullName = string.Format($"{textLastName.Text} {textFirstName.Text} " + $"{textMidName.Text}");
                if (fullName != curData.FullName)
                    curData.FullName = fullName;
                TGender chosenGender = radioButMan.Checked ? TGender.MAN : TGender.WOMAN;
                if (chosenGender != curData.Gender)
                    curData.Gender = chosenGender;
                TStatus chosenStatus = (TStatus)listMaritalStatus.SelectedIndex;
                if (chosenStatus != curData.MaritalStatus)
                    curData.MaritalStatus = chosenStatus;
                string school = textSchool.Text.Trim();
                if (school != curData.School)
                    curData.School = school;
                string highSchool = textHighSchool.Text.Trim();
                if (highSchool != curData.HighSchool)
                    curData.HighSchool = highSchool;
                if (choosePicDialog.FileName != "")
                    curData.ProfilePic = choosePicDialog.FileName;
            }
        }
        private void FillFields(TPerson _curData)
        {
            try
            {
                profilePicture.Image = ControlActPerson.LoadPic(_curData.ProfilePic, profilePicture.Size);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string[] splittedFullName = _curData.FullName.Split(' ');
            textLastName.Text = splittedFullName[0];
            textFirstName.Text = splittedFullName[1];
            textMidName.Text = splittedFullName[2];
            listMaritalStatus.SelectedIndex = (int)_curData.MaritalStatus;
            chooseDateOfBirth.Value = _curData.DateOfBirth;
            if (_curData.Gender == TGender.MAN)
                radioButMan.Checked = true;
            else
                radioButWoman.Checked = true;
            isCorrectFirstName = isCorrectMidName = isCorrectLastName = isCorrectGender = true;
            buttonCreate.Enabled = true;
            textSchool.Text = _curData.School;
            textHighSchool.Text = _curData.HighSchool;
        }
        private void buttonChoosePicture_Click(object sender, EventArgs e)
        {
            if (choosePicDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    profilePicture.Image = ControlActPerson.LoadPic(choosePicDialog.FileName, profilePicture.Size);
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
