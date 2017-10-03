using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Bavarder.Models;
using System.Threading.Tasks;
using Bavarder.Models.ChatModels;
using Microsoft.AspNet.Identity;
using Bavarder.ChatUtilities;

namespace Bavarder.Hubs
{
    public class GeneralChatHub : Hub
    {
        private static int _userCount;
        private InMemoryRepository _context;

        #region constructor
        public GeneralChatHub()
        {
            _context = InMemoryRepository.GetContext();
            _userCount = 0;
        }
        #endregion

        public void Send(ChatMessage message)
        {
            if (!string.IsNullOrEmpty(message.Content))
            {
                message.Content = HttpUtility.HtmlEncode(message.Content);
                HashSet<string> extractUrls;
                message.Content = TextParser.TransformAndExtractUrls(message.Content, out extractUrls);
                message.TimeStamp = DateTime.Now;
                message.Username = Context.User.Identity.GetUserName();
                Clients.All.newMessage(message);
            }
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            string uid = _context.GetUserByConnectionId(Context.ConnectionId);
            if (uid != null)
            {
                ChatUser user = _context.Users.Where(u => u.Id == uid).FirstOrDefault();
                if (user != null)
                {
                    _context.RemoveUser(user);
                    _userCount--;
                    return Clients.All.leaves(user.Id, user.Username, DateTime.Now);
                }
            }
            return base.OnDisconnected(stopCalled);
        }

        public int UserCount()
        {
            return _userCount;
        }

        public void Joined()
        {
            ChatUser user = new ChatUser()
            {
                Id = Context.User.Identity.GetUserId(),
                Username = Context.User.Identity.GetUserName()
            };

            _context.AddUser(user);
            _context.AddMapping(Context.ConnectionId, user.Id);
            Clients.All.Joins(user.Id, Context.User.Identity.GetUserName(), DateTime.Now);
        }

        public ICollection<ChatUser> GetConnectedUsers()
        {
            return _context.Users.ToList<ChatUser>();
        }
    }
}