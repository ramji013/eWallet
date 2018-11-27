using System;
using System.Collections.Generic;

namespace eWallet
{
    public class TnxData
    {
        public List<Datum> data { get; set; }
        public Collection collection { get; set; }
        public class TransactionTypeDetails
        {
            public object sepa_credit_transfer_id { get; set; }
            public string remote_name { get; set; }
            public string remote_iban { get; set; }
            public string remote_bic { get; set; }
            public string remote_eref { get; set; }
        }

        public class Datum
        {
            public string id { get; set; }
            public string account_id { get; set; }
            public string transaction_type { get; set; }
            public string subject { get; set; }
            public int amount { get; set; }
            public string booking_code { get; set; }
            public DateTime booking_date { get; set; }
            public DateTime value_date { get; set; }
            public string return_transaction_id { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public string currency { get; set; }
            public TransactionTypeDetails transaction_type_details { get; set; }
        }

        public class Collection
        {
            public int current_page { get; set; }
            public int per_page { get; set; }
            public int total_entries { get; set; }
            public int total_pages { get; set; }
        }

    }
}