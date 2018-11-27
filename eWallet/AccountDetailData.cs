using System;
using System.Collections.Generic;

namespace eWallet
{
    public class AccountDetailData
    {
        public List<Datum> data { get; set; }
        public Collection collection { get; set; }

        public class Collection
        {
            public int current_page { get; set; }
            public int per_page { get; set; }
            public int total_entries { get; set; }
            public int total_pages { get; set; }
        }
        public class Datum
        {
            public string id { get; set; }
            public string account_number { get; set; }
            public object iban { get; set; }
            public int balance { get; set; }
            public int balance_available { get; set; }
            public string bic { get; set; }
            public int preauth_amount { get; set; }
            public int cash_flow_per_year { get; set; }
            public object is_debit_note_enabled { get; set; }
            public object is_trusted { get; set; }
            public bool is_locked { get; set; }
            public string currency { get; set; }
            public int overdraft { get; set; }
            public bool garnishee_protected { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public string nick { get; set; }
            public List<Customer> customers { get; set; }
        }

        public class Customer
        {
            public string id { get; set; }
            public string email { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public object additional_first_name { get; set; }
            public string gender { get; set; }
            public object title { get; set; }
            public string nick { get; set; }
            public object maiden_name { get; set; }
            public string adr_street { get; set; }
            public string adr_street_number { get; set; }
            public string adr_post_code { get; set; }
            public string adr_city { get; set; }
            public object birthplace { get; set; }
            public string adr_country { get; set; }
            public object adr_phone { get; set; }
            public object adr_mobile { get; set; }
            public object adr_fax { get; set; }
            public object adr_businessphone { get; set; }
            public DateTime birthday { get; set; }
            public bool is_verified { get; set; }
            public object nationality { get; set; }
            public object marital_status { get; set; }
            public object occupation { get; set; }
            public int religion { get; set; }
            public object country_of_birth { get; set; }
            public object preferred_language { get; set; }
            public object id_card_registration_city { get; set; }
            public object id_card_number { get; set; }
            public object id_card_valid_until { get; set; }
            public Legal legal { get; set; }
            public object newsletter { get; set; }
            public string affiliate_uid { get; set; }
            public object community_user_picture { get; set; }
            public DateTime created_at { get; set; }
            public string account_type { get; set; }
            public string customer_number { get; set; }
            public DateTime updated_at { get; set; }
            public List<object> additional_nationalities { get; set; }
        }

        public class Legal
        {
            public object tos { get; set; }
            public object privacy_policy { get; set; }
            public object own_interest { get; set; }
            public object community_terms_and_conditions { get; set; }
            public object us_citizen { get; set; }
            public object us_tax_payer { get; set; }
        }

    }

}