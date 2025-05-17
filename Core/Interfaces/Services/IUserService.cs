using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces.Services
{
    public interface IUserService
    {
        //: IBaseService<User> -> para hacer getall e ir revisando que se esta guardando
        //COMO EN LAS DEMAS entities

        Task<IEnumerable<User>> GetAll(); //lista para ver los registros existentes

        Task <string> Login(User user); //iniciar sesion
        Task<bool> Register(string UserName, string Password); //crear usuario
        // **
        Task<User> SearchUser(int id); //consultar usuario
        //Task<Entidad> GetById(int id);
        Task<User> Update(int userToBeUpdatedId, User newUser); // --- UPDATE ---
    }
}