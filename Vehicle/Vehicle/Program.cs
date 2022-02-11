using System;

namespace Vehicle
{
    class Program
    {
        class vehicle //Lớp vehicle
        {
            protected string type;  //Thuộc tính của lớp vehicle
            protected string color; //Thuộc tính của lớp vehicle
            protected double speed; //Thuộc tính của lớp vehicle
            protected string brand; //Thuộc tính của lớp vehicle

            // Phương thức run là phương thức virtual
            public virtual void run()
            {
                Console.WriteLine("I'm running "); //In ra màn hình dong chữ I'm running
            }

            // Phương thức hiển thị
            public void display()
            {
                Console.WriteLine("Type: " + type);     
                Console.WriteLine("Color: " + color);
                Console.WriteLine("Speed: " + speed);
                Console.WriteLine("Brand: " + brand);
            }
        }

        // Lớp Car kế thừa lớp vehicle
        class Car : vehicle
        {

            // Phương thức khởi tạo
            public Car(string t, string c, double s, string b)
            {
                type = t;
                color = c;
                speed = s;
                brand = b;
            }

            // Ghi đè phương thức run của lớp vehicle
            public override void run()
            {
                Console.WriteLine("The Car is running");
            }


        }
        static void Main(string[] args)
        {
            Car xe = new Car("Car", "Blue", 180, "BMW");// Tạo đối tượng của lớp Car
            xe.display(); //Hiển thị thông tin của xe
            xe.run();    //Sử dụng phương thức run
        }
    }
}
