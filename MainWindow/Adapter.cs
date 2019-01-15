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
        private static string initialPath = @"Пользователи";
        private static DirectoryInfo mainDirectory = new DirectoryInfo(initialPath);
        public static string[] strGender = new string[] { "Мужской", "Женский" };
        public static string[] strMaritalStatusW = new string[] {"Не выбрано", "Не замужем", "Есть друг", "Помолвлена",
        "Замужем", "Влюблена", "Всё сложно", "В активном поиске"};
        public static string[] strMaritalStatusM = new string[] {"Не выбрано", "Не женат", "Есть подруга", "Помолвлен",
        "Женат", "Влюблён", "Всё сложно", "В активном поиске"};
        private static List<AccountInfo> accounts = new List<AccountInfo>();
        public static void AddAccount(AccountInfo nAccount)
        {
            accounts.Add(nAccount);
            if (!mainDirectory.Exists)
                mainDirectory.Create();
            mainDirectory.CreateSubdirectory($@"{nAccount.PersonData.FullName}\Pictures");
            if (nAccount.ProfilePic != "")
            {
                using (FileStream fs = new FileStream(nAccount.ProfilePic, FileMode.Open))
                {
                    Bitmap tmp = new Bitmap(fs);
                    tmp.Save($@"{nAccount.PersonData.FullName}\Pictures\Avatar.bmp");
                }
            }
        }
        public static void UpdateAccount(AccountInfo oldInfo,AccountInfo nInfo)
        {
        }
    }
}
