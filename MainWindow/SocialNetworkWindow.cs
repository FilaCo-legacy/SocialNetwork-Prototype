using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SocialNetwork
{
    public partial class SocialNetworkWindow : Form
    {
        [DllImport("user32.dll")]
        private extern static IntPtr SetFocus(IntPtr hWnd);
        public SocialNetworkWindow()
        {
            InitializeComponent();
            addPerson = new AddPersonDialog();
            
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolAddPerson_Click(object sender, EventArgs e)
        {
            TPerson nAccount = addPerson.GetInfoNewAcc();
            if (nAccount != null)
                Adapter.AddAccount(nAccount);
        }

        private void textPersonInfo_Click(object sender, EventArgs e)
        {
            SetFocus(IntPtr.Zero);
        }
    }
}
