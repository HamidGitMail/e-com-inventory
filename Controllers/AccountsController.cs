namespace HCS_Inventory_Api.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HCS_Inventory_Api.Models;
using HCS_Inventory_Api.Repositories;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class AccountsController : ControllerBase
{
    private readonly IAccountRepository _accountRepository;

    public AccountsController(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var accounts = await _accountRepository.GetAllAccountsAsync();
        return Ok(accounts);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var account = await _accountRepository.GetAccountByIdAsync(id);
        
        if (account == null)
        {
            return NotFound();
        }

        return Ok(account);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Account account)
    {
        account.CreatedOn = DateTime.UtcNow;
        account.LastUpdated = DateTime.UtcNow;
        
        var result = await _accountRepository.CreateAccountAsync(account);
        
        if (!result)
        {
            return BadRequest(new { message = "Failed to create account" });
        }

        return CreatedAtAction(nameof(GetById), new { id = account.Account_ID }, account);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, [FromBody] Account account)
    {
        if (id != account.Account_ID)
        {
            return BadRequest(new { message = "ID mismatch" });
        }

        account.LastUpdated = DateTime.UtcNow;
        
        var result = await _accountRepository.UpdateAccountAsync(account);
        
        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _accountRepository.DeleteAccountAsync(id);
        
        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }
}