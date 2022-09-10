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
            (string Name, string Lastname, int Age, bool HasPets, string[] PetsNames, string[] FavColors) UserData;
            GetUserInfo(out UserData);
            ShowUserData(UserData);
            
        }

        static (string Name, string Lastname, int Age, bool HasPets, string[] PetsNames, string[] FavColors) GetUserInfo(out (string Name, string Lastname, int Age, bool HasPets, string[] PetsNames, string[] FavColors) UserInfo)
        {
            (string Name, string Lastname, int Age, bool HasPets, string[] PetsNames, string[] FavColors) User;

            string inputname;
            string username;
            do
            {
                Console.WriteLine("Введите имя пользователя: ");
                inputname = Console.ReadLine();

            } while (CheckInpValue(inputname, out username));
            User.Name = username;

            string inputlastname;
            string lastname;
            do
            {
                Console.WriteLine("Введите фамилию пользователя: ");
                inputlastname = Console.ReadLine();
            } while (CheckInpValue(inputlastname, out lastname));
            User.Lastname = lastname;

            string age;
            int intage;
            do
            {
                Console.WriteLine("Введите возраст пользователя: ");
                age = Console.ReadLine();

            } while (CheckNum(age, out intage));
            User.Age = intage;

            Console.WriteLine("Есть ли у вас животные? \n(Введите Да или Нет):");
            string checkPets = Console.ReadLine();
            if (checkPets == "Да")
                User.HasPets = true;
            else
                User.HasPets = false;

            if (User.HasPets == true)
            {
                string[] arraypets;
                int numberofpets;
                do
                {
                    Console.WriteLine("Введите количество животных, которые у вас есть: ");

                } while (CheckNum(Console.ReadLine(), out numberofpets));
                GetArrayWithPets(numberofpets, out arraypets);
                User.PetsNames = arraypets;
            }
            else 
            {
                User.PetsNames = null;
            }

            string[] arrayfavcolors;
            int numoffavcolor;
            do
            {
                Console.WriteLine("Сколько у вас есть любимых цветов?");

            } while (CheckNum(Console.ReadLine(), out numoffavcolor));
            WriteArrayOfFavColors(numoffavcolor, out arrayfavcolors);
            User.FavColors = arrayfavcolors;
            UserInfo = User;

            return UserInfo;
        }

        static string[] GetArrayWithPets(int num, out string[] arrayOfPetsNames)
        {
            var petsNames = new string[num];
            string inputPetName;
            for (int i = 0; i < petsNames.Length; i++)
            {
                do
                {
                    Console.WriteLine("Запишите кличку животного: ");
                    inputPetName = Console.ReadLine();

                } while (CheckInpValue(inputPetName, out petsNames[i]));
                
            }

            arrayOfPetsNames = petsNames;
            return arrayOfPetsNames;
        }

        static string[] WriteArrayOfFavColors(int num, out string[] arrayOfFavorColors)
        {
            var arrayColors = new string[num];
            string inputdata;
            for (int i = 0; i < arrayColors.Length; i++)
            {
                do
                {
                    Console.WriteLine("Введите ваш любимый цвет:");
                    inputdata = Console.ReadLine();
                } while (CheckInpValue(inputdata, out arrayColors[i]));
            }

            arrayOfFavorColors = arrayColors;
            return arrayOfFavorColors;
        }

        static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if(intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            {
                corrnumber = 0;   // не понимаю зачем здесь нужны скобки {}
                Console.WriteLine("Введенные данные не корректны!");
                return true;
            }
        }

        static bool CheckInpValue(string input, out string corrinput)
        {
            //if (input == null)
            //{
            //    Console.WriteLine("Данные отсутствуют!");
            //    corrinput = null;
            //    return true;
            //}
            if (int.TryParse(input, out int intvalue))
            {
                Console.WriteLine("Введены неверные данные!");
                corrinput = null;
                return true;
            }
            else 
            {
                corrinput = input;
                return false;
            }
                
        }

        static void ShowUserData((string Name, string Lastname, int Age, bool HasPets, string[] PetsNames, string[] FavColors) User)
        {
            Console.WriteLine("Имя: " + User.Name);
            Console.WriteLine("Фамилия: " + User.Lastname);
            Console.WriteLine("Возраст: " + User.Age);

            Console.WriteLine("Есть ли животные: " + (User.HasPets ? "Да" : "Нет"));
            if (User.HasPets)
            {
                Console.WriteLine("Клички животных: ");
                for (int i = 0; i < User.PetsNames.Length; i++)
                {
                    Console.Write(User.PetsNames[i]);
                    if (i != User.PetsNames.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine(".");
            }
            else
                Console.WriteLine("Животных нет.");

            Console.WriteLine("Любимые цвета: ");
            for (int j = 0; j < User.FavColors.Length; j++)
            {
                Console.WriteLine(User.FavColors[j]);
                if (j != User.PetsNames.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(".");

        }

    }
    
}
