using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample1
{
    class Student
    {
        public string Speciality { get; set; }
        public int FNumber { get; set; }

        public Student(string speciality,int fnumber)
        {
            Speciality = speciality;
            FNumber = fnumber;
        }
        public override string ToString()
        {
            return "Speciality:" + Speciality + "  FNumber:" + FNumber;
        }
        public int CompareTo(Student other)
        {
            return this.FNumber.CompareTo(other.FNumber);
        }
    }
}
