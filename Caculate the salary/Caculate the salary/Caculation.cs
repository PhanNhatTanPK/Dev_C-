using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculate_the_salary
{
    
        public interface caculation
        {
            public void Salary();
        }
    

    public class Accounts : caculation
    {
        private int basic = 400;
        public void Salary()
        {
            Console.WriteLine("Accounts Department");
            Console.WriteLine("Salary basic*5" + basic * 5);
        }
    }

    public class HR :caculation
    {
        private int basic = 200;
        public void Salary()
        {
            Console.WriteLine("HR Department");
            Console.WriteLine("Salary basic*2" + basic * 2);
        }
    }
}
