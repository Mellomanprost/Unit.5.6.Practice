using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit._5._6.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserInfo();
            
        }

        static (string Name, string Lastname, int Age) GetUserInfo()
        {
            (string Name, string Lastname, int Age) User;

            Console.WriteLine("Введите имя пользователя: ");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию пользователя: ");
            User.Lastname = Console.ReadLine();

            Console.WriteLine("Введите возраст пользователя: ");
            User.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Есть ли у вас животные? Введите Да или Нет.");
            string checkPets = Console.ReadLine();
            if (checkPets == "Да")
                User.HasPet = true;
            else
                User.HasPet = false;

            if (User.HasPet == true)
            {
                Console.WriteLine("Введите количество животных, которые у вас есть: ");
                int numberOfPets = int.Parse(Console.ReadLine());
                GetPetsName(numberOfPets);
            }

            Console.WriteLine("Сколько у вас есть любимых цветов?");
            int numberOfFavorColor = int.Parse(Console.ReadLine());
            GetFavorColor(numberOfFavorColor);

        }

        static void CheckNUm(string age, out int num)
        {
            TryParse;
            if (age > 0)
            {

            }
        }

        static string[] GetPetsName(int num)
        {
            var arrayOfPetsName = new string[num];
            for (int i = 0; i < arrayOfPetsName.Length; i++)
            {
                Console.WriteLine("Запишите кличку животного номер {0}: ", i);
                arrayOfPetsName[i] = Console.ReadLine();
            }

            Console.WriteLine("Ваших питомцев зовут: ");
            for (int j = 0; j < arrayOfPetsName.Length; j++)
            {
                Console.Write("{0} ", arrayOfPetsName[j]);
            }
            Console.WriteLine();
            return arrayOfPetsName;
        }

        static string[] GetFavorColor(int num)
        {
            var arrayOfFavorColor = new string[num];
            for (int i = 0; i < arrayOfFavorColor.Length; i++)
            {
                Console.WriteLine("Введите ваш любимый цвет номер {0}", i);
                arrayOfFavorColor[i] = Console.ReadLine();
            }

            Console.WriteLine("Ваши любимые цвета: ");
            for (int j = 0; j < arrayOfFavorColor.Length; j++)
            {
                Console.Write("{0} ", arrayOfFavorColor[j]);
            }
            Console.WriteLine();
            return arrayOfFavorColor;
        }

        static void CheckEnteredData()
        {
            
        }
    }
}
