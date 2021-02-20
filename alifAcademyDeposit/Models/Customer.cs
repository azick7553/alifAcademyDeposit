using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace alifAcademyDeposit.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DocumentNumber { get; set; }

        public async Task<int> CreateCustomerAsync()
        {
            using (var con = SqlClientModel.GetNewSqlConnection())
            using(var command = new SqlCommand("INSERT INTO Customers(FirstName, LastName, MiddleName, DateOfBirth, DocumentNumber) " +
                "Values(@FirstName, @LastName, @MiddleName, @DateOfBirth, @DocumentNumber)", con))
            {
                try
                {
                    command.Parameters.AddWithValue("@FirstName", this.FirstName);
                    command.Parameters.AddWithValue("@LastName", this.LastName);
                    command.Parameters.AddWithValue("@MiddleName", this.MiddleName);
                    command.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
                    command.Parameters.AddWithValue("@DocumentNumber", this.DocumentNumber);

                    await con.OpenAsync();

                    var result =  await command.ExecuteNonQueryAsync();

                    return result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Customer adding fail - {ex.Message}");
                }
                finally
                {
                    con.Close();
                }
            }
            return 0;
        }
    }
}
