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
            addPerson = new AddPerson();
        }
        
        private void toolExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolAddPerson_Click(object sender, EventArgs e)
        {
            TPerson nAccount = addPerson.GetInfoNewAcc();
            if (nAccount != null)
            {
                Adapter.AddAccount(nAccount);
                tabsNetwork.TabPages.Add(nAccount.FullName);
                NetworkPage np = new NetworkPage(nAccount, tabsNetwork.TabPages[tabsNetwork.TabPages.Count - 1]);
                np.Dock = DockStyle.Fill;
                tabsNetwork.TabPages[tabsNetwork.TabPages.Count - 1].Controls.Add(np);
                tabsNetwork.SelectedTab = tabsNetwork.TabPages[tabsNetwork.TabPages.Count - 1];
            }
        }


    }
}
