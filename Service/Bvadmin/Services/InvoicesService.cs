using Core.DataCore;
using Data;
using Microsoft.EntityFrameworkCore;
using Service.Bvadmin.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Bvadmin.Services
    {
    internal class InvoicesService : IInvoices
        {
        private readonly ApplicationDbContext _ApplicationDbContext;
        public InvoicesService(ApplicationDbContext applicationDbContext)
            {
            _ApplicationDbContext=applicationDbContext;
            }
public async Task<bool> createInvoice(Invoice invoice)
            {
            try
                {
                await _ApplicationDbContext.Invoices.AddAsync(invoice);
                await _ApplicationDbContext.SaveChangesAsync();
                return true;
                }
            catch (Exception ex)
                {
                return false;
                }
            }

        public async Task<bool> createInvoicerow(Invoicerow invoicerow)
            {
            try
                {
                await _ApplicationDbContext.Invoicerows.AddAsync(invoicerow);
                await _ApplicationDbContext.SaveChangesAsync();
                return true;
                }
            catch (Exception ex)
                {
                return false; 
                }
            }

        public async Task<bool> createOvrabatt(Ovrabatt ovrabatt)
            {
            try { 
            await _ApplicationDbContext.Ovrabatts.AddAsync(ovrabatt);
            await _ApplicationDbContext.SaveChangesAsync();
            return true;
                }
            catch (Exception ex)
                {
                return false;
                }
            }

        public async Task<bool> deleteInvoice(int invoiceId)
            {
            var invoice = await _ApplicationDbContext.Invoices.FindAsync(invoiceId);
            if (invoice != null)
                {
                _ApplicationDbContext.Invoices.Remove(invoice);
                await _ApplicationDbContext.SaveChangesAsync();
                return true; 
                }
            return false;   
            }

        public async Task<bool> deleteInvoicerow(int invoicerowId)
            {
            var Invoicerows = await _ApplicationDbContext.Invoicerows.FindAsync(invoicerowId);
            if (Invoicerows != null)
                {
                _ApplicationDbContext.Invoicerows.Remove(Invoicerows);
                await _ApplicationDbContext.SaveChangesAsync();
                return true;
                }
            return false;
            }

        public async Task<bool> deleteOvrabatt(int ovrabattId)
            {
            var Ovrabatts = await _ApplicationDbContext.Ovrabatts.FindAsync(ovrabattId);
            if (Ovrabatts != null)
                {
                _ApplicationDbContext.Ovrabatts.Remove(Ovrabatts);
                await _ApplicationDbContext.SaveChangesAsync();
                return true;
                }
            return false;
            }

        public async Task<Invoice> FindInvoice(Param SearchParam)
            {
            IQueryable<Invoice> query = _ApplicationDbContext.Invoices;

            if (SearchParam.Id.HasValue)
                {
                query = query.Where(i => i.Id == SearchParam.Id);
                }

            if (!string.IsNullOrEmpty(SearchParam.Code))
                {
                query = query.Where(i => i.Customerid == SearchParam.Customerid);
                }

            if (!string.IsNullOrEmpty(SearchParam.Name))
                {
                query = query.Where(i => i.Name == SearchParam.Name);
                }

            return await query.FirstOrDefaultAsync();
            }

        public Task<Invoicerow> FindInvoicerow(Param SearchParam)
            {
            throw new NotImplementedException();
            }

        public Task<Ovrabatt> FindOvrabatt(Param SearchParam)
            {
            throw new NotImplementedException();
            }

        public async Task<Invoice> getInvoice(int invoiceId)
            {
            return await _ApplicationDbContext.Invoices.FindAsync(invoiceId);
            }

        public Task<Invoicerow> getInvoicerow(int invoicerowId)
            {
            throw new NotImplementedException();
            }

        public Task<Ovrabatt> getOvrabatt(int ovrabattId)
            {
            throw new NotImplementedException();
            }

        public async Task<bool> updateInvoice(Invoice invoice)
            {
            try
                {
                var existingInvoice = await _ApplicationDbContext.Invoices.FindAsync(invoice.Id);
                if (existingInvoice == null)
                    return false;
                existingInvoice=invoice;
                await _ApplicationDbContext.SaveChangesAsync();

                return true;
                }
            catch (Exception)
                {
                return false;
                }

            }

        public async Task<bool> updateInvoicerow(Invoicerow invoicerow)
            {
            try
                {
                var existingInvoiceRow = await _ApplicationDbContext.Invoicerows.FindAsync(invoicerow.Id);
                if (existingInvoiceRow == null)
                    return false;

                existingInvoiceRow = invoicerow;
                await _ApplicationDbContext.SaveChangesAsync();

                return true; 
                }
            catch (Exception)
                {
                return false;
                }
            }

        public async Task<bool> updateOvrabatt(Ovrabatt ovrabatt)
            {
            try
                {
                var existingDiscount = await _ApplicationDbContext.Ovrabatts.FindAsync(ovrabatt.Id);

                if (existingDiscount == null)
                    return false;
                existingDiscount=ovrabatt;
                await _ApplicationDbContext.SaveChangesAsync();

                return true; 
                }
            catch (Exception)
                {
                return false;
                }
            }
        }
    }
