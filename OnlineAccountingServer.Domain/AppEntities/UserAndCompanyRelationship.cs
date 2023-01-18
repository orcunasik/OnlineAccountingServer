using OnlineAccountingServer.Domain.Abstractions;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineAccountingServer.Domain.AppEntities
{
    public class UserAndCompanyRelationship : BaseEntity
    {
        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        [ForeignKey("Company")]
        public string CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
