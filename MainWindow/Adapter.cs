using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace SocialNetwork
{
    class Adapter
    {
        public static string[] strGender = new string[] { "Мужской", "Женский" };
        public static string[] strMaritalStatusW = new string[] {"Не выбрано", "Не замужем", "Есть друг", "Помолвлена",
        "Замужем", "Влюблена", "Всё сложно", "В активном поиске"};
        public static string[] strMaritalStatusM = new string[] {"Не выбрано", "Не женат", "Есть подруга", "Помолвлен",
        "Женат", "Влюблён", "Всё сложно", "В активном поиске"};
        private static List<TPerson> accounts = new List<TPerson>();
        public static List<TPerson> GetPeople { get { return accounts; } }
        public static void AddAccount(TPerson nAccount)
        {
            accounts.Add(nAccount);
        }
        public static void AddNews(TPerson acc, string txt)
        {
            acc.AddNews(txt);
        }
        public static bool IsPossibleToAddSomeone(TPerson sender)
        {
            return (from tmp in accounts
                    where tmp.FullName != sender.FullName && !sender.Friends.Contains(tmp)
                    select tmp).Count() > 0;
        }
        public static void AddFriend(TPerson sender, string fullNameFriend)
        {
            TPerson nFriend = accounts.Find(x => x.FullName == fullNameFriend);
            sender.AddFriend(nFriend);
            sender.SignOnUpdates(nFriend);
        }
        public static void RemoveFriend(TPerson sender, string fullNameFriend)
        {
            TPerson nFriend = accounts.Find(x => x.FullName == fullNameFriend);
            sender.RemoveFriend(nFriend);
        }
    }
}
