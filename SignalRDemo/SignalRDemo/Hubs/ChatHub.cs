using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRDemo.Hubs
{
    public class ChatHub : Hub
    {
        public async Task newMessage(string user, string message)
        {
            await Clients.All.SendAsync("messageReceived", user, message);
        }
    }
}
