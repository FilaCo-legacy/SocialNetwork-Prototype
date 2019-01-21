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
    public partial class AddFriendDialog : Form
    {
        public string GetChoice
        {
            get
            {
                if (comboBoxPeople.Items.Count == 0)
                    throw new Exception("Непредвиденная ошибка: список возможных друзей был пуст");
                return (string)comboBoxPeople.Items[comboBoxPeople.SelectedIndex];
            }
        }
        public AddFriendDialog()
        {
            InitializeComponent();
        }
        public DialogResult ShowDialog(TPerson sender, List<TPerson> curAccs)
        {
            comboBoxPeople.Items.Clear();
            var res = from tmp in curAccs
                      where tmp.FullName != sender.FullName && !sender.Friends.Contains(tmp)
                     orderby tmp.FullName
                      select tmp.FullName;
            comboBoxPeople.Items.AddRange(res.ToArray());
            return ShowDialog();
        }
    }
}
