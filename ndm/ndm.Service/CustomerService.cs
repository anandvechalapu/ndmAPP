namespace ndm.Service
{
    using ndm.DataAccess;
    using ndm.DTO;
    using System.Threading.Tasks;

    public class CustomerService : ICustomerService
    {
        private ICustomerDataAccess _customerDataAccess;

        public CustomerService(ICustomerDataAccess customerDataAccess)
        {
            _customerDataAccess = customerDataAccess;
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            // Implementation logic goes here
        }

        public async Task SaveCustomerAsync(Customer customer)
        {
            // Implementation logic goes here
        }
    }
}