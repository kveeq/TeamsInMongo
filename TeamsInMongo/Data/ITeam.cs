using MongoDB.Bson;

namespace TeamsInMongo.Data
{
    public interface ITeam
    {
        public ObjectId Id { get; set; }
        
        public string Name { get; set; }

        public List<IUser> Users { get; set; }

        public void AddUser(IUser user);
        public void RemoveUser(IUser user);
    }
}
