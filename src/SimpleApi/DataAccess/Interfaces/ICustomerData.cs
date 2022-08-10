using Refit;
using SimpleApi.Model;

namespace SimpleApi.DataAccess.Interfaces
{
    public interface ICustomerData
    {
        [Get("/api/Customers/{id}")]
        Task<Customer> GetCustomerById(int id);
    }
}
