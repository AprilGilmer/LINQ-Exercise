namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameNames = new List<string>()
            {
            "Fallout: New Vegas",
            "Assettocorsa",
            "Half Life",
            "Legend of Zelda",
            "Doom",
            "Halo Reach",
            "Mario"
         };
            var orderedGameNames = gameNames.OrderBy(gameName => gameName.Length).ToList();
            orderedGameNames.ForEach(game => Console.WriteLine(game));
        }
    }
}
