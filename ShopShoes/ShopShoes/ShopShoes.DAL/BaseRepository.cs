using System;
using System.Data;
using System.Data.SqlClient;

namespace ShopShoes.DAL
{
    public class BaseRepository
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connectString = @"Data Source=DESKTOP-IA5AG6P;Initial Catalog=SellShoes;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con = new SqlConnection(connectString);
        }
    }
}
