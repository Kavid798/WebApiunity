using System.Collections.Generic;
using WebApiunity.Models;

namespace WebApiunity.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);
    }
}