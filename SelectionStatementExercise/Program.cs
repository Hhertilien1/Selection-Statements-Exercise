namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            GuessingGame();
        }

        public static void GuessingGame()
        {
            Random r = new Random();
            int FavNum = r.Next(1, 10);

            Console.WriteLine("Guess my favorite number betwwn 1-10");
            int response = int.Parse(Console.ReadLine());

            if(response < FavNum)
            {
                Console.WriteLine("Too low!");
            }
            else if(response > FavNum)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine($"{response} was correct!");
            }
        }
    }
}
