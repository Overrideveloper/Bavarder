using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Bavarder.Models;

namespace Bavarder.Hubs
{
    public class GeneralChatHub : Hub
    {
        public void Send(string uid, string message)
        {
            var appDb = new ApplicationDbContext();
            var user = appDb.Users.Find(uid);
            var username = user.UserName;
            var photo = user.UserPhoto;
            Clients.All.newMessage(uid, username, photo, message);
        }
    }
}