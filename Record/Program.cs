namespace Record
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student std1 = new Student() { Name = "Garib", Surname = "Garibzade" };
            Student std2 = new Student() { Name = "Samir", Surname = "Karimov" };
            Student std3 = new Student();
            
            Console.WriteLine(std1);
            Console.WriteLine(std2);
            Console.WriteLine(std3);
            Console.WriteLine(std1 == std2);
            //----2222----------


            Human human =new Human() {Name = "samir",Surname = "Karimov",Age = 20 };
            //human.Deconstruct(out string name, out string surename, out int age);

        }
        internal record Student
        {
            public string Name { get; init; } = "YYY";
            public string Surname { get; init; } = "XXX";

        }
        internal record Human 
        {
           public string Name { get; init; }
           public string Surname { get; init; }
            public int Age { get; init; }
        }
    }
}
