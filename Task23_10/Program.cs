using System.Security.Cryptography.X509Certificates;
using Task23_10.Models;

namespace Task23_10
{
    internal class Program
    {
        static void Main(string[] args)
        {  

            //TASK2 
            List<Exam> exam = new List<Exam>
            {
              new Exam { Subject = "Math", ExamDuration = 3,StartDate = DateTime.Now.AddDays(-6) },
              new Exam { Subject = "Literature", ExamDuration = 1,StartDate = DateTime.Now.AddDays(-2) },
              new Exam { Subject = "Biology", ExamDuration = 1, StartDate = DateTime.Now},
              new Exam { Subject = "English", ExamDuration = 2 ,StartDate = DateTime.Now.AddDays(-1)},
              new Exam { Subject = "Physics", ExamDuration = 4,StartDate = DateTime.Now.AddDays(-5)},
              new Exam { Subject = "Chemistry", ExamDuration = 1, StartDate = DateTime.Now},
            };

            List<Exam> examweek = exam.FindAll(e => e.StartDate >= DateTime.Now.AddDays(-7));
            Console.WriteLine("Bir hefte erzinde olan imtahanlar:");
            foreach (var exams in examweek)
            {
                Console.WriteLine($" Subjecti :{exams.Subject} --- Duration:{exams.ExamDuration} ");
            }

            Console.WriteLine("\n");

            List<Exam> examduration = exam.FindAll(e => e.ExamDuration >= 2);
            Console.WriteLine("2saatdan uzun ceken imtahanlar");
            foreach (var exams in examduration)
            {
                Console.WriteLine($"Subjecti:{exams.Subject} --- Duration :{exams.ExamDuration} ");
            }

            Console.WriteLine("\n");

            List<Exam> examnow = exam.FindAll(e => e.StartDate <= DateTime.Now && e.EndDate > DateTime.Now);
            Console.WriteLine("Hazirda davam eden imtahanlar:");
            foreach (var exams in examnow)
            {
                Console.WriteLine($"Subjecti:{exams.Subject} --- Duration:{exams.ExamDuration} ");
            }


            //TASK1
            //List<Person> people = new List<Person>
            //{
            // new Person { Name = "Kamil", Surname = "Agamaliyev", Age = 14 },
            // new Person { Name = "Sefiqe", Surname = "Eliyeva", Age = 19 },
            // new Person { Name = "Arzu", Surname = "Mirzezade", Age = 45 },
            // new Person { Name = "Natiq", Surname = "Seferli", Age = 39 },
            // new Person { Name = "Leman", Surname = "Qurbanova", Age = 15 },
            // new Person { Name = "Emil", Surname = "Memmedov", Age = 22 },
            // new Person { Name = "Ramiz", Surname = "Huseynli", Age = 20 },
            // new Person { Name = "Arzu", Surname = "Memmedova", Age = 17 },
            // new Person { Name = "Kamil", Surname = "Enverov", Age = 20 },
            //};

            //Console.WriteLine("Axtardiginiz adi daxil edin:");
            //string _name = Console.ReadLine().ToLower();
            //List<Person> name = people.FindAll(n => n.Name.ToLower()==_name);
            //Console.WriteLine("Siyahida bu adda olan adamlar");
            //foreach (var person in name)
            //{
            //    Console.WriteLine(person.Name + " " + person.Surname);
            //}
            //Console.WriteLine( "\n");


            //List<Person> surname = people.FindAll(n => n.Surname.EndsWith("ov") || n.Surname.EndsWith("ova"));
            //Console.WriteLine("Soyadinda ov /ova olan insanlar ");
            //foreach (var person in surname)
            //{
            //    Console.WriteLine(person.Name + " " + person.Surname);
            //}

            //Console.WriteLine("\n"); 

            //List<Person> age = people.FindAll(n => n.Age >= 20);
            //Console.WriteLine("Yasi 20 den boyuk olanlar:");
            //foreach (var person in age)
            //{
            //    Console.WriteLine(person.Name + " " + person.Surname);
            //}

        }
    }
}