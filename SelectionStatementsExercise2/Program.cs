namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavoriteSchoolSubject();
        }

        public static void FavoriteSchoolSubject()
        {
            Console.WriteLine("What is your favorite subject? ");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I love math and numbers.");
                    break;
                case "biology":
                    Console.WriteLine("I love biology because I like to learn about plants and animals.");
                    break;
                case "literature":
                    Console.WriteLine("I hate literature because reading complicated words is hectic.");
                    break;
                case "history":
                    Console.WriteLine("I love history because I like to learn about U.S. history and how it all started. ");
                    break;
                case "writing":
                    Console.WriteLine("I hate writing because writing essays takes so much time.");
                    break;
                default:
                    Console.WriteLine("I do not know about that subject");
                    break;
            }

        }
    }
}