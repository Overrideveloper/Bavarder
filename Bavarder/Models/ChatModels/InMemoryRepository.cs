using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bavarder.Models.ChatModels
{
    public class InMemoryRepository
    {
        public static ICollection<ChatUser> _connectedUsers;
        private static Dictionary<string, string> _mappings;
        private static InMemoryRepository _context = null;

        #region create instance of class
        public static InMemoryRepository GetContext()
        {
            if (_context == null)
            {
                _context = new InMemoryRepository();
            }
            return _context;
        }
        #endregion

        #region constructor
        private InMemoryRepository()
        {
            _connectedUsers = new List<ChatUser>();
            _mappings = new Dictionary<string, string>();
        }
        #endregion

        #region repo methods
        public IQueryable<ChatUser> Users
        {
            get 
            {
                return _connectedUsers.AsQueryable();
            }
        }

        public void AddUser(ChatUser user)
        {
            _connectedUsers.Add(user);
        }

        public void RemoveUser(ChatUser user)
        {
            _connectedUsers.Remove(user);
        }

        public void AddMapping(string connectionId, string userId)
        {
            if (!string.IsNullOrEmpty(connectionId) && !string.IsNullOrEmpty(userId))
            {
                _mappings.Add(connectionId, userId);
            }
        }

        public string GetUserByConnectionId(string connectionId)
        {
            string userId = null;
            _mappings.TryGetValue(connectionId, out userId);
            return userId;
        }
        #endregion
    }
}