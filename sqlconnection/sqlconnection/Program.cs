using System;

namespace sqlconnection
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Hello World!");
            EmployeeMode obj = new EmployeeMode();
           
           
            Emprepo obj1 = new Emprepo();
            //obj1.insert();
            //obj1.delete();
            //obj1.SelectName();
            obj1.update();

        }
    }
}
