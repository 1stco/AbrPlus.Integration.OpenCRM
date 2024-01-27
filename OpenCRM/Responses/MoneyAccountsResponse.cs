using System.Collections.Generic;

namespace AbrPlus.Integration.OpenCRM.Responses
{
    public class MoneyAccountsResponse
    {
        public MoneyAccountsResponse()
        {
            MoneyAccounts = new List<MoneyAccountResponse>();
        }
        public List<MoneyAccountResponse> MoneyAccounts { get; set; }
    }
}