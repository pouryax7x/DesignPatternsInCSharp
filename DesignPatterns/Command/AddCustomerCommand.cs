namespace DesignPatterns.Command
{
    public class AddCustomerCommand : FrameWork.Command
    {
        private CustomerService service;

        public AddCustomerCommand(CustomerService service)
        {
            this.service = service;
        }

        public void Execute()
        {
            service.AddCustomer();
        }
    }
}