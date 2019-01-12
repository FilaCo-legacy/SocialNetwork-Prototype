using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class Adapter
    {
        public static string[] strGender = new string[] { "Мужской", "Женский" };
        public static string[] strMaritalStatusW = new string[] {"Не выбрано", "Не замужем", "Есть друг", "Помолвлена",
        "Замужем", "Влюблена", "Всё сложно", "В активном поиске"};
        public static string[] strMaritalStatusM = new string[] {"Не выбрано", "Не женат", "Есть подруга", "Помолвлен",
        "Женат", "Влюблён", "Всё сложно", "В активном поиске"};
        private static List<TPerson> accs;
        public static void AddAccount(TPerson nAccount)
        {
            accs.Add(nAccount);
        }
    }
}
