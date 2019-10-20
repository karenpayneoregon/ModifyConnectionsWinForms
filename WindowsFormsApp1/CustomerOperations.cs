using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class CustomerOperations
    {
        public Customer GetCustomerByPrimaryKey(int identifier)
        {
            var customer = new Customer();

            using (var cn = new SqlConnection())
            {
                cn.ConnectionString = "Data Source=KARENS-PC;" +
                                      "Initial Catalog=NorthWind;" +
                                      "Integrated Security=True";

                var selectStatement = "SELECT FirstName, LastName " +
                                      "FROM Customers " +
                                      "WHERE ID = @Identifier";

                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = selectStatement;
                    cmd.Parameters.AddWithValue("@Identifier", identifier);

                    cn.Open();

                    var reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        customer.Identifier = identifier;
                        customer.FirstName = reader.GetString(0);
                        customer.LastName = reader.GetString(1);

                    }
                }
            }

            return customer;
        }
    }
}
