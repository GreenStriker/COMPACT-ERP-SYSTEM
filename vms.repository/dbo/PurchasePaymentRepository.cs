﻿using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using vms.entity.models;
using vms.entity.viewModels;

namespace vms.repository.dbo
{
    public interface IPurchasePaymentRepository : IRepositoryBase<PurchasePayment>
    {
        Task<IEnumerable<PurchasePayment>> GetAll();
        Task<PurchasePayment> GetById(int id);
    }
    public class PurchasePaymentRepository : RepositoryBase<PurchasePayment>, IPurchasePaymentRepository
    {
        private readonly DbContext _context;
        private readonly IDataProtectionProvider _protectionProvider;
        private readonly PurposeStringConstants _purposeStringConstants;
        private IDataProtector _dataProtector;
        public PurchasePaymentRepository(DbContext context, IDataProtectionProvider p_protectionProvider, PurposeStringConstants p_purposeStringConstants) : base(context)
        {
            this._context = context;
            _protectionProvider = p_protectionProvider;
            _purposeStringConstants = p_purposeStringConstants;
            _dataProtector = _protectionProvider.CreateProtector(_purposeStringConstants.UserIdQueryString);
        }
        public async Task<IEnumerable<PurchasePayment>> GetAll()
        {
            var data = await this.Query().SelectAsync();

            return data;
        }
        public async Task<PurchasePayment> GetById(int ids)
        {
            int id = ids;
            var data = await this.Query().SingleOrDefaultAsync(x => x.PurchasePaymentId == id, System.Threading.CancellationToken.None);
            return data;
        }
    }
   
}
