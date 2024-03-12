using Tickett.Models;
using System.Text.Json;
using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Tickett.Data;
using Tickett.Business;

namespace Tickett.Data
{

    public class UserEFRepository : IUserRepository
    {


        private readonly ObraContext _context;

        public UserEFRepository(ObraContext context)
        {
            _context = context;
        }

        public List<UserDTO> GetAll()
        {
            var users = _context.Users
                .ToList();

            if (users != null)
            {
                var userDto = users.Select(u => new UserDTO
                {
                    UserId = u.UserId,
                    Name = u.Name,
                    Password = u.Password
                }).ToList();
                return userDto;
            }
            else
            {
                return null; // Devuelve null si no se encuentra la obra
            }
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            SaveChanges();
        }

        public UserDTO Get(int id)
        {
            var user = _context.Users
                .Where(user => user.UserId == id)
                .FirstOrDefault();

            if (user != null)
            {
                var userDto = new UserDTO
                {
                    UserId = user.UserId,
                    Name = user.Name,
                    Password = user.Password,
                };

                return userDto;
            }
            else
            {
                return null; // Devuelve null si no se encuentra la obra
            }

        }

        public void Update(User user)
        {
            // Cargar la instancia existente de Obra desde el contexto
            var existingUser = _context.Users.Find(user.UserId);

            if (existingUser != null)
            {
                // Copiar las propiedades actualizadas de la nueva instancia a la instancia existente
                _context.Entry(existingUser).CurrentValues.SetValues(user);

                // Guardar los cambios en el contexto
                _context.SaveChanges();
            }
        }


        public void Delete(int id)
        {
            var userDto = Get(id);
            if (userDto == null)
            {
                throw new KeyNotFoundException("Obra not found.");
            }

            var user = _context.Users.FirstOrDefault(u => u.UserId == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                SaveChanges();
            }
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }

}