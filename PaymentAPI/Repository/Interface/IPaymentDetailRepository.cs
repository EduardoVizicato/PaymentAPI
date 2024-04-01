using PaymentAPI.Models;

namespace PaymentAPI.Repository.Interface
{
    public interface IPaymentDetailRepository
    {
        Task<List<PaymentDetailModel>> GetAllPaymentDetails();

        Task<PaymentDetailModel> GetPaymentDetailByID(int id);

        Task<PaymentDetailModel> AddPaymentDetail(PaymentDetailModel paymentDetail);

        Task<PaymentDetailModel> UpdatePaymentDetail(PaymentDetailModel paymentDetail, int id);

        Task<bool> DeletePaymentDetail(int id);
    }
}
