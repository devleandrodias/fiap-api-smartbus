using System;

namespace SmartBusApi.Model
{
    public class Company
    {
        public Company()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string FantasyName { get; set; }

        public string SocialName { get; set; }

        public string Cnpj { get; set; }
    }
}
