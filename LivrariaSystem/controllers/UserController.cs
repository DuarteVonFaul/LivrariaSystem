using LivrariaSystem.models;
using LivrariaSystem.database;
using LivrariaSystem.services;


namespace LivrariaSystem.controllers
{
    public class UserController
    {

        UserService service = new UserService();

        public Librarian createUserLibrarian(Librarian user)
        {
            return null;
        }


        public void createUserReader(Reader user)
        {
            service.register(user);
        }

        public Address? GetAndressByPostalCode(string postalCode) {
            


            return new AddressService().searchAndressByPostalCode(DataBase.client, postalCode);
        
        }



        public User? GetUserReaderByID(string Id)
        {
            return service.searchById(Id);
        }

    }
}
