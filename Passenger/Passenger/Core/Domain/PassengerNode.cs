namespace Core.Domain
{
    public class PassengerNode
    {
        /// <summary>
        /// w jakim miejscu ma zaladowac pasazera - Node
        /// </summary>
        public Node Node { get; protected set; }

        public Passenger Passenger { get; protected set; }
    }
}