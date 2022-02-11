using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class StudentVan : Student
    {
        private double CoDien;
        private double HienDai;

        public StudentVan(string n, string s, string b, double cd, double hd):base(n,s,b)
        {
            CoDien = cd;
            HienDai = hd;
        }

        public override double DTB()
        {
            return (CoDien+HienDai)/2;
        }
    }
}
