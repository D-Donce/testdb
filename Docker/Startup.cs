public void ConfigureServices(IServiceCollection services)
{
    var connection = @"Server=db;Database=master;User=guru;Password=tsnptsnp;";

    services.AddDbContext<ApplicationDbContext>(
        options => options.UseSqlServer(connection));

    services.AddIdentity<ApplicationUser, IdentityRole>()
        .AddEntityFrameworkStores<ApplicationDbContext>()
        .AddDefaultTokenProviders();

    services.AddMvc();

    services.AddTransient<IEmailSender, AuthMessageSender>();
    services.AddTransient<ISmsSender, AuthMessageSender>();
}