using AutoMapper;
using Core.Interfaces;
using Core.Mapping;
using Core.Services;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Core
{
    public static class ServiceExtensions
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddSingleton(provider => new MapperConfiguration(cfg =>
            {
                var http = provider.CreateScope().ServiceProvider.GetService<IHttpContextAccessor>()!;

                var Request = http.HttpContext.Request;

                var builder = new UriBuilder(Request.Scheme, Request.Host.Host, Request.Host.Port.Value);
                string host = builder.ToString();

                cfg.AddProfile(new CardProfile(host));
                cfg.AddProfile(new AccountProfile());

            }).CreateMapper());
        }

        public static void AddFluentValidator(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        }

        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<ICardsService, CardsService>();
            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<IAccountsService, AccountsService>();
            services.AddScoped<ITransactionsService, TransactionsService>();
        }
    }
}
