using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "5003t23d-003c-4360-a43d-1681df5b3b5f",
                    UserId = "5003a23d-003b-4560-a45d-1687df5b3b5e"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "5003t23f-003g-4570-b43d-1681df5d3b5f",
                    UserId = "402a47d0-481b-4e2c-b202-2d40abc668ca"
                }
           );
        }
    }
}