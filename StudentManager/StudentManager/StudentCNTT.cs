using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class StudentCNTT : Student
    {
        private double Csharp;
        private double Pascal;
        private double SQL;

        public StudentCNTT(string n, string s,string b,double c,double p,double sql): base( n, s, b)
        {
            Csharp = c;
            Pascal = p;
            SQL = sql;
        }

        public override double DTB()
        {
            return (Csharp+Pascal+SQL)/3;
        }
    }
}
