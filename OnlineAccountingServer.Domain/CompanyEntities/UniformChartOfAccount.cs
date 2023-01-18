using OnlineAccountingServer.Domain.Abstractions;

namespace OnlineAccountingServer.Domain.CompanyEntities
{
    public sealed class UniformChartOfAccount :BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; }
        public string CompanyId { get; set; }
    }
}
