using MongoDB.Bson;

namespace TeamsInMongo.Data
{
    public interface IUser
    {
        public ObjectId Id { get; set; }    
        public string Name { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
    }
}
