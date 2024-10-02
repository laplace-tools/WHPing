using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WHPing
{
    internal class PostParameter
    {
        public string content { get; set; }
        public string displayName { get; set; }

        public FormUrlEncodedContent encodedContent()
        {
            Dictionary<string, string> param = new Dictionary<string, string>
            {
                { "content", this.content },
                { "username", this.displayName },
            };
            FormUrlEncodedContent ret = new FormUrlEncodedContent(param);

            return ret;
        }
    }
}
