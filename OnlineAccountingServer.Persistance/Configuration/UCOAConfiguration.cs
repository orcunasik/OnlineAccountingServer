using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineAccountingServer.Domain.CompanyEntities;
using OnlineAccountingServer.Persistance.Constants;

namespace OnlineAccountingServer.Persistance.Configuration
{
    public sealed class UCOAConfiguration : IEntityTypeConfiguration<UniformChartOfAccount>
    {
        public void Configure(EntityTypeBuilder<UniformChartOfAccount> builder)
        {
            builder.ToTable(TableNames.UniformChartOfAccounts);
            builder.HasKey(i => i.Id);

        }
    }
}
