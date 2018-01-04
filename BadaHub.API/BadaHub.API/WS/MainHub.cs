using BadaHub.API.Application.Services;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;
using BadaHub.API.Application.ViewModels;
using BadaHub.API.Application.Interfaces;
using System.Collections.Generic;

namespace BadaHub.API.WS
{
    public class MainHub : Hub
    {
        private readonly IOperationAppService _operationAppService;

        public MainHub(IOperationAppService operationAppService)
        {
            _operationAppService = operationAppService;
        }


        public void Send(string name, string message)
        {
            UserHandler.ConnectedIds.Add(Context.ConnectionId);
            // Call the broadcastMessage method to update clients.
            Clients.All.InvokeAsync("broadcastMessage", name, message);

        }

        public override Task OnConnectedAsync()
        {
            //Console.Write(Context.ToString());

            //var operation = new OperationViewModel
            //{
            //    Id = Guid.NewGuid(),
            //    Payload = "payload",
            //    Type = Domain.Commands.OperationType.HOME_ASSISTANT
            //};
            //_operationAppService.Dispatch(operation);

            UserHandler.ConnectedIds.Add(Context.ConnectionId);
            Clients.All.InvokeAsync("broadcastMessage", UserHandler.ConnectedIds.Count);

            //return Response(operation);
            return new Task(() => { });
        }

        public override Task OnDisconnectedAsync(Exception e)
        {

            UserHandler.ConnectedIds.Remove(Context.ConnectionId);
            Clients.All.InvokeAsync("broadcastMessage", UserHandler.ConnectedIds.Count);

            //return Response(operation);
            return new Task(() => { });
        }


    }

    public static class UserHandler
    {
        public static HashSet<string> ConnectedIds = new HashSet<string>();
    }
}
