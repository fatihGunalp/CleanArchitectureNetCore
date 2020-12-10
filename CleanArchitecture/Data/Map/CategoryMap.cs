using Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Map
{
    public class CategoryMap
    {
        public CategoryMap(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryName).IsRequired();

        }
    }
}
