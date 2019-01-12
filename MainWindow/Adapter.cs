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
        private static List<TPerson> accounts = new List<TPerson>();
        public static void AddAccount(TPerson nAccount)
        {
            accounts.Add(nAccount);
        }
        public static  DataTable InfoPerson(TPerson source)
        {
            DataTable tab = new DataTable();
            DataColumn field = new DataColumn("Поле", typeof(string));
            DataColumn value = new DataColumn("Значение", typeof(string));
            tab.Columns.AddRange(new DataColumn[] { field, value });
            DataRow rowDateOfBirth = tab.NewRow();
            DataRow rowGender = tab.NewRow();
            DataRow rowMaritalStatus = tab.NewRow();
            if (source.School != "")
            {
                DataRow rowSchool = tab.NewRow();
                rowSchool.ItemArray = new object[] { "Школа", source.School };
            }
            if (source.HighSchool != "")
            {
                DataRow rowHighSchool = tab.NewRow();
                rowHighSchool.ItemArray = new object[] { "Вуз", source.HighSchool };
            }
            rowDateOfBirth.ItemArray = new object[] { "Дата рождения", source.DateOfBirth.ToLongDateString() };
            rowGender.ItemArray = new object[] { "Пол", strGender[(int)source.Gender] };
            if (source.Gender == TGender.MAN)
                rowMaritalStatus.ItemArray = new object[] { "Семейное положение", strMaritalStatusM[(int)source.MaritalStatus] };
            else
                rowMaritalStatus.ItemArray = new object[] { "Семейное положение", strMaritalStatusW[(int)source.MaritalStatus] };
            return tab;
        }
    }
}
