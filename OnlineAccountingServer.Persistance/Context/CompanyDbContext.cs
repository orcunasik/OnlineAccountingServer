using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OnlineAccountingServer.Domain.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OnlineAccountingServer.Persistance.Context
{
    public sealed class CompanyDbContext : DbContext
    {
        private string ConnectionString = "";
        //private readonly AppDbContext _appDbContext;
        public CompanyDbContext(string companyId, Company company = null)
        {
            //_appDbContext = appDbContext;
            //Company company = _appDbContext.Companies.Find(companyId);
            if (company != null)
            {
                if (company.UserId == "")
                {
                    ConnectionString = @$"
                Data Source = {company.ServerName};
                Initial Catalog = {company.DatabaseName}; 
                Integrated Security = True; 
                Connect Timeout = 30; 
                Encrypt = False; 
                TrustServerCertificate = False; 
                ApplicationIntent = ReadWrite; 
                MultiSubnetFailover = False";
                }
                else
                {
                    ConnectionString = @$"
                Data Source = {company.ServerName}; 
                Initial Catalog = {company.DatabaseName}; 
                User Id={company.UserId};
                Password={company.Password};
                Integrated Security = True; 
                Connect Timeout = 30; 
                Encrypt = False; 
                TrustServerCertificate = False; 
                ApplicationIntent = ReadWrite; 
                MultiSubnetFailover = False";
                }
            }
            
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly);

        public class CompanyDbConetxtFactory : IDesignTimeDbContextFactory<CompanyDbContext>
        {
            public CompanyDbContext CreateDbContext(string[] args)
            {
                return new CompanyDbContext("");
            }
        }
    }
}
