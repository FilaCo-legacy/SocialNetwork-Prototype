using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class Adapter
    {
        private static List<TPerson> accs;
        public static void AddAccount(TPerson nAccount)
        {
            accs.Add(nAccount);
        }
    }
}
