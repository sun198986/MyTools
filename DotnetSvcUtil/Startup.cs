/* (ÎÄµµ)  https://docs.microsoft.com/zh-cn/dotnet/core/additional-tools/dotnet-svcutil-guide?tabs=dotnetsvcutil2x
 * (wcfÇëÇó)   http://10.236.198.102:8888/ServiceControler?wsdl
 **/


using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ServiceReference;

namespace DotnetSvcUtil
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                var client = new UserClient(UserClient.EndpointConfiguration.WSHttpBinding_IUser,
                    @"http://10.236.198.102:8888/ServiceControler/User");
                var response = await client.LoginAsync("", "VBJGW01");
                await context.Response.WriteAsync(response.ToString());
            });

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
