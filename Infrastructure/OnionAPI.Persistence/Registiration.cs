﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionAPI.Application.Interfaces.Repositories;
using OnionAPI.Persistence.Context;
using OnionAPI.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Persistence
{
    public static class Registiration
    {
        public static void AddPersistence(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer
            (configuration.GetConnectionString("DefaultConnection")));
            
            services.AddScoped(typeof(IReadRepository<>),typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>),typeof(WriteRepository<>));
        }
    }
}
