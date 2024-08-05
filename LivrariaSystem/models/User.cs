using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaSystem.models
{
    public class User
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; } = string.Empty;

        public Andress Address { get; set; } = new Andress();

        public override string ToString()
        {
            return $" User: [Id: {Id},\n " +
                   $" Password: {Password},\n" +
                   $" Name: {Name},\n" +
                   $" PhoneNumber: {PhoneNumber},\n" +
                   $" Email: {Email},\n" +
                   $" Address: {Address.ToString()}]";
        }
    }

}
