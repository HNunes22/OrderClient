namespace OrderClient.Entities
{
    internal class Client
    {
        public string ClientName {  get; set; }
        public string Email {  get; set; }
        public DateTime BirthDate { get; set; }

        public Client() { }

        public Client(string clientName, string email, DateTime birthDate)
        {
            ClientName = clientName;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
