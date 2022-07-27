using VendingMachine.Application.Mapping;

namespace VendingMachine.Services.Api.Configuration
{
    public static class AutoMapperConfiguration
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            ArgumentNullException.ThrowIfNull(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewModelReverseMapping));
        }
    }
}
