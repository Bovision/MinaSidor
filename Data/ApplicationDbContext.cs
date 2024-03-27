using Core.DataCore;
using Core.Models;
using Core.Models.User;
using Core.Models.UserModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("invoice");

                entity.HasIndex(e => e.Customerid, "IX_invoice_customerid");

                entity.HasIndex(e => e.Invoiceid, "IX_invoice_invoiceid");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .HasColumnName("address1");
                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .HasColumnName("address2");
                entity.Property(e => e.Address3)
                    .HasMaxLength(255)
                    .HasColumnName("address3");
                entity.Property(e => e.Claim)
                    .HasColumnType("datetime")
                    .HasColumnName("claim");
                entity.Property(e => e.Countrycode)
                    .HasMaxLength(255)
                    .HasColumnName("countrycode");
                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Credit)
                    .HasColumnType("datetime")
                    .HasColumnName("credit");
                entity.Property(e => e.Currency)
                    .HasMaxLength(255)
                    .HasColumnName("currency");
                entity.Property(e => e.Customerid).HasColumnName("customerid");
                entity.Property(e => e.Customervat)
                    .HasMaxLength(255)
                    .HasColumnName("customervat");
                entity.Property(e => e.Deleted)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted");
                entity.Property(e => e.Deliveryaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("deliveryaddress1");
                entity.Property(e => e.Deliveryaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("deliveryaddress2");
                entity.Property(e => e.Deliveryaddress3)
                    .HasMaxLength(255)
                    .HasColumnName("deliveryaddress3");
                entity.Property(e => e.Deliverycountrycode)
                    .HasMaxLength(2)
                    .HasColumnName("deliverycountrycode");
                entity.Property(e => e.Deliverymode)
                    .HasMaxLength(255)
                    .HasColumnName("deliverymode");
                entity.Property(e => e.Deliveryname)
                    .HasMaxLength(255)
                    .HasColumnName("deliveryname");
                entity.Property(e => e.Deliverypostalarea)
                    .HasMaxLength(255)
                    .HasColumnName("deliverypostalarea");
                entity.Property(e => e.Deliverypostalcode)
                    .HasMaxLength(40)
                    .HasColumnName("deliverypostalcode");
                entity.Property(e => e.Deliveryterms)
                    .HasMaxLength(255)
                    .HasColumnName("deliveryterms");
                entity.Property(e => e.Domicile)
                    .HasMaxLength(255)
                    .HasColumnName("domicile");
                entity.Property(e => e.Duedate)
                    .HasColumnType("datetime")
                    .HasColumnName("duedate");
                entity.Property(e => e.Evenout).HasColumnName("evenout");
                entity.Property(e => e.Expfee).HasColumnName("expfee");
                entity.Property(e => e.ExternalId)
                    .HasMaxLength(40)
                    .HasDefaultValue("")
                    .IsFixedLength();
                entity.Property(e => e.ExternalSystem)
                    .HasMaxLength(50)
                    .HasDefaultValue("");
                entity.Property(e => e.Freight).HasColumnName("freight");
                entity.Property(e => e.Invoicedate)
                    .HasColumnType("datetime")
                    .HasColumnName("invoicedate");
                entity.Property(e => e.Invoiceid).HasColumnName("invoiceid");
                entity.Property(e => e.Iscredit).HasColumnName("iscredit");
                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .HasColumnName("notes");
                entity.Property(e => e.Orderno)
                    .HasMaxLength(255)
                    .HasColumnName("orderno");
                entity.Property(e => e.Ourreference)
                    .HasMaxLength(255)
                    .HasColumnName("ourreference");
                entity.Property(e => e.Ourvat)
                    .HasMaxLength(255)
                    .HasColumnName("ourvat");
                entity.Property(e => e.Payed)
                    .HasColumnType("datetime")
                    .HasColumnName("payed");
                entity.Property(e => e.Postalarea)
                    .HasMaxLength(255)
                    .HasColumnName("postalarea");
                entity.Property(e => e.Postalcode)
                    .HasMaxLength(40)
                    .HasColumnName("postalcode");
                entity.Property(e => e.Reference)
                    .HasMaxLength(255)
                    .HasColumnName("reference");
                entity.Property(e => e.Reminder)
                    .HasColumnType("datetime")
                    .HasColumnName("reminder");
                entity.Property(e => e.Sent)
                    .HasColumnType("datetime")
                    .HasColumnName("sent");
                entity.Property(e => e.Sum).HasColumnName("sum");
                entity.Property(e => e.Termspayment)
                    .HasMaxLength(255)
                    .HasColumnName("termspayment");
                entity.Property(e => e.Totalsum).HasColumnName("totalsum");
                entity.Property(e => e.Vat).HasColumnName("vat");

                entity.HasOne(d => d.Customer).WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_invoice_customer");
            });



            modelBuilder.Entity<Invoicematerial>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__invoicem__3213E83F0ECEE4C9");

                entity.ToTable("invoicematerial");

                entity.HasIndex(e => e.Customerid, "IX_invoicematerial_customerid");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Amount).HasColumnName("amount");
                entity.Property(e => e.Created).HasColumnName("created");
                entity.Property(e => e.Currencycode)
                    .HasMaxLength(255)
                    .HasColumnName("currencycode");
                entity.Property(e => e.Customerid).HasColumnName("customerid");
                entity.Property(e => e.Details)
                    .HasMaxLength(255)
                    .HasColumnName("details");
                entity.Property(e => e.Discountamount).HasColumnName("discountamount");
                entity.Property(e => e.Invoiceid).HasColumnName("invoiceid");
                entity.Property(e => e.Invoiceto).HasColumnName("invoiceto");
                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.Period).HasColumnName("period");
                entity.Property(e => e.Productcode)
                    .HasMaxLength(255)
                    .HasColumnName("productcode");
                entity.Property(e => e.Productid).HasColumnName("productid");
                entity.Property(e => e.Quantity).HasColumnName("quantity");
                entity.Property(e => e.Reference)
                    .HasMaxLength(100)
                    .HasColumnName("reference");
                entity.Property(e => e.Sent)
                    .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                    .HasColumnName("sent");
                entity.Property(e => e.Unit)
                    .HasMaxLength(255)
                    .HasColumnName("unit");
                entity.Property(e => e.Vatpct).HasColumnName("vatpct");
            });

            modelBuilder.Entity<Invoicerow>(entity =>
            {
                entity.ToTable("invoicerow");

                entity.HasIndex(e => e.Invoiceid, "IX_invoicerow_invoiceid");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code");
                entity.Property(e => e.Currency)
                    .HasMaxLength(255)
                    .HasColumnName("currency");
                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");
                entity.Property(e => e.Discount)
                    .HasDefaultValueSql("((0.0))")
                    .HasColumnName("discount");
                entity.Property(e => e.Invoiceid).HasColumnName("invoiceid");
                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.Price).HasColumnName("price");
                entity.Property(e => e.Quantity).HasColumnName("quantity");
                entity.Property(e => e.Unit)
                    .HasMaxLength(255)
                    .HasColumnName("unit");
                entity.Property(e => e.Vatpct).HasColumnName("vatpct");
            });
            modelBuilder.Entity<Orderitem>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__orderite__3213E83F5B844AED");

                entity.ToTable("orderitem", tb => tb.HasTrigger("TR_OrderItem"));

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Active).HasComputedColumnSql("(CONVERT([bit],case when [deleted]<='1901-01-01' AND ([contractends]<='1901-01-01' OR [contractends]>getdate()) AND ([contractstarts]<='1901-01-01' OR [contractstarts]<getdate()) then (1) else (0) end,0))", false);
                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .HasColumnName("address1");
                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .HasColumnName("address2");
                entity.Property(e => e.Address3)
                    .HasMaxLength(255)
                    .HasColumnName("address3");
                entity.Property(e => e.Bywho)
                    .HasMaxLength(255)
                    .HasColumnName("bywho");
                entity.Property(e => e.Contractends)
                    .HasColumnType("datetime")
                    .HasColumnName("contractends");
                entity.Property(e => e.Contractstarts)
                    .HasColumnType("datetime")
                    .HasColumnName("contractstarts");
                entity.Property(e => e.Countrycode)
                    .HasMaxLength(2)
                    .HasColumnName("countrycode");
                entity.Property(e => e.Currency)
                    .HasMaxLength(255)
                    .HasColumnName("currency");
                entity.Property(e => e.Customerid).HasColumnName("customerid");
                entity.Property(e => e.Deleted)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted");
                entity.Property(e => e.Discount).HasColumnName("discount");
                entity.Property(e => e.How)
                    .HasMaxLength(255)
                    .HasColumnName("how");
                entity.Property(e => e.Invoicecyclesinmonths).HasColumnName("invoicecyclesinmonths");
                entity.Property(e => e.Invoiceto).HasColumnName("invoiceto");
                entity.Property(e => e.Orderdate)
                    .HasColumnType("datetime")
                    .HasColumnName("orderdate");
                entity.Property(e => e.Ordernr)
                    .HasMaxLength(255)
                    .HasColumnName("ordernr");
                entity.Property(e => e.Postalarea)
                    .HasMaxLength(255)
                    .HasColumnName("postalarea");
                entity.Property(e => e.Postalcode)
                    .HasMaxLength(40)
                    .HasColumnName("postalcode");
                entity.Property(e => e.Productid).HasColumnName("productid");
                entity.Property(e => e.Reference)
                    .HasMaxLength(255)
                    .HasColumnName("reference");
                entity.Property(e => e.Specialprice).HasColumnName("specialprice");
                entity.Property(e => e.Vatid).HasColumnName("vatid");

                entity.HasOne(d => d.Product).WithMany(p => p.Orderitems)
                    .HasForeignKey(d => d.Productid)
                    .HasConstraintName("fk_orderitem_product");
            });


            modelBuilder.Entity<Ovfakturahistorik>(entity =>
            {
                entity.HasKey(e => new { e.Year, e.Month, e.NMaklarid }).HasName("PK__OVFAKTURAHISTORI__481183C6");

                entity.ToTable("OVFAKTURAHISTORIK");

                entity.Property(e => e.Year).HasColumnName("YEAR");
                entity.Property(e => e.Month).HasColumnName("MONTH");
                entity.Property(e => e.NMaklarid).HasColumnName("N_MAKLARID");
                entity.Property(e => e.NAntal).HasColumnName("N_ANTAL");
                entity.Property(e => e.NOvAnnonspaket).HasColumnName("N_OV_ANNONSPAKET");
                entity.Property(e => e.NSumma).HasColumnName("N_SUMMA");
            });

            modelBuilder.Entity<Ovfakturaunderlag>(entity =>
            {
                entity.HasKey(e => e.LOvfakturaunderlagId);

                entity.ToTable("OVFakturaunderlag");

                entity.HasIndex(e => new { e.NMaklarid, e.DatDatum, e.LObjektnr, e.NFakturatyp }, "IDX_OVFakturaunderlag_MaklaridDatumObjektnr")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.LOvfakturaunderlagId).HasColumnName("l_OVFakturaunderlagID");
                entity.Property(e => e.BFakturerad).HasColumnName("b_fakturerad");
                entity.Property(e => e.DatDatum)
                    .HasDefaultValueSql("(convert(datetime,(convert(varchar(10),getdate(),102) + ' 00:00:00')))")
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dat_datum");
                entity.Property(e => e.DatFakturadatum)
                    .HasColumnType("datetime")
                    .HasColumnName("dat_fakturadatum");
                entity.Property(e => e.DatStop)
                    .HasColumnType("datetime")
                    .HasColumnName("DAT_STOP");
                entity.Property(e => e.LObjektnr).HasColumnName("l_objektnr");
                entity.Property(e => e.NFakturatyp)
                    .HasDefaultValue((short)1)
                    .HasColumnName("n_fakturatyp");
                entity.Property(e => e.NLankom).HasColumnName("n_lankom");
                entity.Property(e => e.NMaklarid).HasColumnName("n_maklarid");
                entity.Property(e => e.NTyp).HasColumnName("n_typ");
                entity.Property(e => e.SAdress)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("s_adress");
                entity.Property(e => e.SOmrade)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("s_omrade");
            });

            modelBuilder.Entity<Ovrabatt>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__OVRabatt__3214EC276BBAB2B6");

                entity.ToTable("OVRabatt");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.BAktiv).HasColumnName("b_aktiv");
                entity.Property(e => e.DatAndrad)
                    .HasColumnType("datetime")
                    .HasColumnName("dat_andrad");
                entity.Property(e => e.DatSkapad)
                    .HasColumnType("datetime")
                    .HasColumnName("dat_skapad");
                entity.Property(e => e.DatUpphor)
                    .HasColumnType("datetime")
                    .HasColumnName("DAT_UPPHOR");
                entity.Property(e => e.NMaklarid).HasColumnName("n_maklarid");
                entity.Property(e => e.Pakettyp).HasColumnName("PAKETTYP");
                entity.Property(e => e.Rabattprocent).HasColumnName("RABATTPROCENT");
                entity.Property(e => e.RabattprocentInfo).HasColumnName("RABATTPROCENT_INFO");
                entity.Property(e => e.SKommentar)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("s_kommentar");
            });
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__customer__3213E83F29ECEF59");

                entity.ToTable("customer", tb =>
                {
                    tb.HasTrigger("TR_Customer_DeleteEvent");
                    tb.HasTrigger("TR_Customer_InsertEvent");
                    tb.HasTrigger("TR_Customer_UpdateEvent");
                });

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .HasColumnName("address1");
                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .HasColumnName("address2");
                entity.Property(e => e.Address3)
                    .HasMaxLength(255)
                    .HasColumnName("address3");
                entity.Property(e => e.ContactName).HasMaxLength(255);
                entity.Property(e => e.Contactemail)
                    .HasMaxLength(255)
                    .HasColumnName("contactemail");
                entity.Property(e => e.Countrycode)
                    .HasMaxLength(2)
                    .HasColumnName("countrycode");
                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasColumnName("currency");
                entity.Property(e => e.Deliveryaddress1)
                    .HasMaxLength(255)
                    .HasColumnName("deliveryaddress1");
                entity.Property(e => e.Deliveryaddress2)
                    .HasMaxLength(255)
                    .HasColumnName("deliveryaddress2");
                entity.Property(e => e.Deliveryaddress3)
                    .HasMaxLength(255)
                    .HasColumnName("deliveryaddress3");
                entity.Property(e => e.Deliverycountrycode)
                    .HasMaxLength(2)
                    .HasColumnName("deliverycountrycode");
                entity.Property(e => e.Deliverypostalarea)
                    .HasMaxLength(255)
                    .HasColumnName("deliverypostalarea");
                entity.Property(e => e.Deliverypostalcode)
                    .HasMaxLength(40)
                    .HasColumnName("deliverypostalcode");
                entity.Property(e => e.Export).HasColumnName("export");
                entity.Property(e => e.Fax)
                    .HasMaxLength(40)
                    .HasColumnName("fax");
                entity.Property(e => e.InvoiceEmail).HasMaxLength(120);
                entity.Property(e => e.InvoicedAmount2015).HasDefaultValue(0);
                entity.Property(e => e.Logotype).HasMaxLength(250);
                entity.Property(e => e.Mailingemail)
                    .HasMaxLength(255)
                    .HasColumnName("mailingemail");
                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.Orgnr)
                    .HasMaxLength(255)
                    .HasColumnName("orgnr");
                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");
                entity.Property(e => e.Passwordservices)
                    .HasMaxLength(255)
                    .HasColumnName("passwordservices");
                entity.Property(e => e.Phone)
                    .HasMaxLength(40)
                    .HasColumnName("phone");
                entity.Property(e => e.Postalarea)
                    .HasMaxLength(255)
                    .HasColumnName("postalarea");
                entity.Property(e => e.Postalcode)
                    .HasMaxLength(40)
                    .HasColumnName("postalcode");
                entity.Property(e => e.SpecialDiscount).HasDefaultValueSql("((0.0))");
                entity.Property(e => e.System).HasMaxLength(50);
                entity.Property(e => e.Vatno)
                    .HasMaxLength(255)
                    .HasColumnName("vatno");
                entity.Property(e => e.Webadress)
                    .HasMaxLength(255)
                    .HasColumnName("webadress");
            });


            modelBuilder.Entity<Customergroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__customer__3213E83F455FFFA4");

                entity.ToTable("customergroup");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Created).HasColumnName("created");
                entity.Property(e => e.Customerid).HasColumnName("customerid");
                entity.Property(e => e.Groupid).HasColumnName("groupid");
            });

            modelBuilder.Entity<Customernote>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__customer__3213E83F318E1121");

                entity.ToTable("customernote");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Createdby)
                    .HasMaxLength(255)
                    .HasColumnName("createdby");
                entity.Property(e => e.Customerid).HasColumnName("customerid");
                entity.Property(e => e.Deleted)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted");
                entity.Property(e => e.Text)
                    .HasMaxLength(512)
                    .HasColumnName("text");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__product__3213E83F57B3BA09");

                entity.ToTable("product");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code");
                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasColumnName("currency");
                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");
                entity.Property(e => e.InvoiceCyclesInMoths).HasDefaultValue(1);
                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .HasColumnName("notes");
                entity.Property(e => e.Price).HasColumnName("price");
                entity.Property(e => e.Pricetype).HasColumnName("pricetype");
                entity.Property(e => e.Rules)
                    .HasMaxLength(2000)
                    .HasColumnName("rules");
                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");
                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasColumnName("unit");
                entity.Property(e => e.Vatid).HasColumnName("vatid");
            });

            modelBuilder.Entity<ProductPrice>(entity =>
            {
                entity.ToTable("ProductPrice");

                entity.HasIndex(e => e.ProductId, "ix_ProductId");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
                {
                Id = RoleaUser,
                Name = "User",
                NormalizedName = "User"

                });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
                {
                Id = Roleadmin,
                Name = "Administrator",
                NormalizedName = "Administrator"

                });

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
                {

                Id = userid,
                Email = "admin@bovision.se",
                NormalizedEmail = "admin@bovision.se",
                UserName = "admin@bovision.se",
                NormalizedUserName = "admin@bovision.se",
                PasswordHash = hasher.HashPassword(null, "bovision"),


                });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
                {
                RoleId = Roleadmin,
                UserId = userid

                });
            base.OnModelCreating(modelBuilder);
            }
        PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

        string Roleadmin = Guid.NewGuid().ToString();
        string RoleaUser = Guid.NewGuid().ToString();
        string userid = Guid.NewGuid().ToString();
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Officeaffiliation> OfficeAffiliations { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Customergroup> Customergroups { get; set; }
        public virtual DbSet<Customernote> Customernotes { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Invoicematerial> Invoicematerials { get; set; }
        public virtual DbSet<Invoicerow> Invoicerows { get; set; }
        public virtual DbSet<Orderitem> Orderitems { get; set; }
        public virtual DbSet<Ovfakturahistorik> Ovfakturahistoriks { get; set; }
        public virtual DbSet<Ovfakturaunderlag> Ovfakturaunderlags { get; set; }
        public virtual DbSet<Ovrabatt> Ovrabatts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductPrice> ProductPrices { get; set; }



        }

    }
