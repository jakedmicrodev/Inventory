using System;
using System.Configuration;

namespace Business.Core
{
    public static class Settings
    {
        private static string inventoryConnectionString = string.Empty;

        public static string JobSearchConnectionString
        {
            get
            {
                if (String.IsNullOrWhiteSpace(inventoryConnectionString))
                {
                    inventoryConnectionString = ConfigurationManager.ConnectionStrings["INVENTORY"].ToString();
                }
                return inventoryConnectionString;
            }
        }
    }
}