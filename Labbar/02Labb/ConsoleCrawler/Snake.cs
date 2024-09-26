namespace ConsoleCrawler
{
    internal partial class Program
    {
        class Snake : Enemy
        {

            public Snake()
            {
                Name = "Snake";
                Health = 10;
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
