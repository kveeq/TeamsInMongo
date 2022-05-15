using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TeamsInMongo.Data
{
    public class User : IUser
    {
        public User()
        {
        }

        public User(string name, string login, string email)
        {
            Name = name;
            Login = login;
            Email = email;
        }
        public async void Submit(User user)
        {
            var a = await CRUDOperations.TakeUserList();
            var useqr = a.Where(x => x.Login == user.Login && x.Email == user.Email).FirstOrDefault();
            Name = useqr.Name;
            Login = useqr.Login;
            Email = useqr.Email;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonElement]
        public string Name { get; set; }
        [BsonElement]
        public string Login { get; set; }
        [BsonElement]
        public string Email { get; set; }
    }
}
