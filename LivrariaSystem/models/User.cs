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

        public Address Address { get; set; } = new Address();

        public override string ToString()
        {
            return $" Usuario: [Id: {Id},\n " +
                   $" Password: {Password},\n" +
                   $" Nome: {Name},\n" +
                   $" Numero de Telefone: {PhoneNumber},\n" +
                   $" Email: {Email},\n" +
                   $" Endereço:\n {Address.ToString()}]";
        }
    }

}
