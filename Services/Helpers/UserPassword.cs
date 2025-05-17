using Microsoft.AspNetCore.Identity;
using System.Text;
using Newtonsoft.Json;
using System.Security.Claims;
// tokens - jwt
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
// capas API
using Core.Entities;
using Core.Interfaces;
using Core.Interfaces.Services;
using Core.Responses;
using Services.Validators;

namespace Services.Helpers
{
    //Hashing password and verify hashed password
    public class PasswordHasherService
    {
        private readonly IPasswordHasher<User> _passwordHasher;
        //IPasswordHasher : interfaz ---> propia del framework de ASP.NET Core Identity
        // Para su implementacion cuenta con clase propia: PasswordHasher<TUser>.
        //en el object se reemplaza por la entity a usar
        //
        
        public PasswordHasherService() //
        {
            // Para cualquier tipo objeto como TUser ya que solo se usa el hashing de esa clase aqui
            _passwordHasher = new PasswordHasher<User>();
        }

        public string HashPassword(string password)
        {
            //aqui finaliza el hasheo cm tal
            //luego de tomar el salt y el hash generado
            //se combinan y se terminan de "codificar"/"encriptar"
            //y se genera el hash final
            //este 
            return _passwordHasher.HashPassword(null, password);
        }

        //para verificar el hasheo
        //esto con el login 
        public PasswordVerificationResult VerifyPassword(string hashedPassword, string providedPassword)
        {
            return _passwordHasher.VerifyHashedPassword(null, hashedPassword, providedPassword);
        }
        
    }

}