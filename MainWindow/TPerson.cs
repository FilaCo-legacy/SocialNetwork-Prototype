using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MainWindow
{
    enum TGender { MAN, WOMAN }
    enum TStatus { NOT_CHOSEN, NOT_MARRIED, ENGAGED, MARRIED, IN_LOVE, COMPLICATED}
    delegate void PersonHandler(object source, PersonHandlerEventArgs args);
    class TPerson
    { 
        private TJournal updates;
        public event PersonHandler PersonCharacteristicsChanged;
        public event PersonHandler PersonActionMade;
        public SortedSet<TPerson> Friends;
        public List<string> News;
        public List<string> Pictures;
        public string FullName { get; set;}
        public DateTime DateOfBirth { get; set; }
        public TGender Gender { get; set; }
        public TStatus MaritalStatus { get; set; }
        public string School { get; set; }
        public string HighSchool { get; set; }
        public void AddFriend(TPerson _person)
        {
            if (Friends.Contains(_person))
                throw new Exception($"{_person.FullName} уже есть в списке друзей");
            Friends.Add(_person);
        }
        public void RemoveFriend(TPerson _person)
        {
            if (!Friends.Contains(_person))
                throw new Exception($"{_person.FullName} отсутствует в списке друзей");
            Friends.Remove(_person);
        }
        public void AddNews(string txt)
        {
            News.Add(txt);
        }
        public void RemoveNews(string txt)
        {
            if (!News.Contains(txt))
                throw new Exception($"{txt} - этой новости нет в списке новостей");
            News.Remove(txt);
        }
        public void AddPicture(string fileName)
        {
            Pictures.Add(fileName);
        }
        public void RemovePicture(string fileName)
        {
            if (!Pictures.Contains(fileName))
                throw new Exception($"{fileName} - этой картинки нет в списке картинок");
            Pictures.Remove(fileName);
        }
        public override string ToString()
        {
            return FullName;
        }
        public void OnPersonCharacteristicsChanged(object source, PersonHandlerEventArgs args)
        {
            if (PersonCharacteristicsChanged == null)
                throw new Exception("На событие не было подписано ни одного действия");
            PersonCharacteristicsChanged(source, args);
        }
        public void OnPersonActionMade(object source, PersonHandlerEventArgs args)
        {
            if (PersonActionMade == null)
                throw new Exception("На событие не было подписано ни одного действия");
            PersonActionMade(source, args);
        }
    }
}
