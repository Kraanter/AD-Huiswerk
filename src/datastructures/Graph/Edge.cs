namespace AD
{
    public partial class Edge
    {
        public Vertex dest;
        public double cost;

        public Edge(Vertex d, double c)
        {
            dest = d;
            cost = c;
        }

        public override string ToString()
        {
            var retString = dest.name;

            retString += $"({cost})";

            return retString;
        }
    }
}