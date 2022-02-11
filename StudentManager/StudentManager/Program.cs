using System;

namespace StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So luong Student");
            int n = int.Parse(Console.ReadLine());

            Student[] list = new Student[n];

            for(int i=0; i<list.Length;i++)
            {
                Console.WriteLine("Nhap thong tin hoc sinh thu {0}: ", i + 1);
                Console.Write("Nhap Ho ten");
                string name = Console.ReadLine();
                Console.Write("Nhap gioi tinh [1] Nam, [0] Nu: ");
                string sex = Console.ReadLine();
                Console.Write("Nhap ngay sinh: ");
                string birthday = Console.ReadLine();
                Console.Write("Nhap nganh hoc [1] CNTT, [2] Van, [Any key] Vat Ly: ");
                char k = char.Parse(Console.ReadLine());
                switch(k)
                {
                    case '1':
                        double c;
                        double p;
                        double s;

                        Console.Write("Nhap diem Csharp, Pascal, SQL: ");
                        c = double.Parse(Console.ReadLine());
                        p = double.Parse(Console.ReadLine());
                        s = double.Parse(Console.ReadLine());

                        list[i] = new StudentCNTT(name, sex, birthday, c, p, s);
                        break;

                    case '2':
                        double cd;
                        double hd;

                        Console.Write("Nhap diem Co dien, Hien dai: ");
                        cd = double.Parse(Console.ReadLine());
                        hd = double.Parse(Console.ReadLine());

                        list[i] = new StudentVan(name, sex, birthday, cd, hd);
                        break;

                    default:
                        double co, dien, hn, quang;

                        Console.Write("Nhap diem cac mon co, dien, hat nhan, quang: ");
                        co = double.Parse(Console.ReadLine());
                        dien = double.Parse(Console.ReadLine());
                        hn = double.Parse(Console.ReadLine());
                        quang = double.Parse(Console.ReadLine());

                        list[i] = new StudentVL(name, sex, birthday, co, dien, hn, quang);
                        break;
                }
            }

            for(int i=0; i<list.Length; i++)
            {
                Console.WriteLine("SV thu {0,2}: {1}",i+1 ,list[i]);
            }
        }
    }
}
