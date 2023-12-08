namespace KaktuszokCLI
{
    internal class Kaktusz
    {
        public string KoznapiNev { get; set; }
        public string TudomanyosNev { get; set; }
        public string TermesztesiNehezseg { get; set; }
        public int Vizigeny { get; set; }
        public int Fenyigeny { get; set; }

        public Kaktusz(string sor)
        {
            var v = sor.Split(';');
            KoznapiNev = v[0];
            TudomanyosNev = v[1];
            TermesztesiNehezseg = v[2];
            Vizigeny = int.Parse(v[3]);
            Fenyigeny = int.Parse(v[4]);
        }
    }
}
