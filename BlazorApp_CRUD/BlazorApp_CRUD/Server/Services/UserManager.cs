using BlazorApp_CRUD.Server.Interfaces;
using BlazorApp_CRUD.Server.Models;
using BlazorApp_CRUD.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp_CRUD.Server.Services
{
    public class UserManager : IUser
    {
        readonly DatabaseContext _dbContext = new();
        
        public UserManager(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Método responsável por Listar Usuários
        public List<User> GetUserDetails()
        {
            try
            {
                return _dbContext.Users.ToList();
            }
            catch 
            {
                throw;
            }
        }

        // Método responsável por Adicionar um Novo Usuário
        public void AddUser(User user)
        {
            try
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        // Método responsável por Atualizar um determinado Usuário
        public void UpdateUserDetails(User user)
        {
            try
            {
                _dbContext.Entry(user).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        // Método responsável por Excluir Usuário por Id
        public void DeleteUser(int id)
        {
            try
            {
                User? user = _dbContext.Users.Find(id);
                if (user != null)
                {
                    _dbContext.Users.Remove(user);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        // Método responsável por Retornar Usuário por Id
        public User GetUserData(int id)
        {
            try
            {
                User? user = _dbContext.Users.Find(id);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
