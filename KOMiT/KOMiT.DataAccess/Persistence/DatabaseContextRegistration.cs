﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace KOMiT.DataAccess.Persistence
{
    public static class DatabaseContextRegistration
    {
        public static void AddKOMiTApp(this IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>((provider, options) => options.UseSqlServer(provider.GetRequiredService<IConfiguration>().GetConnectionString("KOMiTConnectionString")));
            services.AddTransient<DatabaseContext>();
        }

    }
}
