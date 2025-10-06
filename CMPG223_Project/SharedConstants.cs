using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPG223_Project
{
    public static class SharedConstants
    {
       // public static string connString = "Data Source=DESKTOP-79PMUBS;Initial Catalog=Shelter;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private static string dataSource = "\"localhost, 1433\"";
        public static string connString = $"Data Source={dataSource};Initial Catalog=Shelter; Persist Security Info=True; User ID=sa;Password=Password!; TrustServerCertificate=True";
    }
}
