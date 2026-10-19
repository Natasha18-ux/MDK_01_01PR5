using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Патрушева.Classes
{
    public class RepoStudents
    {
        public static List<Student> AllStudent()
        {
            List<Student> allStudents = new List<Student>();

            allStudents.Add(new Student("Патрушева", "Наталья", "Сергеевна", true, 4));
            allStudents.Add(new Student("Воробьев", "Леонид", "Дмитреевич", true, 4));
            allStudents.Add(new Student("Евдакимова", "Валерия", "Евгеньевна"));
            allStudents.Add(new Student("Евдакимова", "Екатерина", "Евгеньевна"));
            allStudents.Add(new Student("Зуева", "Елена", "Александровна", false, 3));
            allStudents.Add(new Student("Малыгина", "Марина", "Сергеевна"));
            allStudents.Add(new Student("Мансурова", "София", "Витальевна"));
            allStudents.Add(new Student("Минобаев", "Олег", "Артемович", false, 3));
            allStudents.Add(new Student("Неизвестная", "Дарья", "Тимуровна"));
            allStudents.Add(new Student("Соснина", "Диана", "Дмитриевна", true, 4));
            allStudents.Add(new Student("Кандакова", "Ангелина", "Игоревна"));
            allStudents.Add(new Student("Павлов", "Алексе1", "Михайлович"));
            allStudents.Add(new Student("Некрасов", "Артем", "Олегович"));
            allStudents.Add(new Student("Смирнова", "Шуша", "Андреевна"));
            allStudents.Add(new Student("Патрушева", "Наталья", "Сергеевна", true, 4));
            allStudents.Add(new Student("Воробьев", "Леонид", "Дмитреевич", true, 4));
            allStudents.Add(new Student("Евдакимова", "Валерия", "Евгеньевна"));
            allStudents.Add(new Student("Евдакимова", "Екатерина", "Евгеньевна"));
            allStudents.Add(new Student("Зуева", "Елена", "Александровна", false, 3));
            allStudents.Add(new Student("Малыгина", "Марина", "Сергеевна"));
            allStudents.Add(new Student("Мансурова", "София", "Витальевна"));
            allStudents.Add(new Student("Минобаев", "Олег", "Артемович", false, 3));
            allStudents.Add(new Student("Неизвестная", "Дарья", "Тимуровна"));
            allStudents.Add(new Student("Соснина", "Диана", "Дмитриевна", true, 4));
            allStudents.Add(new Student("Кандакова", "Ангелина", "Игоревна"));
            allStudents.Add(new Student("Павлов", "Алексе1", "Михайлович"));
            allStudents.Add(new Student("Некрасов", "Артем", "Олегович"));
            allStudents.Add(new Student("Смирнова", "Шуша", "Андреевна"));

            return allStudents;
        }
    }
}
