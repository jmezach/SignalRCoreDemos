using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRCore
{
    public class Chat : Hub
    {
        public Task Send(string data)
        {
            return Clients.All.InvokeAsync("Send", data);
        }
    }
}