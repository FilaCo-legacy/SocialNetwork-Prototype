using System;
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
        private TPerson curAcc;
        private int curIndPicture;
        public NetworkPage(TPerson _curAcc)
        {
            InitializeComponent();
            editPerson = new EditPerson();
            curAcc = _curAcc;
            FillInfo();
           
            groupAlbum.MouseWheel += groupAlbum_MouseWheel;
            groupAlbum.KeyDown += groupAlbum_KeyDown;
            groupAlbum.MouseEnter += groupAlbum_MouseEnter;
            groupAlbum.PreviewKeyDown += groupAlbum_PreviewKeyDown;

            textNews.butSend.Click += butSend_Click;
        }

        public void butSend_Click(object sender, EventArgs e)
        {
            Adapter.AddNews(curAcc, textNews.MsgText);
            DataTable dt = (DataTable)dataViewNews.DataSource;
            ControlNetworkPage.UpdateNewsTable(ref dt, DateTime.Now, textNews.MsgText);
            dataViewNews.DataSource = dt;
            dataViewNews.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataViewNews.Focus();
            textNews.ClearCache();
        }

        private void displayPictures(string [] paths)
        {
            picturePref.Image = ControlNetworkPage.LoadPic(paths[0], picturePref.Size);
            pictureCur.Image = ControlNetworkPage.LoadPic(paths[1], pictureCur.Size);
            pictureNext.Image = ControlNetworkPage.LoadPic(paths[2], pictureNext.Size);
        }
        private void groupAlbum_PreviewKeyDown(object sender, PreviewKeyDownEventArgs args)
        {
            if (args.KeyCode == Keys.Left || args.KeyCode == Keys.Right)
                args.IsInputKey = true;
        }
        private void groupAlbum_MouseEnter(object sender, EventArgs args)
        {
           groupAlbum.Focus();
            //groupAlbum.Select();
        }
        private void groupAlbum_MouseWheel(object sender, MouseEventArgs args)
        {
            
            string[] displayPic = ControlNetworkPage.DisplayPictures(ref curIndPicture, args.Delta/ 
                SystemInformation.MouseWheelScrollDelta, curAcc);
            displayPictures(displayPic);
        }
        private void groupAlbum_KeyDown(object sender, KeyEventArgs args)
        {
            string[] displayPic;
            switch (args.KeyCode)
            {
                case Keys.Left:
                    displayPic= ControlNetworkPage.DisplayPictures(ref curIndPicture, -1, curAcc);
                    displayPictures(displayPic);
                    break;
                case Keys.Right:
                    displayPic = ControlNetworkPage.DisplayPictures(ref curIndPicture, 1, curAcc);
                    displayPictures(displayPic);
                    break;
                case Keys.Delete:
                    butDelPic_Click(sender, args);
                    break;
            }
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
            labelFullName.Text = curAcc.FullName;
            float sizeOfLetter = Math.Min(20f, (panelInfo.Width - (panelInfo.Padding.Left + panelInfo.Padding.Right))*1.1f/
                labelFullName.Text.Length);
            labelFullName.Font = new Font(labelFullName.Font.Name, sizeOfLetter, FontStyle.Regular);
            dataViewPerson.DataSource = ControlNetworkPage.InfoPerson(curAcc);
        }
        private void butEditInfo_Click(object sender, EventArgs e)
        {
            editPerson.EditAcc(ref curAcc);
            FillInfo();
        }
        private void butAddPic_Click(object sender, EventArgs e)
        {
            if (loadPicDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    curIndPicture = curAcc.Pictures.Count;
                    ControlNetworkPage.AddPictures(curAcc, loadPicDialog.FileNames);
                    string[] displayPic = ControlNetworkPage.DisplayPictures(ref curIndPicture, 0, curAcc);
                    displayPictures(displayPic);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
        }

        private void butDelPic_Click(object sender, EventArgs e)
        {
            ControlNetworkPage.RemovePictures(curAcc, curIndPicture);
            string[] displayPic = ControlNetworkPage.DisplayPictures(ref curIndPicture, 0, curAcc);
            displayPictures(displayPic);
        }
    }
}
