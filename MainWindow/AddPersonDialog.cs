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
        public AddPersonDialog()
        {
            InitializeComponent();
            profilePicture.Location = new Point(30, 35);
            buttonChoosePicture.Location = new Point(profilePicture.Location.X + (profilePicture.Width - 
                buttonChoosePicture.Width)/2, buttonChoosePicture.Location.Y);
            labelEmptyPic.Location = new Point(profilePicture.Location.X + (profilePicture.Width -
                labelEmptyPic.Width) / 2, profilePicture.Location.Y + (profilePicture.Height -
                labelEmptyPic.Height) / 2);
        }

        private void buttonChoosePicture_Click(object sender, EventArgs e)
        {
            if (choosePicDialog.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
