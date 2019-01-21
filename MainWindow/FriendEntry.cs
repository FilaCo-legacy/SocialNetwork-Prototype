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
            else
                picProfileUser.Image = GetRoundedPic(new Bitmap(Properties.Resources.EmptyProfilePic, picProfileUser.Size));
            GotFocus += FriendEntry_GotFocus;
            picProfileUser.GotFocus += FriendEntry_GotFocus;
            labelFirstName.GotFocus += FriendEntry_GotFocus;
            labelMidName.GotFocus += FriendEntry_GotFocus;
            labelLastName.GotFocus += FriendEntry_GotFocus;
            LostFocus += FriendEntry_LostFocus;
        }

        private void FriendEntry_LostFocus(object sender, EventArgs e)
        {
            BackColor = Color.AliceBlue;
        }

        private void FriendEntry_GotFocus(object sender, EventArgs e)
        {
            BackColor = Color.DeepSkyBlue;
        }

        private Bitmap GetRoundedPic(Bitmap oldPic)
        {
            Bitmap bmp = new Bitmap(picProfileUser.Width, picProfileUser.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                using (Brush br = new TextureBrush(oldPic))
                {
                    g.FillEllipse(br, 0, 0, bmp.Width, bmp.Height);
                }
            }
            return bmp;
        }
        private Bitmap GetRoundedPic(string path)
        {
            Bitmap bmp = new Bitmap(picProfileUser.Width, picProfileUser.Height);
            Bitmap sourceImg = new Bitmap(Image.FromFile(path), bmp.Size);
            int Radius = bmp.Width;
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                using (Brush br = new TextureBrush(sourceImg))
                {
                    using (GraphicsPath gp = new GraphicsPath())
                    {
                        gp.AddArc(0, 0, Radius, Radius, 180, 90);
                        gp.AddArc(sourceImg.Width - Radius - 0, 0, Radius, Radius, 270, 90);
                        gp.AddArc(0 + sourceImg.Width - Radius, 0 + sourceImg.Height - Radius, Radius, Radius, 0, 90);
                        gp.AddArc(0, sourceImg.Height - Radius, Radius, Radius, 90, 90);

                        g.FillPath(br, gp);
                    }
                }
            }
            return bmp;
        }
    }
}
