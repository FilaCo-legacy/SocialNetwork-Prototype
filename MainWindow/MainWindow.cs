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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
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
