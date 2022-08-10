using BlazorApp_CRUD.Shared.Models;

namespace BlazorApp_CRUD.Server.Interfaces
{
    public interface IUser
    {
        // CRUD 
        /*
         C = Create (Criar): POST
         R = Read (Ler): GET
         U = Update (Atualizar) PUT
         D = Delete (Deletar) Delete
         */

        public List<User> GetUserDetails();
        public void AddUser(User user);
        public void UpdateUserDetails(User user);
        public void GetUserData(int id);
        public void DeleteUser(int id);

    }
}
