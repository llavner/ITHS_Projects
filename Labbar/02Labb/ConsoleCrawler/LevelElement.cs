namespace ConsoleCrawler
{
    internal partial class Program
    {
        abstract class LevelElement
        {

            public int x { get; set; }
            public int y { get; set; }

            public char ElementChar { get; set; }

            public ConsoleColor Color { get; set; }


            public void Draw()
            {

            }

        }
       
    }
}
