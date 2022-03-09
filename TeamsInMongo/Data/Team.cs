using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TeamsInMongo.Data
{
    public class Team : ITeam
    {
        public Team(string name, List<IUser> users)
        {
            Name = name;
            Users = users;
        }
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonElement]
        public string Name { get; set; }
        [BsonElement]
        public List<IUser> Users { get; set; }

        public void AddUser(IUser user)
        {
            Users.Add(user);
        }

        public event Action OnTeamItemChange;

        public void RemoveUser(IUser user)
        {
            Users.Remove(user);
        }
    }
}
