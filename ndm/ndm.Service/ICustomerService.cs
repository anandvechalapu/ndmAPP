namespace ndm.Service
{
    using ndm.DTO;

    public interface ICustomerService
    {
        Task<Customer> GetCustomerByIdAsync(int id);
        Task SaveCustomerAsync(Customer customer);
    }
}