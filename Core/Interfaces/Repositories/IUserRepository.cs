﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        //public
        //ValueTask<User> GetUser(string Username, string Password); //ValueTask -> Task q retorna un valor
        
        ValueTask<User> GetUser(string Username);
        //prueba
        //ValueTask<User> GetUser(User user);
        //task especifica q no esta en el basee

        //GetUser -> para obtener un user ifso
    }
}
