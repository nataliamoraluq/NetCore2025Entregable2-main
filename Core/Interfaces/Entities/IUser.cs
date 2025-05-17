using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces.Entities
{
    public interface IUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
    }
}