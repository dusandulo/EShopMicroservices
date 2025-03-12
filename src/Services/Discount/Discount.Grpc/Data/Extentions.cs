using Microsoft.EntityFrameworkCore;

namespace Discount.Grpc.Data
{
    public static class Extentions
    {
        public static IApplicationBuilder UseMigration(this IApplicationBuilder app)
        {
            using var scopre = app.ApplicationServices.CreateScope();
            using var dbContext = scopre.ServiceProvider.GetRequiredService<DiscountContext>();
            dbContext.Database.MigrateAsync();

            return app;
        }
    }
}
