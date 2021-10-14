using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassUML
{
    class Student : Person
    {
        public string program { get; set; }

        public int year { get; set; }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;

        }
        public Student() : base() {

        }

        public override string ToString()
        {
            return base.ToString() + $"Program: {program} Year {year} Fee {fee}";
        }


    }

}


    



