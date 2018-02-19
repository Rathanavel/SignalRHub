using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

public class MyHub : Hub
{
    public void Send(string message)
    {
        var id = Context.ConnectionId.Substring(0, 5);
        Clients.All.receive(id, message);
    }
}
