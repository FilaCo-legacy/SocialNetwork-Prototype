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
        public static string [] DisplayPictures(ref int ind, int delta, TPerson curAcc)
        { 
            string[] paths = new string[3] { "", "", "" };
            if (curAcc.Pictures.Count == 1)
                return paths;
            ind += delta;
            ind %= curAcc.Pictures.Count;
            if (ind == 0)
            {
                if (delta < 0)
                    ind = curAcc.Pictures.Count - 1;
                else
                    ind = 1;
            }
            int prefInd = ind - 1 == 0 ? curAcc.Pictures.Count - 1 : ind - 1;
            int nextInd = ind + 1 == curAcc.Pictures.Count ? 1 : ind + 1;
            paths[0] = curAcc.Pictures[prefInd];
            paths[1] = curAcc.Pictures[ind];
            paths[2] = curAcc.Pictures[nextInd];
            if (curAcc.Pictures.Count == 2)
                paths[0] = paths[2] = "";
            if (curAcc.Pictures.Count == 3)
            {
                if (delta > 0 )
                    paths[0] = "";
                else
                    paths[2] = "";
            }
            return paths;
        }
        public static void AddPictures(TPerson curAcc, params string [] paths)
        {
            for (int i = 0; i < paths.Length; ++i)
                curAcc.AddPicture(paths[i]);
        }
        public static void RemovePictures(TPerson curAcc, int ind)
        {
            if (curAcc.Pictures.Count <= ind)
                return;
            curAcc.RemovePicture(curAcc.Pictures[ind]);
        }
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
