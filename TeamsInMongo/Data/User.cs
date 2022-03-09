using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TeamsInMongo.Data
{
    public class User : IUser
    {
        public User(string name, string login, string email)
        {
            Name = name;
            Login = login;
            Email = email;
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
