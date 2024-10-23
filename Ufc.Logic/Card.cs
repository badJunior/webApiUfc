namespace Ufc.Logic
{
    public class Card
    {
        public List<Fight> Fights { get; set; }

        public int NumberCard { get; set; }

        public Card(int number, int fightsCount, IEnumerable<string> fighterNames)
        {
            var fights = new List<Fight>();


            for (int j = 0; j < fightsCount; j++)
            {


                fights.Add(new Fight(fighterNames));

            }
            Fights = fights;
            NumberCard = number;



        }
    }
}