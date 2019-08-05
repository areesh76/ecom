using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Commerce.DataServices;

namespace eCommerce.CommonCode
{
    public class DataContextHelper
    {
        public static EcommerceConnectionStringDB GetCPDataContext(bool enableAutoSelect = true)
        {
            return (GetNewDataContext("EcommerceConnectionString", enableAutoSelect));
        }

        private static EcommerceConnectionStringDB GetNewDataContext(string connectionStringName, bool enableAutoSelect) {
            EcommerceConnectionStringDB repository = new EcommerceConnectionStringDB(connectionStringName);
            repository.EnableAutoSelect = enableAutoSelect;
            return (repository);
        }
    }
}