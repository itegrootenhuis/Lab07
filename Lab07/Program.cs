using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Program
    {
        public static string studentData;

        static void Main(string[] args)
        {
            SetUpStudentData("Ian", "Allendale", "Alfrado");//tegrootenhuis
            SetUpStudentData("Kevin", "Chicago", "Oatmeal");//davis
            SetUpStudentData("Adam", "Grand Rapids", "putine");//tasma
            SetUpStudentData("Aaron", "Hart", "Ribeye");//sandusky
            SetUpStudentData("Marshal", "Holland", "Burgers");//hatley
            SetUpStudentData("David", "Fort Wayne", "Lasagna");//wilkins
            SetUpStudentData("Andrew", "Fremont", "steak ");//patenge
            SetUpStudentData("Chamus", "Zeeland", "Sushi");//gilbert
            SetUpStudentData("Jonathan", "Middleville", "Stouts");//higgins
            SetUpStudentData("Albert", "Grand Rapids", "pounded potatoes with beans");//ngoudjou
            SetUpStudentData("Tommy", "Raleigh", "Chicken Curry");//waalkes

            Console.WriteLine("Welcome to C# Class. Which student would you like to learn more about? ");
            GetUserInput();
        }

        private static void SetUpStudentData(string Name, string Hometown, string FavoriteFood)
        {
            Student student = new Student();
            student.Name = Name;
            student.Hometown = Hometown;
            student.FavoriteFood = FavoriteFood;
            studentData += JsonConvert.SerializeObject(student);
        }

        private static void GetUserInput()
        {
            Console.WriteLine("Enter in a student's first name: ");
            //string studentName = Console.ReadLine();
            dynamic data = JObject.Parse(studentData);
            Console.WriteLine(data);
            Console.WriteLine(studentData);
            QuitConsoleApp();
            //if (students.Contains(studentName.ToLower()))
            //{
            //    SetupNewStudent(studentName);
            //}
            //else
            //{
            //    Console.WriteLine("The student you are searching for doesn't exist.");
            //    QuitConsoleApp();
            //}
        }

        private static void SetupNewStudent(string studentName)
        {
            Student student = new Student();
            Console.WriteLine("Name: {0}, Favoirte Food: {1}, Hometown: {2}", studentName, student.FavoriteFood, student.Hometown);
        }

        private static void QuitConsoleApp()
        {
            Console.WriteLine("\n\nPress R to repeat or any other key to exit the app.");
            ConsoleKeyInfo quitKey = Console.ReadKey();

            if (quitKey.Key.ToString().ToLower() == "r")
            {
                Console.Clear();
                GetUserInput();
            }
        }
    }
}
