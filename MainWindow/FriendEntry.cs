using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SocialNetwork
{
    public partial class FriendEntry : UserControl
    {
        public string GetUserName { get { return string.Format($"{labelLastName.Text} {labelFirstName.Text} {labelMidName.Text}"); } }
        public FriendEntry(TPerson user)
        {
            InitializeComponent();
            string[] partName = user.FullName.Split(' ');
            labelLastName.Text = partName[0];
            labelFirstName.Text = partName[1];
            labelMidName.Text = partName[2];
            if (user.ProfilePic != "")
                picProfileUser.Image = GetRoundedPic(user.ProfilePic);
        }
        private Bitmap GetRoundedPic(string path)
        {
            Bitmap bmp = new Bitmap(picProfileUser.Width, picProfileUser.Height);
            Bitmap sourceImg = new Bitmap(Image.FromFile(path));
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                using (Brush br = new TextureBrush(sourceImg))
                {
                    g.FillEllipse(br, 0,0, bmp.Width, bmp.Height);
                }
            }
            return bmp;
        }
    }
}
