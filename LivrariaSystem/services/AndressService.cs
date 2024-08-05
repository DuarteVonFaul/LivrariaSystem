using LivrariaSystem.models;
using LivrariaSystem.models.response;
using LivrariaSystem.resources;
using LivrariaSystem.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaSystem.services
{
    public class AndressService
    {




        public Andress? searchAndressByPostalCode(Client client, string postalCode)
        {


            return new PostalCodeResource().SearchPostalCodeByAPI(client, postalCode);

        }





    }
}
