using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.Data
{
    class DataSource
    {
        private static DataSource instance;
        public QLBHDTEntities1 DB { get; set; }

        public static DataSource Instance
        { 
            get 
            { 
                if (instance == null)
                    instance = new DataSource(); 
                return instance; 
            }
            set 
            {
                instance = value; 
            } 
        }

        private DataSource()
        {
            DB = new QLBHDTEntities1();
        }
    }
}
