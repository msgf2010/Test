using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shortid;

namespace URLShortner.Data
{
    public class URLRepository
    {
        private string _connectionString;

        public URLRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

    }
}
