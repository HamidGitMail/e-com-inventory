namespace HCS_Inventory_Api.Repositories;

using Dapper;
using MySql.Data.MySqlClient;
using HCS_Inventory_Api.Models;

public class AccountRepository : IAccountRepository
{
    private readonly MySqlConnection _connection;

    public AccountRepository(MySqlConnection connection)
    {
        _connection = connection;
    }

    public async Task<IEnumerable<Account>> GetAllAccountsAsync()
    {
        const string sql = "SELECT * FROM Accounts";
        return await _connection.QueryAsync<Account>(sql);
    }

    public async Task<Account?> GetAccountByIdAsync(string accountId)
    {
        const string sql = "SELECT * FROM Accounts WHERE Account_ID = @AccountId";
        return await _connection.QueryFirstOrDefaultAsync<Account>(sql, new { AccountId = accountId });
    }

    public async Task<bool> CreateAccountAsync(Account account)
    {
        const string sql = @"
            INSERT INTO Accounts (
                Account_ID, Salutation, FirstName, MiddleName, LastName, 
                GroupID, IsCustomer, CreatedOn, LastUpdated
            ) VALUES (
                @Account_ID, @Salutation, @FirstName, @MiddleName, @LastName,
                @GroupID, @IsCustomer, @CreatedOn, @LastUpdated
            )";

        var result = await _connection.ExecuteAsync(sql, account);
        return result > 0;
    }

    public async Task<bool> UpdateAccountAsync(Account account)
    {
        const string sql = @"
            UPDATE Accounts SET
                Salutation = @Salutation,
                FirstName = @FirstName,
                MiddleName = @MiddleName,
                LastName = @LastName,
                GroupID = @GroupID,
                LastUpdated = @LastUpdated
            WHERE Account_ID = @Account_ID";

        var result = await _connection.ExecuteAsync(sql, account);
        return result > 0;
    }

    public async Task<bool> DeleteAccountAsync(string accountId)
    {
        const string sql = "DELETE FROM Accounts WHERE Account_ID = @AccountId";
        var result = await _connection.ExecuteAsync(sql, new { AccountId = accountId });
        return result > 0;
    }
}