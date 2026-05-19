namespace HouseRentingSystemProject.Middlewears
{
    public class CustomMiddleware(RequestDelegate next)
    {
        private readonly RequestDelegate next = next;

        public async Task InvokeAsync(
        HttpContext httpContext,
        IStatisticsService service)
        {
            service.RegisterRequest();
            await next(httpContext);
        }
    }
}
