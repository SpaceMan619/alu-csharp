namespace Bakery.Models
{
    public class Bread
    {
        public int Loaves { get; set; }

        public Bread(int loaves)
        {
            Loaves = loaves;
        }

        public float CalculateCost()
        {
            int freeLoaves = Loaves / 3;
            return (Loaves - freeLoaves) * 5;
        }
    }

    public class Pastry
    {
        public int Pastries { get; set; }

        public Pastry(int pastries)
        {
            Pastries = pastries;
        }

        public float CalculateCost()
        {
            int freePastries = Pastries / 4;
            return (Pastries - freePastries) * 2;
        }
    }
}
