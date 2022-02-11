using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class StudentVL : Student
    {
        private double Co;
        private double Dien;
        private double HatNhan;
        private double Quang;

        public StudentVL(string n, string s, string b, double c, double d,double hn, double q):base(n,s,b)
        {
            Co = c;
            Dien = d;
            HatNhan = hn;
            Quang = q;
        }

        public override double DTB()
        {
            return (Co + Dien + HatNhan + Quang) / 4;
        }
    }
}
