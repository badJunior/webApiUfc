namespace Ufc.Logic
{
    public class Fight
    {
        public string Fighter1 { get; set; }
        public string Fighter2 { get; set; }
        public string Winner { get; set; }
        public Fight(IEnumerable<string> fighterNames)
        {
            ChooseFighters(fighterNames);
            CalculateResult();

        }

        private void ChooseFighters(IEnumerable<string> fighterNames)
        {
            string fighter1, fighter2;
            var listFighter = fighterNames.ToList();
            var random = new Random();
            do
            {
                fighter1 = listFighter[random.Next(listFighter.Count)];
                fighter2 = listFighter[random.Next(listFighter.Count)];

            }
            while (fighter1 == fighter2);

            Fighter1 = fighter1;
            Fighter2 = fighter2;
        }

        private void CalculateResult()
        {
            int result = (new Random().Next(0, 2));


            if (result == 1)
            {
                Winner = Fighter1;

            }
            else
            {
                Winner = Fighter2;
            }
        }
    }
}
