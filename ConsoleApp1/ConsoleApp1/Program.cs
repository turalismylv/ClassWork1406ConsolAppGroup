using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Group group = new Group("p323");
            while (true)
            {

                Console.WriteLine("1.student elave et  2.Studentleri gor  3.Student uzre axtaris 4.Student silinsin ");
                string numm = Console.ReadLine();
                bool isInt = int.TryParse(numm, out int menu);

                switch (menu)
                {
                    case 1:

                        Console.WriteLine("Student adin qeyd edin");
                        string name = Console.ReadLine();
                        Console.WriteLine("Studentin soyadin qeyd edin");
                        string surname = Console.ReadLine();
                        id:
                        //Console.WriteLine("Studentin ID qeyd edin");
                        //string _id = Console.ReadLine();
                        //bool isId = int.TryParse(_id, out int id);
                        //if (!isId)
                        //{
                        //    Console.WriteLine("Yanlis daxil edildi,zehmet olmasa Duzgun daxil edin");
                        //    goto id;
                        //}
                    AGE:
                        Console.WriteLine("Studentin yasini qeyd edin");
                        string _age = Console.ReadLine();
                        bool isAge = int.TryParse(_age, out int age);
                        if (!isAge)
                        {
                            Console.WriteLine("Yanlis daxil edildi,zehmet olmasa Duzgun daxil edin");
                            goto AGE;
                        }
                    GRADE:
                        Console.WriteLine("Studentin balini qeyd edin");
                        string _gr = Console.ReadLine();
                        bool isGrade = int.TryParse(_gr, out int grade);
                        if (!isGrade)
                        {
                            Console.WriteLine("Yanlis daxil edildi,zehmet olmasa Duzgun daxil edin");
                            goto GRADE;
                        }
                        Student student = new Student(name, surname, age, grade);
                        group.studens.Add(student);
                        
                        break;
                    case 2:
                        foreach (var item in group.studens)
                        {
                            Console.WriteLine(item.Name);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Gormek istediyininz studentin adini qeyd edin");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("Gormek istediyininz studentin soyadini qeyd edin");
                        string surname1 = Console.ReadLine();
                        foreach (var item in group.studens)
                        {
                            if (name1==item.Name||surname1==item.Surname)
                            {
                                Console.WriteLine(item.Name);
                            }
                        }
                        break;
                    case 4:
                        Id:
                        Console.WriteLine("Silmek istediyiniz studentin ID qeyd edin");
                        string idd = Console.ReadLine();
                        bool isid = int.TryParse(idd, out int id_);
                        if (!isid)
                        {
                            Console.WriteLine("Yanlis daxil edildi,zehmet olmasa Duzgun daxil edin");
                            goto Id;
                        }
                        foreach (var item in group.studens)
                        {
                            if (item.Id==id_)
                            {
                                group.studens.Remove(item);
                                Console.WriteLine($"{item.Name} silindi");
                                break;
                            }
                            
                        }

                        break;
                    default:
                        break;
                }

            }
           
        }
    }
}
