using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaSystem.utils
{
    public abstract class RequestMethod
    {
        public string url = "";
        public Object body = "";
        protected HttpMethod method;
        protected HttpRequestMessage? request;

        public virtual async Task<Object?> send(HttpClient client)
        {
            HttpResponseMessage response = null;
            string content = "";

            try
            {
                response = await client.SendAsync(request);
                content = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return content;


        }
    }
}
