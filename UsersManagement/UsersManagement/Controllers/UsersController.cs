using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersManagement.Fake;
using UsersManagement.Models;

namespace UsersManagement.Controllers
{
    [Route("api/[controller]")]
    public class UsersController:ControllerBase
    {
        private List<User> _users = FakeData.GetUsers(200);
        [HttpGet]
        public List<User> Get()
        {
            return _users;
        }
        [HttpGet("{Id}")]
        public User Get(int Id)
        {
            var user = _users.FirstOrDefault(x => x.Id == Id);
            return user;
        }

        [HttpPost]
        public User Post([FromForm]User user)
        {
            _users.Add(user);
            return user;
        }

        [HttpPut]
        public User Put([FromBody]User user)
        {
            var editedUser = _users.FirstOrDefault(x => x.Id == user.Id);
            editedUser.FirstName = user.FirstName;
            editedUser.LastName = user.LastName;
            editedUser.Adress = user.Adress;
            return user;

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var deletedUser = _users.FirstOrDefault(x => x.Id == id);
            _users.Remove(deletedUser);
        }
    }
}
