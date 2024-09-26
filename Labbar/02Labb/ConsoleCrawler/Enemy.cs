namespace ConsoleCrawler
{
    internal partial class Program
    {
        abstract class Enemy : LevelElement
        {
            //Enemy ska ha properties för namn (t.ex snake/rat), hälsa (HP), samt AttackDice och DefenceDice av typen Dice (mer om detta längre ner).
            //Den ska även ha en abstrakt Update-metod.

            public string Name { get; set; }
            public int Health { get; set; }
            public int AttackDice { get; set; }
            public int DefenceDice { get; set; }


            public abstract void Update();
            

            
        }
    }
}
