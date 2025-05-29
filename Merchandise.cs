using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samost
{
    struct Merchandise
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Producer { get; set; }
        public int Count { get; set; }
        public DateTime Year { get; set; }
        public Merchandise(string name, double price, string producer, int count, DateTime year)
        {
            Name = name;
            Price = price;
            Producer = producer;
            Count = count;
            Year = year;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Producer: {Producer}, Count: {Count}, Date: {Year:d}";
        }
    }
}
