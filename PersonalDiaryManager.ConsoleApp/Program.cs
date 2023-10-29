namespace PersonalDiaryManager.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coreLogic = new PersonalDiaryManager.Domain.CoreLogic();

            Console.WriteLine(coreLogic.GetHelloWorld());
        }
    }
}
