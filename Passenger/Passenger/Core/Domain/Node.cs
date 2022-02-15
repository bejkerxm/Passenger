namespace Core.Domain
{
    /// <summary>
    /// Value object - samo w sobie nie posiada wartosci
    /// </summary>
    public class Node
    {
        public string Adress { get; protected set; }
        public double Longitude { get; protected set; }
        public double Latitude { get; protected set; }
    }
}