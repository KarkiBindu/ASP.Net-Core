using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //// to make static files default
            //DefaultFilesOptions defFileOpt = new DefaultFilesOptions();
            //defFileOpt.DefaultFileNames.Clear();
            //defFileOpt.DefaultFileNames.Add("foo.html");
            //app.UseDefaultFiles(defFileOpt);
            ////To serve static files like images
            //app.UseStaticFiles();

            // Use static files and use default files can be replace by using use file server

            //FileServerOptions fileServeOpt = new FileServerOptions();
            //fileServeOpt.DefaultFilesOptions.DefaultFileNames.Clear();
            //fileServeOpt.DefaultFilesOptions.DefaultFileNames.Add("foo.html");
            app.UseFileServer("abc.html");


            app.Run(async (context) =>
            {
                //await context.Response.WriteAsync("Hello World");
                await context.Response.WriteAsync(_config["CustomConfigKey"]);
            });
        }
    }
}
