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
    public partial class AddPerson : Form
    {
        private bool isCorrectFirstName;
        private bool isCorrectMidName;
        private bool isCorrectLastName;
        private bool isCorrectGender;
        public AddPerson()
        {
            InitializeComponent();
            MakeEmpty();
        }
        internal AccountInfo GetInfoNewAcc()
        {
            MakeEmpty();           
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
        private void MakeEmpty()
        {
            profilePicture.Image = null;
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
                    profilePicture.Image = ControlActPerson.LoadPic(choosePicDialog.FileName,profilePicture.Size);
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
