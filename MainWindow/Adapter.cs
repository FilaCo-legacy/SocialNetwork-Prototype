using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SocialNetwork
{
    class Adapter
    {
        public static string[] strGender = new string[] { "Мужской", "Женский" };
        public static string[] strMaritalStatusW = new string[] {"Не выбрано", "Не замужем", "Есть друг", "Помолвлена",
        "Замужем", "Влюблена", "Всё сложно", "В активном поиске"};
        public static string[] strMaritalStatusM = new string[] {"Не выбрано", "Не женат", "Есть подруга", "Помолвлен",
        "Женат", "Влюблён", "Всё сложно", "В активном поиске"};
        private static List<AccountInfo> accounts = new List<AccountInfo>();
        public static void AddAccount(AccountInfo nAccount)
        {
            accounts.Add(nAccount);
        }
        public static void UpdateAccount(AccountInfo oldInfo,AccountInfo nInfo)
        {

        }
    }
}
