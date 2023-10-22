using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Postgresql.Domain;

namespace Postgresql.Infrastructure.Repository;

internal sealed class CompanyConfigurationBuilder
    : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder
            .HasKey(p => p.Symbol);
    }
}