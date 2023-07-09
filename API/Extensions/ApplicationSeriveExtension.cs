namespace API.Extensions;

public static class ApplicationSeriveExtension
{
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",builder=>
                builder.AllowAnyOrigin() //withOriginal("https://donini.com")
                .AllowAnyMethod()        //withMethods("GET","POST")
                .AllowAnyHeader());      //withHeaders("accept", "content-type")
        });
}