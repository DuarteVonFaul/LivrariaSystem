using LivrariaSystem.DAO;
using LivrariaSystem.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaSystem.services
{
    public class UserService
    {
        ReaderDAO readerDAO = new ReaderDAO();


        public void register(User user)
        {
            readerDAO.InsertUser(user);
        }


        public User? searchById(string id)
        {
            return readerDAO.GetUserById(id);
        }

    }
}
