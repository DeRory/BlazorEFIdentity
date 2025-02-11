using BlazorEFIdentity.Data;

namespace BlazorEFIdentity.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string AccountNumber { get; set; }

        public string AccountName { get; set; }

        public decimal Balance { get; set; }

        public string AccountType { get; set; }

        public List<Transaction> Transactions { get; set; }

        public bool ActiveAccount { get; set; }

        public string? CardNumber {  get; set; }

        public ApplicationUser User { get; set; } //Ändra till ApplicationUserId? för att lägga navigations property?

        public string UserId { get; set; } // Här knyter vi an en User som har en referens till ApplicationUser som sedan läggs i UserId
        // Då säger vi alltså att ett konto är knyten till en användare.
        // Dvs kopplar konto till en användare
    }
}
