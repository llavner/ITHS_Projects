namespace ConsoleCrawler
{
    internal partial class Program
    {
        class Rat : Enemy
        {

            public Rat()
            {
                Name = "Rat";
                Health = 15;
                AttackDice = 0;
                DefenceDice = 0;
            }

            public override void Update()
            {
                throw new NotImplementedException();
            }
        }
    }
}
