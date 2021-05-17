using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Console.WriteLine("----------------------------------");

            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            employeeManager.Update();

            Console.WriteLine("----------------------------------");

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);

        }
        
        interface IPersonManager
        {
            public void Add();
            public void Update();
        }

        class CustomerManager:IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Musteri Eklendi!");
            }

            public void Update()
            {
                Console.WriteLine("Musteri Guncellendi!");
            }
        }

        class EmployeeManager:IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Personel Eklendi!");
            }

            public void Update()
            {
                Console.WriteLine("Personel Guncellendi!");
            }
        }


        class ProjectManager
        {
            public void Add(IPersonManager personManager)
            {
                personManager.Add();
            }

        }
    }
}
