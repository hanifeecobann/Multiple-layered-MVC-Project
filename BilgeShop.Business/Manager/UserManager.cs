using BilgeShop.Business.Services;
using BilgeShop.Data.Entities;
using BilgeShop.Data.Repositories;
using BilgeShop.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeShop.Business.Manager
{
    public class UserManager : IUserService
    {
        private readonly IRepository<UserEntity> _userRepository;
        public UserManager(IRepository<UserEntity> userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(UserAddDto userAddDto)
        {
            var hasMail = _userRepository.GetAll(x => x.Email.ToLower() == userAddDto.Email.ToLower()).ToList();
        }
    }
}
