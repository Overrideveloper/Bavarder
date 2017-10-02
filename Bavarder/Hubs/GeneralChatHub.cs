using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Bavarder.Models;
using System.Threading.Tasks;

namespace Bavarder.Hubs
{
    public class GeneralChatHub : Hub
    {
        private static int _userCount = 0;
        public void Send(string uid, string message)
        {
            var appDb = new ApplicationDbContext();
            var user = appDb.Users.Find(uid);
            var username = user.UserName;
            var photo = user.UserPhoto;
            Clients.All.newMessage(uid, username, photo, message);
        }

        public override Task OnConnected()
        {
            _userCount++;
            var name = Context.User.Identity.Name;
            var context = GlobalHost.ConnectionManager.GetHubContext<GeneralChatHub>();
            context.Clients.All.online(_userCount, name);
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            _userCount--;
            var name = Context.User.Identity.Name;  
            var context = GlobalHost.ConnectionManager.GetHubContext<GeneralChatHub>();
            context.Clients.All.offline(_userCount, name);
            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
            _userCount++;
            var name = Context.User.Identity.Name;
            var context = GlobalHost.ConnectionManager.GetHubContext<GeneralChatHub>();
            context.Clients.All.online(_userCount, name);
            return base.OnReconnected();
        }
    }
}