using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharentAPI.ExternalServices
{
    public class VkApiService : ExternalApiService
    {
        private string GetAccesTokenUrl = "https://oauth.vk.com/access_token";

        private VkAppSettings settings;

        public async Task<VkUserAccessToken> Authorize(string code)
        {
            return await SendJsonRequest<VkUserAccessToken>(GetAccesTokenUrl, new VkGetTokenRequest
            {
                client_id = settings.client_id,
                client_secret = settings.client_secret,
                redirect_url = settings.redirect_url,
                code = code
            });
        }
    }

    public class VkAppSettings
    {
        public string client_id;
        public string client_secret;
        public string redirect_url;
    }

    public class VkGetTokenRequest
    {
        public string client_id;
        public string client_secret;
        public string redirect_url;
        public string code;
    }

    public class VkUserAccessToken
    {
        public string access_token;
        public int expires_in;
        public string user_id;
        public DateTime issue_datetime;

        public bool IsNotExpired()
        {
            TimeSpan span = DateTime.Now - issue_datetime;
            return span.Seconds < expires_in;
        }
    }
}
