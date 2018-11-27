using System;

namespace eWallet
{
 
    public class UsersCurrentData
    {
        public string id { get; set; }
        public string email { get; set; }
        public object msisdn { get; set; }
        public string affiliate_uid { get; set; }
        public DateTime msisdn_activated_at { get; set; }
        public DateTime last_sign_in_at { get; set; }
        public int friend_count { get; set; }
        public int friend_of_friend_count { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

}