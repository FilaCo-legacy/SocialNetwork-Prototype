using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SocialNetwork
{
    public enum TGender { MAN, WOMAN }
    public enum TStatus { NOT_CHOSEN, NOT_MARRIED, IN_RELATIONSHIP, ENGAGED, MARRIED, IN_LOVE, COMPLICATED, IN_ACTIVE_SEARCH }
    public delegate void PersonHandler(object source, PersonHandlerEventArgs args);
    public class TPerson : IComparable<TPerson>
    {
        private TJournal updates;
        private string fullName;
        private DateTime dateOfBirth;
        private TGender gender;
        private TStatus maritalStatus;
        private string school;
        private string highSchool;
        public event PersonHandler PersonChanged;
        internal TJournal GetLog { get { return updates; } }
        public SortedSet<TPerson> Friends;
        public List<string> News;
        public List<string> Pictures;
        public string FullName
        {
            get { return fullName; }
            set
            {
                PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.FULLNAME_CHANGED, DateTime.Now,
                    $"Имя изменено на {value}");
                fullName = value;
                OnPersonChanged(this, _args);
            }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (dateOfBirth != value)
                {
                    PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.DATEOFBIRTH_CHANGED, DateTime.Now,
                        $"Дата рождения изменена на {value}");
                    dateOfBirth = value;
                    OnPersonChanged(this, _args);
                    if (DateTime.Now.Day == dateOfBirth.Day && DateTime.Now.Month == dateOfBirth.Month)
                    {
                        PersonHandlerEventArgs _argsBirthday = new PersonHandlerEventArgs(FullName, TMessage.BIRTHDAY, DateTime.Now,
                        $"Сегодня отмечает день рождения!");
                        OnPersonChanged(this, _argsBirthday);
                    }
                }              
            }
        }
        public TGender Gender
        {
            get { return gender; }
            set
            {
                PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.GENDER_CHANGED, DateTime.Now,
                    $"Пол изменен на {value}");
                gender = value;
                OnPersonChanged(this, _args);
            }
        }
        public TStatus MaritalStatus
        {
            get { return maritalStatus; }
            set
            {
                PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.STATUS_CHANGED, DateTime.Now,
                    $"Семейное положение изменено на {value}");
                maritalStatus = value;
                OnPersonChanged(this, _args);
            }
        }
        public string School
        {
            get { return school; }
            set
            {
                PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.SCHOOL_CHANGED, DateTime.Now,
                    $"Школа изменена на {value}");
                school = value;
                OnPersonChanged(this, _args);
            }
        }
        public string HighSchool
        {
            get { return highSchool; }
            set
            {
                PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.HIGHSCHOOL_CHANGED, DateTime.Now,
                    $"Вуз изменен на {value}");
                highSchool = value;
                OnPersonChanged(this, _args);
            }
        }
        public string ProfilePic
        {
            get { return Pictures[0]; }
            set
            {
                if (Pictures[0] != value)
                {
                    PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.PROFILE_PIC_CHANGED, DateTime.Now,
                           $"Изменена фотография профиля: {value}");
                    Pictures[0] = value;
                    OnPersonChanged(this, _args);
                }
            }
        }
        public TPerson(string _fullName, DateTime _dateOfBirth, TGender _gender, TStatus _maritalStatus, string _school, 
            string _highSchool)
        {
            FullName = _fullName;
            DateOfBirth = _dateOfBirth;
            Gender = _gender;
            MaritalStatus = _maritalStatus;
            School = _school;
            HighSchool = _highSchool;
            updates = new TJournal();
            Friends = new SortedSet<TPerson>();
            News = new List<string>();
            Pictures = new List<string>();
            Pictures.Add("");
            //PersonChanged += updates.OnPersonChanged;
        }
        public void AddFriend(TPerson _person)
        {
            if (Friends.Contains(_person))
                throw new Exception($"{_person.FullName} уже есть в списке друзей");
            PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.FRIEND_ADDED, DateTime.Now,
                    $"Добавлен новый друг {_person.FullName}");
            Friends.Add(_person);
            OnPersonChanged(this, _args);
            if (DateTime.Now.Day == _person.DateOfBirth.Day && DateTime.Now.Month == _person.DateOfBirth.Month)
            {
                PersonHandlerEventArgs _argsBirthday = new PersonHandlerEventArgs(_person.FullName, TMessage.BIRTHDAY, DateTime.Now,
                $"Сегодня отмечает день рождения!");
                _person.OnPersonChanged(_person, _argsBirthday);
            }
        }
        public void RemoveFriend(TPerson _person)
        {
            if (!Friends.Contains(_person))
                throw new Exception($"{_person.FullName} отсутствует в списке друзей");
            PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.FRIEND_DELETED, DateTime.Now,
        $"Удалён друг {_person.FullName}");
            Friends.Remove(_person);
            OnPersonChanged(this, _args);
        }
        public void AddNews(string txt)
        {
            PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.NEWS_ADDED, DateTime.Now,
                    $"Добавлена новая новость \"{txt}\"");
            News.Add(txt);
            OnPersonChanged(this, _args);
        }
        public void RemoveNews(string txt)
        {
            if (!News.Contains(txt))
                throw new Exception($"{txt} - этой новости нет в списке новостей");
            PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.NEWS_DELETED, DateTime.Now,
                    $"Удалена новость \"{txt}\"");
            News.Remove(txt);
            OnPersonChanged(this, _args);
        }
        public void AddPicture(string fileName)
        {
            PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.PICTURE_ADDED, DateTime.Now,
        $"Добавлена новая картинка \"{fileName}\"");
            Pictures.Add(fileName);
            OnPersonChanged(this, _args);
        }
        public void RemovePicture(string fileName)
        {
            if (!Pictures.Contains(fileName) || Pictures.Count == 1)
                return;
            PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.PICTURE_DELETED, DateTime.Now,
       $"Удалена картинка \"{fileName}\"");
            Pictures.Remove(fileName);
            OnPersonChanged(this, _args);
        }
        public void OnPersonChanged(object source, PersonHandlerEventArgs args)
        {
            PersonChanged?.Invoke(source, args);
        }
        internal void SignOnUpdates(TPerson person)
        {
            person.PersonChanged += updates.OnPersonChanged;
        }
        internal void UnSignFromUpdates(TPerson person)
        {
            person.PersonChanged -= updates.OnPersonChanged;
        }
        public int CompareTo(TPerson other)
        {
            return fullName.CompareTo(other.FullName);
        }
    }
}
