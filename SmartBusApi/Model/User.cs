using System;

namespace SmartBusApi.Model
{
    public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string PassportHash { get; set; }
    }
}
