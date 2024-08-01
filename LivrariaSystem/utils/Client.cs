using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace LivrariaSystem.utils
{
    public class Client
    {
        private HttpClient client = new HttpClient();


        async public Task<Object?> request(RequestMethod r)
        {
             return await r.send(client);
        }
    }
}
