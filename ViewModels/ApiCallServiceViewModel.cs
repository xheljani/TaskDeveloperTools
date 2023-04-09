using System.Collections.Generic;

namespace MvcCodeFlowClientManual.ViewModels
{
    public class ApiCallServiceViewModel
    {
        public IEnumerable<AccountViewModel> MyAccounts { get; set; }
    }

    public class AccountViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Classification { get; set; }
        public string AccountSubType { get; set; }
        public string AccountType { get; set; }
        public string CurrentBalance { get; set; }
        
    }
}
