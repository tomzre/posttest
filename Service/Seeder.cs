using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.Extensions.DependencyInjection;
using EFCore.Entities;

namespace EFCore.Service
{
    public static class Seeder
    {

        public static void PushSeed(string jsonData, IServiceProvider serviceProvider)
        {
            List<Comment> events = JsonConvert.DeserializeObject<List<Comment>>(jsonData);
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<EFCoreDbContext>();
                if (!context.Comments.Any())
                {
                    context.AddRange(events);
                    context.SaveChanges();
                }
            }
        }
    }
}