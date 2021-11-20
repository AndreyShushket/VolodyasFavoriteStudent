using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_static_stuff
{
    class Student
    {
        private string surname { get; set; }

        private string name { get; set; }

        private string patronymic { get; set; }

        private int group { get; set; }

        private int age { get; set; }

        List<int> marksAdministration = new List<int>();
        List<int> marksPrograming = new List<int>();
        List<int> marksDisign = new List<int>();
        public Student(string surname, string name, string patronymic, int group, int age)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.group = group;
            this.age = age;
        }

        public void AddMark(int mark, string subject)
        {
            if(subject == "Admin")
            {
                marksAdministration.Add(mark);
            }
            else if(subject == "Program")
            {
                marksPrograming.Add(mark);
            }
            else if(subject == "Disign")
            {
                marksDisign.Add(mark);
            }
        }

        public int СalculateScoreForSubject(string subject)
        {
            if (subject == "administration")
            {
                return marksAdministration.ToArray().Sum();
            }
            else if (subject == "programing")
            {
                return marksPrograming.ToArray().Sum();
            }
            else if (subject == "disign")
            {
                return marksDisign .ToArray().Sum();
            }
            else
            {
                Console.WriteLine("No sub");
                return 0;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Student name is {name}, surname is {surname}, patronymic is {patronymic}, in group №{group}, age is {age}, his avarage score {СalculateScoreForSubject("Admin")} in administration, {СalculateScoreForSubject("Program")} in programing, {СalculateScoreForSubject("Disign")} in disign");
        }
    }
}
