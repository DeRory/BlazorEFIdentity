using BlazorEFIdentity.Data;

namespace BlazorEFIdentity.Models
{
    public class Transaction
    {

        public int Id { get; set; }

        //public string PayTo { get; set; }

        //public string PayFrom { get; set; }

        public DateTime DateTime { get; set; } = DateTime.UtcNow;

        public decimal OutgoingBalance { get; set; }

        public string Currency { get; set; }

        public decimal ReservedBalance { get; set; }

        public string TransactionMessage { get; set; }

        public string TransactionNumber { get; set; }

        /*public int ToAccountId { get; set; } *///Foreign key som är accounts primary key.

        //public Account ToAcccount { get; set; } 
        public int FromAccountId { get; set; }

        public Account FromAcccount { get; set; }

    }
}
