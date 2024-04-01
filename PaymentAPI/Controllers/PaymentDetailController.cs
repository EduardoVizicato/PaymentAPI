    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaymentAPI.Data;
using PaymentAPI.Models;
using PaymentAPI.Repository.Interface;

namespace PaymentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailController : ControllerBase
    {
        private readonly IPaymentDetailRepository _paymentDetailRepository;
        public PaymentDetailController(IPaymentDetailRepository paymentDetailRepository)
        {
            _paymentDetailRepository = paymentDetailRepository;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentDetailModel>>> GetAllPaymentDetail()
        {
            var paymentDetail = await _paymentDetailRepository.GetAllPaymentDetails();
            return Ok(paymentDetail);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentDetailModel>> GetPaymentDetailById(int id)
        {
            var paymentDetail = await _paymentDetailRepository.GetPaymentDetailByID(id);
            return Ok(paymentDetail);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePaymentDetailModel(int id, PaymentDetailModel paymentDetailModel)
        {
            paymentDetailModel.Id = id;
            var paymentDetail = await _paymentDetailRepository.UpdatePaymentDetail(paymentDetailModel, id);
            return Ok(paymentDetail);
        }

        [HttpPost]
        public async Task<ActionResult<PaymentDetailModel>> AddPaymentDetailModel(PaymentDetailModel paymentDetailModel)
        {
            var paymentDetail = await _paymentDetailRepository.AddPaymentDetail(paymentDetailModel);
            return Ok(paymentDetail);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaymentDetail(int id)
        {
            bool deleted = await _paymentDetailRepository.DeletePaymentDetail(id);
            return Ok(deleted);
        }


    }
}
