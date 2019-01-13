﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetwork
{
    public partial class NetworkPage : UserControl
    {
        private AccountInfo curAcc;
        internal NetworkPage(AccountInfo _curAcc)
        {
            InitializeComponent();
            editPerson = new EditPerson();
            curAcc = _curAcc;
            FillInfo();
        }
        private void FillInfo()
        {
            try
            {
                if (curAcc.ProfilePic != "")
                    pictureProfile.Image = ControlNetworkPage.LoadPic(curAcc.ProfilePic, pictureProfile.Size);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            labelFullName.Text = curAcc.PersonData.FullName;
            dataViewPerson.DataSource = ControlNetworkPage.InfoPerson(curAcc.PersonData);
        }
        private void butEditInfo_Click(object sender, EventArgs e)
        {
            editPerson.EditAcc(ref curAcc);
        }
    }
}