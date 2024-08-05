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

        public Andress? GetAndressByPostalCode(string postalCode) {
            


            return new AndressService().searchAndressByPostalCode(DataBase.client, postalCode);
        
        }

    }
}
