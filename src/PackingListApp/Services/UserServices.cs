using PackingListApp.EntityFramework;
using PackingListApp.Interfaces;
using PackingListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackingListApp.Services
{
    public class UserServices : IUserServices
    {
        private readonly TestContext _context;
        
        public UserServices(TestContext context)
        {
            _context = context;
        }

        public int Add(NewUser newUser)
        {
            var newuser = new User()
            {
                Name = newUser.Name,
                LastName = newUser.LastName,
                Address = newUser.Address,
                IsAdmin = newUser.IsAdmin,
                AdminType = (PackingListApp.Models.User._AdminType) newUser.AdminType
            };

            _context.Users.Add(newuser
            );
            _context.SaveChanges();
            return newuser.Id;
        }

        public User Get(int id)
        {
            return _context.Users.FirstOrDefault(t => t.Id == id);
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public int Put(int id, User item)
        {
            var itemput = _context.Users.FirstOrDefault(t => t.Id == id);
            itemput.Name = item.Name;
            itemput.LastName = item.LastName;
            itemput.Address = item.Address;
            itemput.IsAdmin = item.IsAdmin;
            itemput.AdminType = (PackingListApp.Models.User._AdminType) item.AdminType;

            _context.SaveChanges();
            return id;

        }

        public int Delete(int id)
        {
            User user_to_remove = _context.Users.FirstOrDefault(t => t.Id == id);
            _context.Users.Remove(user_to_remove);
            _context.SaveChanges();
            return id; 
        }


    }
}
