using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samost
{
    struct Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public int? Inf { get; set; }
        public int? Physics { get; set; }
        public int? History { get; set; }

        public double GetAverage()
        {
            List<int> marks = new List<int>();
            if(Inf.HasValue) marks.Add(Inf.Value);
            if(Physics.HasValue) marks.Add(Physics.Value);
            if(History.HasValue) marks.Add(History.Value);

            if (marks.Any())
            {
                return marks.Average();
            }
            return 0.0;
        }
        public override string ToString()
        {
            return $"ФИО: {Name}, Группа: {Group}, Информатика: {Inf}, Физика: {Physics}, История: {History}, Средний балл: {GetAverage()}";
        }
    }
}
