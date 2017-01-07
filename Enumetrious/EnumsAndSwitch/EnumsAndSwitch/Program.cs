using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> Todos = new List<Todo>()
            {
                new Todo {Description="Task 1" , EstimateHours=6, status=Status.c }
            };

        }
    }
   class Todo
    {
        public string Description { get; set; }
        public int EstimateHours { get; set; }
        public Status status  { get; set; }
    }
   enum Status
    {
        NotStarted,
        InPrograss,
        Onhold,
        Complate,
        Deleted
    }
}
