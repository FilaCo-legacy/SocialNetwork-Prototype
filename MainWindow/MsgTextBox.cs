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
    public partial class MsgTextBox : UserControl
    {
        private string cacheTxt = "";
        private const string STR_FILL = "Что у Вас нового?";
        public string MsgText { get { return textMsg.Text; } }
        public MsgTextBox()
        {
            InitializeComponent();
            butSend.Hide();
            textMsg.LostFocus += textMsg_LostFocus;
            textMsg.GotFocus += textMsg_GotFocus;
            
        }
        public void ClearCache()
        {
            textMsg_LostFocus(this, null);
            cacheTxt = "";
        }
        private void textMsg_GotFocus(object sender, EventArgs e)
        {
            Height = MaximumSize.Height;
            textMsg.Text = cacheTxt;
            textMsg.ForeColor = Color.Black;
            butSend.Show();
        }

        private void textMsg_LostFocus(object sender, EventArgs e)
        {
            if (butSend.Focused)
                return;
            Height = MinimumSize.Height;
            cacheTxt = textMsg.Text;
            textMsg.Text = STR_FILL;
            textMsg.ForeColor = Color.DarkGray;
            butSend.Hide();
        }

    }
}
