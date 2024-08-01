using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaSystem.utils
{
    public class Get : RequestMethod
    {
        public Get(string url)
        {

            this.url = url;
            this.body = null;
            this.method = HttpMethod.Get;

        }

        public override async Task<Object> send(HttpClient client)
        {
            base.request = new HttpRequestMessage(method, url);
            return await base.send(client);
        }

    }
}
