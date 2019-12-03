using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiunity.Models;

namespace WebApiunity.Repository
{
    public class CustomerRepositoryFromEF : ICustomerRepository
    {
        private Entities entities = null;

        public CustomerRepositoryFromEF()
        {
            entities = new Entities();
        }
        public IEnumerable<Customer> GetAll()
        {
            return entities.Customers.ToList();
        }
        public Customer GetById(int id)
        {
            return entities.Customers.SingleOrDefault(c => c.Id == id);
        }
    }

    }
