using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace TechPosAPI.Extensions
{
    public static class MigrationExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();

            using TechChallengeContext dbContext =
                scope.ServiceProvider.GetRequiredService<TechChallengeContext>();

            dbContext.Database.Migrate();
        }
    }
}
