using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPG223_Project
{
    public static class SharedConstants
    {
        //private static string dataSource = "DESKTOP-79PMUBS";
        private static string dataSource = "\"localhost, 1433\"";
        public static string connString = $"Data Source={dataSource};Initial Catalog=Shelter; Persist Security Info=True; User ID=sa;Password=Password!; TrustServerCertificate=True";
    }
}
