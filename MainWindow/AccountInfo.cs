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
        private string profilePic;
        public TPerson PersonData { get { return personData; } }
        public string ProfilePic { get { return profilePic; } }
        public AccountInfo(TPerson _personData, string _profilePic)
        {
            personData = _personData;
            profilePic = _profilePic;
        }
    }
}
