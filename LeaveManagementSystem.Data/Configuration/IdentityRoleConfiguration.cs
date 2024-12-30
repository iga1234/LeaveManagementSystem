using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementSystem.Data.Configuration
{
    public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
              new IdentityRole
              {
                  Id = "e252e472-125b-4497-98f3-f9bed8a3ca27",
                  Name = "Employee",
                  NormalizedName = "EMPLOYEE"
              },
              new IdentityRole
              {
                  Id = "3b305d58-7143-4889-ad2e-8271f5c63d7c",
                  Name = "Supervisor",
                  NormalizedName = "SUPERVISOR"
              },
              new IdentityRole
              {
                  Id = "0f5ad335-de61-40d7-b74e-a82de680c9c2",
                  Name = "Administrator",
                  NormalizedName = "ADMINISTRATOR"
              }
          );
        }

    }
}
