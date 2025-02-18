using BlazorEFIdentity.Data;
using BlazorEFIdentity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;



namespace BlazorEFIdentity.Services
{
    public class BankAccountService // We create Services folder with a BankAcc Service file, the purpose this is to create a service which communicates between the component and database, this is where the functions will provide services.
    {
        // We create two private fields. _db is a reference to the database via EF.
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager; // _userManager is used here to get information about the logged in user.
        // We also use readonly because they can only be inserted into a constructor and cant be changed afterwards.


        //Down below is a constructor with parameters which allows us access into _db and _userManager.
        public BankAccountService(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        // Hämta alla bankkonton för den inloggade användaren
        public async Task<List<Account>> GetUserAccountsAsync(ApplicationUser user)
        {
            return await _dbContext.Accounts
                .Where(a => a.AccountName == user.UserName) // Filtrera konton för användaren
                .ToListAsync();
        }

        // Gets the users account. This is a method which has a parameter which brings ApplicationUser user.
        public async Task<List<Account>> GetAccountsAsync(ApplicationUser user)
        {
            return await _dbContext.Accounts //Return a list with accounts within the database. The return has conditions. whereas its gets all AccountName which matches the users username.
                                     // and we use await because we fetch data from the database and must wait till the operation is done.
                .Where(a => a.AccountName == user.UserName)
                .ToListAsync();
        }

        // Create a new bank account. This is a task with parameters. Fetches user and account.
        public async Task CreateAccountAsync(ApplicationUser user, Account account)
        {
            //gör ern null check, har vi en användare.
            if (user == null)
            {
                return;
            }
            account.UserId = user.Id;
            _dbContext.Accounts.Add(account); // We add the account in the database with this line.
            await _dbContext.SaveChangesAsync(); // We save the changes within the database with this line of code.
        }



    }
}
