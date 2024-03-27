using Core.DataCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Bvadmin.Interfaces
    {
    internal interface IInvoices
        {
        public Task<bool> createInvoice(Invoice invoice);
        public Task<bool> deleteInvoice(int invoiceid);
        public Task<bool> updateInvoice(Invoice invoice);
        public Task<Invoice> getInvoice(int invoiceid);
        public Task<bool> createInvoicerow(Invoicerow invoicerow);
        public Task<bool> deleteInvoicerow(int invoicerowId);
        public Task<bool> updateInvoicerow(Invoicerow invoicerow);
        public Task<Invoicerow> getInvoicerow(int invoicerowId);
        public Task<bool> createOvrabatt(Ovrabatt ovrabatt);
        public Task<bool> deleteOvrabatt(int ovrabattId);
        public Task<bool> updateOvrabatt(Ovrabatt ovrabatt);
        public Task<Ovrabatt> getOvrabatt(int ovrabattId);
        public Task<Invoice> FindInvoice(Param SearchParam);
        public Task<Invoicerow> FindInvoicerow(Param SearchParam);
        public Task<Ovrabatt> FindOvrabatt(Param SearchParam);

        }
    }
