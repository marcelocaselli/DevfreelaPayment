using Devfreela.Payments.API.Models;

namespace Devfreela.Payments.API.Services
{
    public interface IPaymentService
    {
        Task<bool> Proccess(PaymentInfoInputModel model);
    }
}
