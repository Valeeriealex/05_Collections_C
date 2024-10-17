using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Tasks_IJunior._05_Collections
//{
//    internal class Personnel_accounting
//    {
//        static void Main(string[] args)
//        {
//            const string MenuFillOutADossier = "1";
//            const string MenuConclusionOfTheDossier = "2";
//            const string MenuDeletionOfDossier = "3";
//            const string MenuExit = "4";

//            Dictionary<string, List<string>> employeePositions = new Dictionary<string, List<string>>();

//            employeePositions["директор"] = new List<string>();
//            employeePositions["менеджер"] = new List<string>();
//            employeePositions["программист"] = new List<string>();

//            employeePositions["директор"].Add("Сидоров Петр Сидорович");
//            employeePositions["менеджер"].Add("Петров Петр Петрович");
//            employeePositions["менеджер"].Add("Иванов Иван Иванович");
//            employeePositions["программист"].Add("Александрова Александра Александровна");
//            employeePositions["программист"].Add("Петров Питр Петрович");

//            bool isWorking = true;

//            while (isWorking)
//            {
//                Console.WriteLine($"\nВыберете действие:\n" + MenuFillOutADossier + " добавить досье\n"
//                    + MenuConclusionOfTheDossier + " вывести все досье\n"
//                    + MenuDeletionOfDossier + " удалить досье\n"
//                    + MenuExit + " выйти\n");

//                string userChose = Console.ReadLine();

//                switch (userChose)
//                {
//                    case MenuFillOutADossier:
//                        AddDossier(employeePositions);
//                        break;

//                    case MenuConclusionOfTheDossier:
//                        PrintDossier(employeePositions);
//                        break;

//                    case MenuDeletionOfDossier:
//                        DeleteDossier(employeePositions);
//                        break;

//                    case MenuExit:
//                        isWorking = false;
//                        break;

//                    default:
//                        Console.WriteLine("Ошибка");
//                        break;
//                }
//            }
//        }

//        static void AddDossier(Dictionary<string, List<string>> employeePositions)
//        {
//            Console.WriteLine("Введите должность сотрудника для добавления: ");
//            string post = Console.ReadLine();

//            if (employeePositions.ContainsKey(post))
//            {
//                Console.WriteLine("Введите фио сотрудника: ");
//                string newName = Console.ReadLine();
//                employeePositions[post].Add(newName);
//                Console.WriteLine("Сотрудник успешно добавлен");
//            }
//            else
//            {
//                AddPost(employeePositions);
//            }
//        }

//        static void AddPost(Dictionary<string, List<string>> employeePositions)
//        {
//            const string MenuAddDossier = "1";
//            const string MenuExit = "2";

//            Console.WriteLine("Ошибка\nТакой должности нет");
//            Console.WriteLine($"Выберете действие:\n" + MenuAddDossier + " добавить должность " + MenuExit + " выйти ");
//            string userInput = Console.ReadLine();

//            if (userInput == MenuAddDossier)
//            {
//                Console.WriteLine("Введите новую должность: ");
//                string newPost = Console.ReadLine();
//                employeePositions[newPost] = new List<string>();
//                Console.WriteLine("Должность создана");
//                AddDossier(employeePositions);
//            }
//        }

//        static void PrintDossier(Dictionary<string, List<string>> employeePositions)
//        {
//            foreach (var item in employeePositions)
//            {
//                Console.Write($"должность: {item.Key} список сотрудников: {String.Join(", ", item.Value)} - ");
//            }
//        }

//        static void DeleteDossier(Dictionary<string, List<string>> employeePositions)
//        {
//            Console.WriteLine("Введите должность сотрудника для удаления: ");
//            string postForDelete = Console.ReadLine();

//            if (employeePositions.ContainsKey(postForDelete))
//            {
//                for (int i = 0; i < employeePositions[postForDelete].Count; i++)
//                {
//                    Console.WriteLine($"{i + 1} " + employeePositions[postForDelete][i]);
//                }

//                if (employeePositions[postForDelete].Count > 0)
//                {
//                    Console.WriteLine("Введите номер сотрудника для удаления: ");
//                    string numberForDelete = Console.ReadLine();

//                    if (int.TryParse(numberForDelete, out int number))
//                    {
//                        if (number >= 0 && number < employeePositions[postForDelete].Count)
//                        {
//                            int convert = Convert.ToInt32(numberForDelete);
//                            int index = convert - 1;
//                            employeePositions[postForDelete].RemoveAt(index);
//                            Console.WriteLine($"Сотрудник с номером {numberForDelete} удален из массива: ");
//                            PrintDossier(employeePositions);
//                        }
//                        else
//                        {
//                            Console.WriteLine("Ошибка\nТакого номера нет");
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("Ошибка\nВведен не номер");
//                    }
//                }
//            }
//            else
//            {
//                Console.WriteLine("Ошибка\nТакой должности нет");
//            }
//        }
//    }
//}
