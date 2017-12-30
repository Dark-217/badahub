using AutoMapper;
using BadaHub.API.Application.Interfaces;
using BadaHub.API.Application.Services;
using BadaHub.API.Data.Context;
using BadaHub.API.Data.EventSourcing;
using BadaHub.API.Data.Repository;
using BadaHub.API.Data.Repository.EventSourcing;
using BadaHub.API.Data.UoW;
using BadaHub.API.Domain.CommandHandlers;
using BadaHub.API.Domain.Commands;
using BadaHub.API.Domain.Core.Bus;
using BadaHub.API.Domain.Core.Events;
using BadaHub.API.Domain.Core.Notifications;
using BadaHub.API.Domain.EventHandlers;
using BadaHub.API.Domain.Events;
using BadaHub.API.Domain.Interfaces;
using BadaHub.API.Infra.Bus;
using BadaHub.API.Infra.Identity.Authorization;
using BadaHub.API.Infra.Identity.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace BadaHub.API.Infra.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Domain Bus(Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //// ASP.NET Authorization Polices
            services.AddSingleton<IAuthorizationHandler, ClaimsRequirementHandler>(); ;

            //// Application
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            services.AddScoped<IOperationAppService, OperationAppService>();

            //// Domain - Events
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            services.AddScoped<INotificationHandler<OperationDispatchedEvent>, OperationEventHandler>();

            //// Domain - Commands
            services.AddScoped<INotificationHandler<OperationDispatchedCommand>, OperationCommandHandler>();

            //// Infra - Data
            services.AddScoped<IOperationRepository, OperationRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<Context>();

            //// Infra - Data EventSourcing
            services.AddScoped<IEventStoreRepository, EventStoreSqlRepository>();
            services.AddScoped<IEventStore, SqlEventStore>();
            services.AddScoped<EventStoreSqlContext>();

            //// Infra - Identity Services
            //services.AddTransient<IEmailSender, AuthEmailMessageSender>();
            //services.AddTransient<ISmsSender, AuthSMSMessageSender>();

            //// Infra - Identity
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}