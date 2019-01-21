﻿using System;
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
        public event PersonHandler PersonCharacteristicsChanged;
        public event PersonHandler PersonActionMade;
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
                OnPersonCharacteristicsChanged(this, _args);
            }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.DATEOFBIRTH_CHANGED, DateTime.Now,
                    $"Дата рождения изменена на {value}");
                dateOfBirth = value;
                OnPersonCharacteristicsChanged(this, _args);
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
                OnPersonCharacteristicsChanged(this, _args);
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
                OnPersonCharacteristicsChanged(this, _args);
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
                OnPersonCharacteristicsChanged(this, _args);
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
                OnPersonCharacteristicsChanged(this, _args);
            }
        }
        public string ProfilePic
        {
            get { return Pictures[0]; }
            set { Pictures[0] = value; }
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
            PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.FRIEND_DELETED, DateTime.Now,
        $"Удалён друг {_person.FullName}");
            Friends.Remove(_person);
            OnPersonActionMade(this, _args);
        }
        public void AddNews(string txt)
        {
            PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.NEWS_ADDED, DateTime.Now,
                    $"Добавлена новая новость \"{txt}\"");
            News.Add(txt);
            OnPersonActionMade(this, _args);
        }
        public void RemoveNews(string txt)
        {
            if (!News.Contains(txt))
                throw new Exception($"{txt} - этой новости нет в списке новостей");
            PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.NEWS_DELETED, DateTime.Now,
                    $"Удалена новость \"{txt}\"");
            News.Remove(txt);
            OnPersonActionMade(this, _args);
        }
        public void AddPicture(string fileName)
        {
            PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.PICTURE_ADDED, DateTime.Now,
        $"Добавлена новая картинка \"{fileName}\"");
            Pictures.Add(fileName);
            OnPersonActionMade(this, _args);
        }
        public void RemovePicture(string fileName)
        {
            if (!Pictures.Contains(fileName) || Pictures.Count == 1)
                return;
            PersonHandlerEventArgs _args = new PersonHandlerEventArgs(FullName, TMessage.PICTURE_DELETED, DateTime.Now,
       $"Удалена картинка \"{fileName}\"");
            Pictures.Remove(fileName);
            OnPersonActionMade(this, _args);
        }
        public void OnPersonCharacteristicsChanged(object source, PersonHandlerEventArgs args)
        {
            PersonCharacteristicsChanged?.Invoke(source, args);
        }
        public void OnPersonActionMade(object source, PersonHandlerEventArgs args)
        {
            PersonActionMade?.Invoke(source, args);
        }

        public int CompareTo(TPerson other)
        {
            return fullName.CompareTo(other.FullName);
        }
    }
}
