using MusicApp.Entities;
using MusicApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static MusicApp.BusinessLogic.AppManagement;

namespace MusicApp.BusinessLogic
{
    public class UsersRepository: IDisposable , IUsersRepository
    {
        private MusicAppDBContext _context;

        public static event Action<User> NewUserAddedEvent;
        public static event Action<User> UserUpdatedEvent;
        public static event Action<string> MessegeEvent;
        public UsersRepository()
        {
            _context = new MusicAppDBContext();
        }
        public async void AddUser(User user)
        {
            try
            {
                if (!(_context.Users.Any(u => u.Email == user.Email)))
                {
                    await _context.Users.AddAsync(user);
                    _context.SaveChanges();
                    NewUserAddedEvent(_context.Users.Single(u => u.Email == user.Email));
                }
                else MessegeEvent("Email Is Already In Use");
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
                
            }
              
            

        }
        public void RemoveUser(User user)
        {
            try
            {
                if (_context.Users.Any(u => u.Id == user.Id))
                {
                    _context.Users.Remove(_context.Users.Find(user.Id));
                    _context.SaveChanges();
                    MessegeEvent("User Removed Successfuly");
                }
                else MessegeEvent("User Is Not Listed");
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
            }


        }
        public List<User> SearchUsers(UserSearchDelegate userSearchDelegate)
        {
            try
            {
                var _usersList = _context.Users.ToList();
                List<User> users = new List<User>();
                foreach (User user in _usersList)
                {
                    if (userSearchDelegate(user))
                    {
                        users.Add(user);
                    }
                }
                return users;

            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
                return null;
            }


        }
        public User SearchUser(string email)
        {
            try
            {
                return _context.Users.Where(u => u.Email.ToLower() == email.ToLower()).Single();

            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
                return null;
            }

        }
        public UserPermissionLevelEnum CheckUserPermissionLevel(User user)
        {
            try
            {
                var _adminsUsersList = _context.Users.Where(u => u.PermissionLevel == 0).ToList();
                foreach (var u in _adminsUsersList)
                {
                    if (u.Id == user.Id)
                    {
                        return UserPermissionLevelEnum.Admin;
                    }
                }
                return UserPermissionLevelEnum.SimpleUser;
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
                return UserPermissionLevelEnum.SimpleUser;
            }
               
        }
        public void UpdateToDataBase(User user)
        {
            try
            {
                var query = _context.Users.Update(user);
                _context.SaveChanges();
                UserUpdatedEvent(user);
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
            }

        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
