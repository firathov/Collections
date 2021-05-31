using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections_hw
{
    abstract class Person
    {
        public string Surname { get; set; }
        public int Course { get; set; }
        public int GradeBook { get; set; }

        public Person(string surname, int course, int gradeBook)
        {
            Surname = surname;
            Course = course;
            GradeBook = gradeBook;
        }
        public abstract void Print();
    }

    class Student : Person
    {
        public Student(string surname, int course, int gradeBook)
            : base(surname, course, gradeBook)
        {

        }

        public override void Print()
        {
            Console.Write($"Student's surname - { Surname }, Course - { Course }, Grade Book - { GradeBook } ");
        }
    }

    class Aspirant : Person
    {
        public string SlideShow { get; set; }
        public Aspirant(string slideShow, string surname, int course, int gradeBook)
            : base(surname, course, gradeBook)
        {
            SlideShow = slideShow;
        }

        public Aspirant(string surname, int course, int gradeBook, string slideShow) : base(surname, course, gradeBook)
        {

        }

        public override void Print()
        {
            Console.Write($"Aspirant's surname - { Surname }, Course - { Course }, Grade Book { GradeBook }, Slide show - { SlideShow } ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listStudent = new ArrayList();
            ArrayList listAspirant = new ArrayList();

            LinkedList<Student> linkedListStudent = new LinkedList<Student>();
            LinkedList<Aspirant> linkedListAspirant = new LinkedList<Aspirant>();

            for (; ; )
            {
                Menu();
                Console.WriteLine("\nChoose the number");
                int switcher = ForNumberCheck();
                switch (switcher)
                {
                    case 1:
                        {
                            Console.WriteLine("Type Students surname");
                            string surname = ForSurnameCheck();
                            Console.WriteLine("Type his/her course");
                            int course = ForCourseCheck();
                            Console.WriteLine("Type grade book number");
                            int gradeBook = ForGradeBookCheck();

                            listStudent.Add(new Student(surname, course, gradeBook));
                            linkedListStudent.AddLast(new Student(surname, course, gradeBook));
                            Console.WriteLine("\nType any keyboard...\n");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Type the name of presentation");
                            string slideShow = ForSurnameCheck();
                            Console.WriteLine("Type Students surname");
                            string surname = ForSurnameCheck();
                            Console.WriteLine("Type his/her course");
                            int course = ForCourseCheck();
                            Console.WriteLine("Type grade book number");
                            int gradeBook = ForGradeBookCheck();

                            listAspirant.Add(new Aspirant(slideShow, surname, course, gradeBook));
                            linkedListAspirant.AddLast(new Aspirant(slideShow, surname, course, gradeBook));
                            Console.WriteLine("\nType any keyboard...\n");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"\nYou have added {listStudent.Count} students");
                            Console.WriteLine("\nType any keyboard...\n");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"\nYou have added {listAspirant.Count} aspirants");
                            Console.WriteLine("\nType any keyboard...\n");
                            break;
                        }
                    case 5:
                        {
                            if (listStudent.Count == 0)
                            {
                                Console.WriteLine("There aren't any students");
                            }
                            else
                            {
                                foreach (Student item in listStudent)
                                {
                                    item.Print();
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine(", ArrayList");
                                    Console.ResetColor();
                                }
                            }
                            if (linkedListStudent.Count == 0)
                            {
                                Console.WriteLine("There aren't any students");
                            }
                            else
                            {
                                foreach (Student item3 in linkedListStudent)
                                {
                                    item3.Print();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(", Belongs to LinkedList");
                                    Console.ResetColor();
                                }
                            }
                            Console.WriteLine("\nType any keyboard...\n");
                            break;
                        }
                    case 6:
                        {
                            if (listAspirant.Count == 0)
                            {
                                Console.WriteLine("There aren't any students");
                            }
                            else
                            {
                                foreach (Aspirant item2 in listAspirant)
                                {
                                    item2.Print();
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine(", ArrayList");
                                    Console.ResetColor();
                                }
                            }
                            if (linkedListAspirant.Count == 0)
                            {
                                Console.WriteLine("There aren't any students");
                            }
                            else
                            {
                                foreach (Aspirant item4 in linkedListAspirant)
                                {
                                    item4.Print();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(", Belongs to LinkedList");
                                    Console.ResetColor();
                                }
                            }

                            Console.WriteLine("\nType any keyboard...\n");
                            break;
                        }
                    case 7:
                        {
                            if (listStudent.Count == 0)
                            {
                                Console.WriteLine("There aren't any students");
                            }
                            else
                            {
                                Console.WriteLine("To have an information about student type the number of student");
                                int studentNumber = ForNumberCheck() - 1;
                                if (studentNumber >= listStudent.Count)
                                {
                                    Console.WriteLine("We don't have the student on that number");
                                }
                                else
                                {
                                    Student human1 = (Student)listStudent[studentNumber];
                                    Console.WriteLine($"Student's surname - {human1.Surname}, Course - {human1.Course}, Grade book number - {human1.GradeBook}");
                                }
                            }
                            Console.WriteLine("\nType any keyboard...\n");
                            break;
                        }
                    case 8:
                        {
                            if (listAspirant.Count == 0)
                            {
                                Console.WriteLine("There aren't any students");
                            }
                            else
                            {
                                Console.WriteLine("To have an information about student type the number of student");
                                int aspirantNumber = ForNumberCheck() - 1;
                                if (aspirantNumber >= listAspirant.Count)
                                {
                                    Console.WriteLine("We don't have the aspirant on that number");
                                }
                                else
                                {
                                    Aspirant human2 = (Aspirant)listAspirant[aspirantNumber];
                                    Console.WriteLine($"Aspirant's surname - {human2.Surname}, Course - {human2.Course}, Grade book number - {human2.GradeBook}, Presentation - {human2.SlideShow} ");
                                }
                            }
                            Console.WriteLine("\nType any keyboard...\n");
                            break;
                        }
                    case 9:
                        {
                            if (listStudent.Count == 0)
                            {
                                Console.WriteLine("There aren't any students");
                            }
                            else
                            {
                                Console.WriteLine("For delette the student, type his/her number");
                                int deletteStudent = ForNumberCheck() - 1;
                                if (deletteStudent >= listStudent.Count)
                                {
                                    Console.WriteLine("We don't have the student on that number");
                                }
                                else
                                {
                                    Student human3 = (Student)listStudent[deletteStudent];
                                    Console.WriteLine($"Student {human3.Surname} was deleted");
                                    listStudent.RemoveAt(deletteStudent);
                                }
                            }
                            Console.WriteLine("\nType any keyboard...\n");
                            break;
                        }
                    case 10:
                        {
                            if (listAspirant.Count == 0)
                            {
                                Console.WriteLine("There aren't any students");
                            }
                            else
                            {
                                Console.WriteLine("For delette the student, type his/her number");
                                int deletteAspirant = ForNumberCheck() - 1;
                                if (deletteAspirant >= listAspirant.Count)
                                {
                                    Console.WriteLine("We don't have the student on that number");
                                }
                                else
                                {
                                    Aspirant human4 = (Aspirant)listAspirant[deletteAspirant];
                                    Console.WriteLine($"Aspirant {human4.Surname} was deleted");
                                    listAspirant.RemoveAt(deletteAspirant);
                                }
                            }
                            Console.WriteLine("\nType any keyboard...\n");
                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine("See yaa");
                            break;
                        }
                    default:
                        {
                            Console.Write("You have only 11 choices, pls try again: ");
                            break;
                        }
                }
                Console.ReadKey();
            }

        }

        public static void Menu()
        {
            Console.WriteLine("1)Add Student");
            Console.WriteLine("2)Add Aspirant");
            Console.WriteLine("3)Number of students");
            Console.WriteLine("4)Number of aspirants");
            Console.WriteLine("5)List of all students");
            Console.WriteLine("6)List of all aspirants");
            Console.WriteLine("7)Show student by index number");
            Console.WriteLine("8)Show aspirant by index number");
            Console.WriteLine("9)Delette student by index number");
            Console.WriteLine("10)Delette aspirant by index number");
            Console.WriteLine("11)Exit");
        }

        public static bool surnameCompare = true;

        static string ForSurnameCheck()
        {
            string humanSurname;
            do
            {
                humanSurname = Console.ReadLine();

                for (int i = 0; i < humanSurname.Length; i++)
                {
                    char element = humanSurname[i];

                    if (!Char.IsLetter(element))
                    {
                        surnameCompare = false;
                        Console.Write("You wrote the wrong symbol, pls try again: \n ");
                        break;
                    }
                    else
                    {
                        surnameCompare = true;
                    }
                }
                if (humanSurname.Length < 1)
                {
                    Console.Write("Name can't be less than 1 letter, pls try again: ");
                    surnameCompare = false;
                }

            }
            while (surnameCompare == false);
            return humanSurname;
        }

        static int ForGradeBookCheck()
        {
            int number;
            for (; ; )
            {
                string checkingNumber = Console.ReadLine();
                Int32.TryParse(checkingNumber, out number);

                if (number > 0 && number < 10000)
                {
                    return number;
                }

                else
                {
                    Console.Write("You wrote the wrong symbol, type between 1 - 9999: ");
                }
            }
        }

        static int ForCourseCheck()
        {

            for (; ; )
            {
                string checkingNumber = Console.ReadLine();
                Int32.TryParse(checkingNumber, out int number);

                if (number > 0 && number < 9)
                {
                    return number;
                }
                else
                {
                    Console.Write("We don't have that number of course, type between 1-8: ");
                }
            }
        }

        static int ForNumberCheck()
        {
            int number;

            for (; ; )
            {
                string checkingNumber = Console.ReadLine();
                if (Int32.TryParse(checkingNumber, out number) && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.Write("You wrote the wrong symbol, try again: ");
                }
            }
        }
    }
}

