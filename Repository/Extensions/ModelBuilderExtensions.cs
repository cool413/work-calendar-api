using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "東洋",
                    Code = "0340"
                },
                new Company
                {
                    Id = 2,
                    Name = "訊聯",
                    Code = "0322"
                },
                new Company
                {
                    Id = 3,
                    Name = "雲門",
                    Code = "0217"
                }
            );

            modelBuilder.Entity<Confirmation>().HasData(
                new Confirmation
                {
                    Code = "0000128773_CRM_0001",
                    CompanyId = 1,
                    SystemVersion = "91",
                },
                new Confirmation
                {
                    Code = "0000670228_CRM_0002",
                    CompanyId = 2,
                    SystemVersion = "91",
                },
                new Confirmation
                {
                    Code = "0000129312_CRM_0003",
                    CompanyId = 3,
                    SystemVersion = "91",
                }
            );
        }
    }
}