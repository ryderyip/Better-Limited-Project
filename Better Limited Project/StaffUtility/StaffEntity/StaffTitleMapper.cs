using System.Collections.Generic;

namespace Better_Limited_Project.StaffUtility.StaffEntity
{
    /// <summary>
    /// To map staff title enum to string and vise versa
    /// </summary>
    public class StaffTitleMapper
    {
        private const string SalesRepresentative = "Sales Representative";
        private const string SalesManager = "Sales Manager";
        private const string AccountingClerk = "Accounting Clerk";
        private const string AccountingManager = "Accounting Manager";
        private const string PurchaseClerk = "Purchase Clerk";
        private const string PurchaseManager = "Purchase Manager";
        private const string InventoryClerk = "Inventory Clerk";
        private const string ReceivingClerk = "Receiving Clerk";
        private const string TechnicalSupportClerk = "Technical Support Clerk";
        private const string TechnicalSupportManager = "Technical Support Manager";
        private const string UnknownTitle = "Unknown Title";
        
        private readonly Dictionary<StaffTitle, string> _enumToString = new();
        private readonly Dictionary<string, StaffTitle> _stringToEnum = new();

        public StaffTitleMapper()
        {
            InitializeEnumToStringDictionary();
            InitializeStringToEnumDictionary();
        }
        
        /// <summary>
        /// Map from title name to title enum
        /// </summary>
        /// <returns>Staff title enum</returns>
        public StaffTitle Map(string title)
        {
            title = title.ToLower();
            if (string.IsNullOrWhiteSpace(title) || !_stringToEnum.ContainsKey(title))
                return StaffTitle.Unknown;
            return _stringToEnum[title];
        }

        /// <summary>
        /// Map from title enum to title name
        /// </summary>
        /// <returns>Staff title separated by a space</returns>
        public string Map(StaffTitle title)
        {
            if (title == StaffTitle.Unknown)
                return UnknownTitle;
            return _enumToString[title];
        }

        private void InitializeEnumToStringDictionary()
        {
            _enumToString.Add(StaffTitle.SalesRepresentative, SalesRepresentative);
            _enumToString.Add(StaffTitle.SalesManager, SalesManager);
            _enumToString.Add(StaffTitle.AccountingClerk, AccountingClerk);
            _enumToString.Add(StaffTitle.AccountingManager, AccountingManager);
            _enumToString.Add(StaffTitle.PurchaseClerk, PurchaseClerk);
            _enumToString.Add(StaffTitle.PurchaseManager, PurchaseManager);
            _enumToString.Add(StaffTitle.InventoryClerk, InventoryClerk);
            _enumToString.Add(StaffTitle.ReceivingClerk, ReceivingClerk);
            _enumToString.Add(StaffTitle.TechnicalSupportClerk, TechnicalSupportClerk);
            _enumToString.Add(StaffTitle.TechnicalSupportManager, TechnicalSupportManager);
        }

        private void InitializeStringToEnumDictionary()
        {
            _stringToEnum.Add(SalesRepresentative.ToLower(), StaffTitle.SalesRepresentative);
            _stringToEnum.Add(SalesManager.ToLower(), StaffTitle.SalesManager);
            _stringToEnum.Add(AccountingClerk.ToLower(), StaffTitle.AccountingClerk);
            _stringToEnum.Add(AccountingManager.ToLower(), StaffTitle.AccountingManager);
            _stringToEnum.Add(PurchaseClerk.ToLower(), StaffTitle.PurchaseClerk);
            _stringToEnum.Add(PurchaseManager.ToLower(), StaffTitle.PurchaseManager);
            _stringToEnum.Add(InventoryClerk.ToLower(), StaffTitle.InventoryClerk);
            _stringToEnum.Add(ReceivingClerk.ToLower(), StaffTitle.ReceivingClerk);
            _stringToEnum.Add(TechnicalSupportClerk.ToLower(), StaffTitle.TechnicalSupportClerk);
            _stringToEnum.Add(TechnicalSupportManager.ToLower(), StaffTitle.TechnicalSupportManager);
        }
    }
}