using Microsoft.EntityFrameworkCore;
using PaymentAPI.Data;
using PaymentAPI.Models;
using PaymentAPI.Repository.Interface;

namespace PaymentAPI.Repository
{
    public class PaymentDetailRepository : IPaymentDetailRepository
    {
        private readonly PaymentDetailContext _dbContext;
        public PaymentDetailRepository(PaymentDetailContext paymentDetailContext)
        {
            _dbContext = paymentDetailContext;
        }
        public async Task<PaymentDetailModel> AddPaymentDetail(PaymentDetailModel paymentDetail)
        {
            await _dbContext.AddAsync(paymentDetail);
            await _dbContext.SaveChangesAsync();

            return paymentDetail;
        }

        public async Task<bool> DeletePaymentDetail(int id)
        {
            var paymentDetailId = await GetPaymentDetailByID(id);

            if (paymentDetailId == null)
            {
                return false;
            }

            _dbContext.PaymentDetailAPI.Remove(paymentDetailId);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<PaymentDetailModel>> GetAllPaymentDetails()
        {
            return await _dbContext.PaymentDetailAPI.ToListAsync();
        }

        public async Task<PaymentDetailModel> GetPaymentDetailByID(int id)
        {
            return await _dbContext.PaymentDetailAPI.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<PaymentDetailModel> UpdatePaymentDetail(PaymentDetailModel paymentDetail, int id)
        {
            var paymentDetailId = await GetPaymentDetailByID(id);

            if (paymentDetailId == null)
            {
                throw new Exception($"Usuario para o ID: {id} não foi encontrado no Banco de Dados.");
            }

            paymentDetailId.CardOwnerName = paymentDetail.CardOwnerName;
            paymentDetailId.CardNumber = paymentDetail.CardNumber;
            paymentDetailId.ExpirationDate = paymentDetail.ExpirationDate;
            paymentDetailId.SecurityCode = paymentDetail.SecurityCode;

            _dbContext.PaymentDetailAPI.Update(paymentDetailId);
            _dbContext.SaveChanges();
            return paymentDetailId;
        }
    }
}
