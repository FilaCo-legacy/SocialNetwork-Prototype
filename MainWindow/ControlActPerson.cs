using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing;

namespace SocialNetwork
{
    class ControlActPerson
    {
        private static Regex regExpNames = new Regex(@"^([А-Я][а-я]{1,20}|[A-Z][a-z]{1,20})$");
        private static Size PIC_SIZE = new Size(100, 100);
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
        public static bool CheckNameRegex(string txt)
        {
            txt = txt.Trim();
            return regExpNames.IsMatch(txt);
        }
        public static string CheckInputName(string txt)
        {
            for (int i = 0; i < txt.Length; ++i)
            {
                if ((txt[i] < 'a' || txt[i] > 'z') && (txt[i] < 'A' || txt[i] > 'Z') && (txt[i] < 'а' || txt[i] > 'я') &&
                    (txt[i] < 'А' || txt[i] > 'Я'))
                {
                    txt = txt.Remove(i, 1);
                    break;
                }
            }
            return txt;
        }
    }
}
