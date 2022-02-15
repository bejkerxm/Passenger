namespace Infrastructure.DTO
{
    /// <summary>
    /// Klasa anemiczna, plaski obiekt - mapuje domene na plaskie obiekty // Anty corruption layer
    /// </summary>
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
    }
}