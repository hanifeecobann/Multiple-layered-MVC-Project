﻿using BilgeShop.Business.Manager;
using BilgeShop.Data.Entities;
using BilgeShop.Data.Repositories;
using BilgeShop.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeShop.Business.Services
{
    public interface IUserService
    {
        void AddUser(UserAddDto userAAddDto);
    }
}
