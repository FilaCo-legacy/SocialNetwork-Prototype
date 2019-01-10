using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MainWindow
{
    enum TGender { MAN, WOMAN }
    enum TStatus { NOT_CHOSEN, NOT_MARRIED, ENGAGED, MARRIED, IN_LOVE, COMPLICATED }
    delegate void PersonHandler(object source, PersonHandlerEventArgs args);
    class TPerson
    {
        private TJournal updates;
        public event PersonHandler PersonCharacteristicsChanged;
        public event PersonHandler PersonActionMade;
        public SortedSet<TPerson> Friends;
        public List<string> News;
        public List<string> Pictures;
        public string FullName
        {
            get { return FullName; }
            set
            {
                PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.FULLNAME_CHANGED, DateTime.Now,
                    $"Имя изменено на {value}");
                FullName = value;
                OnPersonCharacteristicsChanged(this, _args);
            }
        }
        public DateTime DateOfBirth
        {
            get { return DateOfBirth; }
            set
            {
                PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.DATEOFBIRTH_CHANGED, DateTime.Now,
                    $"Дата рождения изменена на {value}");
                DateOfBirth = value;
                OnPersonCharacteristicsChanged(this, _args);
            }
        }
        public TGender Gender
        {
            get { return Gender; }
            set
            {
                PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.GENDER_CHANGED, DateTime.Now,
                    $"Пол изменен на {value}");
                Gender = value;
                OnPersonCharacteristicsChanged(this, _args);
            }
        }
        public TStatus MaritalStatus
        {
            get { return MaritalStatus; }
            set
            {
                PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.STATUS_CHANGED, DateTime.Now,
                    $"Семейное положение изменено на {value}");
                MaritalStatus = value;
                OnPersonCharacteristicsChanged(this, _args);
            }
        }
        public string School
        {
            get { return School; }
            set
            {
                PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.SCHOOL_CHANGED, DateTime.Now,
                    $"Школа изменена на {value}");
                School = value;
                OnPersonCharacteristicsChanged(this, _args);
            }
        }
        public string HighSchool
        {
            get { return HighSchool; }
            set
            {
                PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.HIGHSCHOOL_CHANGED, DateTime.Now,
                    $"Вуз изменен на {value}");
                HighSchool = value;
                OnPersonCharacteristicsChanged(this, _args);
            }
        }
        public void AddFriend(TPerson _person)
        {
            if (Friends.Contains(_person))
                throw new Exception($"{_person.FullName} уже есть в списке друзей");
            PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.FRIEND_ADDED, DateTime.Now,
                    $"Добавлен новый друг {_person.FullName}");
            Friends.Add(_person);
            OnPersonActionMade(this, _args);
        }
        public void RemoveFriend(TPerson _person)
        {
            if (!Friends.Contains(_person))
                throw new Exception($"{_person.FullName} отсутствует в списке друзей");
            PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.FRIEND_ADDED, DateTime.Now,
        $"Удалён друг {_person.FullName}");
            Friends.Remove(_person);
            OnPersonActionMade(this, _args);
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
            return string.Format($"ФИО: {FullName};\nДата рождения: {DateOfBirth};\nПол: {Gender};\nСемейное положение: " +
                $"{MaritalStatus};\nШкола: {School};\nВуз: {HighSchool}.");
        }
        public void OnPersonCharacteristicsChanged(object source, PersonHandlerEventArgs args)
        {
            PersonCharacteristicsChanged?.Invoke(source, args);
        }
        public void OnPersonActionMade(object source, PersonHandlerEventArgs args)
        {
            PersonActionMade?.Invoke(source, args);
        }
    }
}
