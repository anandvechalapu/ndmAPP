using

namespace ndm.Service
{
    using ndm.DTO;
    public interface ICustomerService
    {
        Customer GetCustomerByID(int customerId);
        List<Customer> GetCustomers();
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int customerId);
    }
}