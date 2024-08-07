using LivrariaSystem.models;
using LivrariaSystem.database;
using LivrariaSystem.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaSystem.controllers
{
    public class UserController
    {



        public Librarian createUserLibrarian(Librarian user)
        {
            return null;
        }


        public void createUserReader(Reader user)
        {
            DataBase.readers.Add(user);
        }

        public Address? GetAndressByPostalCode(string postalCode) {
            


            return new AddressService().searchAndressByPostalCode(DataBase.client, postalCode);
        
        }


        public Reader? GetUserReaderByID(string Id)
        {
            return DataBase.readers[Convert.ToInt32(Id) - 1];
        }

    }
}
