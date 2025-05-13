using StudentManagement.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Entities
{
    public static class StudentErrors
    {
        public static Error WrongAverage = new Error("Student.WrongAverage", "The Average must be beetween 0 and 20 ");

        public static Error WrongFields = new Error("Student.WrongFields", "wrong filed key was entered : 0 = Maths , 1 = empirical science , 2 = Humanities");

        public static Error NotFound = new Error("Student.NotFound", "Student Not Found Double Check Your Inputs");

    }
}
