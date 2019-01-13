using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Drawing;

namespace SocialNetwork
{
    class ControlNetworkPage
    {
        public static DataTable InfoPerson(TPerson source)
        {
            DataTable tab = new DataTable();
            DataColumn field = new DataColumn("Поле", typeof(string));
            DataColumn value = new DataColumn("Значение", typeof(string));
            tab.Columns.AddRange(new DataColumn[] { field, value });
            DataRow rowDateOfBirth = tab.NewRow();
            DataRow rowGender = tab.NewRow();
            rowDateOfBirth.ItemArray = new object[] { "Дата рождения:", source.DateOfBirth.ToLongDateString() };
            rowGender.ItemArray = new object[] { "Пол:", Adapter.strGender[(int)source.Gender] };
            tab.Rows.Add(rowDateOfBirth);
            tab.Rows.Add(rowGender);
            if (source.MaritalStatus != TStatus.NOT_CHOSEN)
            {
                DataRow rowMaritalStatus = tab.NewRow();
                if (source.Gender == TGender.MAN)
                    rowMaritalStatus.ItemArray = new object[] { "Семейное положение:", Adapter.strMaritalStatusM[(int)source.MaritalStatus] };
                else
                    rowMaritalStatus.ItemArray = new object[] { "Семейное положение:", Adapter.strMaritalStatusW[(int)source.MaritalStatus] };
                tab.Rows.Add(rowMaritalStatus);
            }
            if (source.School != "")
            {
                DataRow rowSchool = tab.NewRow();
                rowSchool.ItemArray = new object[] { "Школа:", source.School };
                tab.Rows.Add(rowSchool);
            }
            if (source.HighSchool != "")
            {
                DataRow rowHighSchool = tab.NewRow();
                rowHighSchool.ItemArray = new object[] { "Вуз:", source.HighSchool };
                tab.Rows.Add(rowHighSchool);
            }
            return tab;
        }
        public static Bitmap LoadPic(string path, Size destSize)
        {
            Bitmap bmp = null;
            if (path != "")
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    bmp = new Bitmap(fs);
                    bmp = new Bitmap(bmp, destSize);
                }
            }
            return bmp;
        }
    }
}
