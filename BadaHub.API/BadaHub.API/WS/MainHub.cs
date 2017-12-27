using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace BadaHub.API.WS
{
    public class MainHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.InvokeAsync("broadcastMessage", name, message);
        }

        public override Task OnConnectedAsync()
        {
            Console.Write(Context.ToString());
            return new Task(() => { });
        }
    }
}
