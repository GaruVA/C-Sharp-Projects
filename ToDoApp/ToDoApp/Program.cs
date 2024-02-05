using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ToDoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("To Do List");
            Console.WriteLine("------------------------------------");
            List<string> taskList = new List<string>();
            string choice = "temp";
            int taskNum;
            while (true)
            {
                Console.WriteLine("------------------------------------");
                for (int i = 0; i < taskList.Count; i++) 
                {
                    Console.WriteLine($"{taskList[i]}");
                }
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1 - New Task");
                Console.WriteLine("2 - Delete Task");
                Console.WriteLine("e - Exit");
                Console.WriteLine();
                Console.Write("Enter Choice: ");
                choice = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("To Do List");
                Console.WriteLine("------------------------------------");
                if (choice == "e")
                {
                    break;
                }
                else if (choice == "1")
                {
                    Console.Write("Enter Task: ");
                    taskList.Add(Console.ReadLine());
                    Console.WriteLine("Success: Task has been added.");
                }
                else if (choice == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - {taskList[i]}");
                    }
                    Console.WriteLine();
                    Console.Write("Enter Task Number: ");
                    taskNum = int.Parse(Console.ReadLine()) - 1;
                    if (taskNum >= 0 && taskNum < taskList.Count)
                    {
                        taskList.RemoveAt(taskNum);
                        Console.WriteLine("Success: Task has been deleted.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Value!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Choice!");
                }
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("To Do List");
                Console.WriteLine("------------------------------------");
            }
        }
    }
}
