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
    public partial class SocialNetworkWindow : Form
    {
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
    }
}
