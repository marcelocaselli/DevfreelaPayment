using Devfreela.Payments.API.Models;

namespace Devfreela.Payments.API.Services
{
    public class PaymentService : IPaymentService
    {
        public Task<bool> Proccess(PaymentInfoInputModel model)
        {
            return Task.FromResult(true);
        }
    }
}
