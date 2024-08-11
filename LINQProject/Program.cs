namespace LINQProject
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Person> people = new List<Person>()
            {
                new Person() { Name = "Sergey", Age = 40},
                new Person() { Name = "Vasiliy", Age = 35},
                new Person() { Name = "Kostya", Age = 12},
                new Person() { Name = "Alex", Age = 10}
            };

            var result =
                from p in people
                where p.Age >= 18
                orderby p.Name
                //select p;
                select new { Name = p.Name, Age = p.Age };

            var result2 =
                (from p in people
                where p.Age >= 18
                orderby p.Name
                //select p;
                select new { Name = p.Name, Age = p.Age }).ToList();

            people[2].Age = 22;

            foreach(var p in result)
            {
                Console.WriteLine("{0} : {1}", p.Name, p.Age);
            }

            foreach (var p in result2)
            {
                Console.WriteLine("{0} : {1}", p.Name, p.Age);
            }
        }
    }
}
