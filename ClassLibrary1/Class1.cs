using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenSportSchool
{
    /// <summary>
    /// Направление школы
    /// </summary>
    public class SportTypeSchool
    {
        /// <summary>
        /// Имя
        /// </summary>
        public SportType SportType { get; set; }
        /// <summary>
        /// Фотография
        /// </summary>
        public byte[] Photo { get; set; }
        /// <summary>
        /// Дата проведения
        /// </summary>
        public DateTime TimePractice { get; set; }
        /// <summary>
        ///  Место проведения
        /// </summary>
        public string Place{ get; set; }
        /// <summary>
        /// ФИО ответсвенного
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Учителя
        /// </summary>
        public List<Teacher> Teacher { get; set; }
    }

    /// <summary>
    /// Преподаватель
    /// </summary>
    public class Teacher
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string NameTeacher { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BithdayTeacher { get; set; }
        /// <summary>
        /// Образование
        /// </summary>
        public string Education { get; set; }

        public override string ToString()
        {
            return $"ФИО: {NameTeacher}, Д.р.: {BithdayTeacher}, Образование: {Education}";
        }
    }

    /// <summary>
    /// Ученики
    /// </summary>
    public class Students
    {
        /// <summary>
        /// ФИО учащегося
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// Место обучения
        /// </summary>
        public string PlaceEducation { get; set; }
        /// <summary>
        /// Учителя
        /// </summary>
        public List<Teacher> Teacher { get; private set; }

        public override string ToString()
        {
            return $"ФИО учащегося: {Name}, Дата рождения:{Birthday} , Место обучения: {PlaceEducation}";
        }
    }

    /// <summary>
    /// Тип направления
    /// </summary>
    public enum SportType
    {
        /// <summary>
        /// Баскетбол
        /// </summary>
        Basketball,
        /// <summary>
        /// Футбол
        /// </summary>
        Football,
        /// <summary>
        /// Плавание
        /// </summary>
        Swimming,
        /// <summary>
        /// Художественная гимнастика
        /// </summary>
        Gymnastics,
        /// <summary>
        /// Легкая атлетика
        /// </summary>
        Athletics,
        /// <summary>
        /// Бадминтон
        /// </summary>
        Badminton,
        /// <summary>
        /// Водное поло
        /// </summary>
        Polo,
        /// <summary>
        /// Гребля
        /// </summary>
        Rowing,
        /// <summary>
        /// Подводное плавание
        /// </summary>
        Diving,
        /// <summary>
        /// Современные танцы
        /// </summary>
        Dance,
        /// <summary>
        /// Чирлидинг
        /// </summary>
        Cheerliding,
    }
}


