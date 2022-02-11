using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Student
    {
        protected string Name;
        protected bool Sex = true;
        protected DateTime Birthday;

        public Student(string n, string s, string b)
        {
            Name = n;
            s = s.Trim().ToUpper();
            Sex = (s == "NAM" || s == "MALE" || s == "1");
            try
            {
                Birthday = DateTime.Parse(b);
            }
            catch(Exception ex)
            {
                Birthday = DateTime.Today;
            }
        }

        public virtual double DTB() 
        {
            return 0;
        }

        public override string ToString()
        {
            return string.Format("{0,30}, {1}, {2}, {3:0.00}",Name,Sex,Birthday,this.DTB());
        }
    }
}
