using AutoMapper;
using FluentValidation.AspNetCore;
using Ideastudio.DataAccess;
using Ideastudio.DataAccess.Repositories.Implementations;
using Ideastudio.DataAccess.Repositories.Interfaces;
using Ideastudio.Service.Implementations;
using Ideastudio.Service.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;


public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<ApplicationContext>(options =>
        {
            options.UseSqlServer(Configuration["ConnectionStrings:ideastudio"]);
        });

        services.AddAutoMapper(typeof(Startup));

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
        });

        services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        }));

        services.AddOpenApiDocument();
        services.AddControllers();

        services.AddTransient<IGlavniProjektantRepository, GlavniProjektantRepository>();
        services.AddTransient<IGlavniProjektantService, GlavniProjektantService>();

        services.AddTransient<IIdejnoResenjeRepository, IdejnoResenjeRepository>();
        services.AddTransient<IIdejnoResenjeService, IdejnoResenjeService>();

        services.AddTransient<IInformacijeOLokacijiRepository, InformacijeOLokacijiRepository>();
        services.AddTransient<IInformacijeOLokacijiService, InformacijeOLokacijiService>();

        services.AddTransient<ILokacijskaDozvolaRepository, LokacijskaDozvolaRepository>();
        services.AddTransient<ILokacijskaDozvolaService, LokacijskaDozvolaService>();

        services.AddTransient<IObjekatRepository, ObjekatRepository>();
        services.AddTransient<IObjekatService, ObjekatService>();

        services.AddTransient<IPovrsinaRepository, PovrsinaRepository>();
        services.AddTransient<IPovrsinaService, PovrsinaService>();

        services.AddTransient<IProjekatZaGradjevinskuDozvoluRepository, ProjekatZaGradjevinskuDozvoluRepository>();
        services.AddTransient<IProjekatZaGradjevinskuDozvoluService, ProjekatZaGradjevinskuDozvoluService>();

        services.AddTransient<IProstorijaRepository, ProstorijaRepository>();
        services.AddTransient<IProstorijaService, ProstorijaService>();

        services.AddTransient<IVrstaPovrsineRepository, VrstaPovrsineRepository>();
        services.AddTransient<IVrstaPovrsineService, VrstaPovrsineService>();


        //services.AddTransient<IValidator<BaseVendor>, VendorValidator>();

        services.AddAutoMapper(typeof(Startup));
        services.AddMvc().AddFluentValidation();
        services.AddMvc(option => option.EnableEndpointRouting = false)
            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        //.AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseCors("MyPolicy");

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseOpenApi();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        });

        app.UseStaticFiles();

        UpdateDatabase(app);

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }

    private static void UpdateDatabase(IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
        using var context = serviceScope.ServiceProvider.GetService<ApplicationContext>();
        context.Database.Migrate();
    }
}
