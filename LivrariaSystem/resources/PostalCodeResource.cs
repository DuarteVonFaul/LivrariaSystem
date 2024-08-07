using LivrariaSystem.models;
using LivrariaSystem.models.response;
using LivrariaSystem.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LivrariaSystem.resources
{
    public class PostalCodeResource
    {


        public Address? SearchPostalCodeByAPI(Client client, string postalCode)
        {

            Get searchPostalCode = new Get(Urls.GET_POSTAL_CODE + postalCode);

            string content = client.request(searchPostalCode).Result as string;

            if (content != null)
            {
                return JsonSerializer.Deserialize<AndressResponse>(content).data;
            }

            return null;
        }

    }
}
