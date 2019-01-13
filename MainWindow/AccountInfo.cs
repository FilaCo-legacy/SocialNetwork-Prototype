using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    internal class AccountInfo
    {
        private TPerson personData;
        public TPerson PersonData { get { return personData; } }
        public string ProfilePic { get; set; }
        public AccountInfo(TPerson _personData, string _profilePic)
        {
            personData = _personData;
            ProfilePic = _profilePic;
        }
    }
}
