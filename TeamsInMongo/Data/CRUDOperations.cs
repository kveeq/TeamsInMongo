using MongoDB.Driver;

namespace TeamsInMongo.Data
{
    public class CRUDOperations
    {
        readonly static string databaseName = "Teams";
        readonly static string userCollectionName = "Users";
        readonly static string teamCollectionName = "teams";
        public static IUser ChooseUserForTeam;
        public static ITeam ChooseTeam;

        public static async void AddUser(User user)
        {
            MongoClient client = new MongoClient(); // чтобы подключится к серверу надо передать в качестве аргумента {uri}
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<User>(userCollectionName);
            await collection.InsertOneAsync(user);
        } 

        public async static void AddTeam(Team team)
        {
            MongoClient client = new MongoClient(); // чтобы подключится к серверу надо передать в качестве аргумента {uri}
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<Team>(teamCollectionName);
            await collection.InsertOneAsync(team);
        } 
        public async static void UpdateTeam(Team team)
        {
            MongoClient client = new MongoClient(); // чтобы подключится к серверу надо передать в качестве аргумента {uri}
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<Team>(teamCollectionName);
            var UpdateDef = Builders<Team>.Update.Set("Name", team.Name).Set("Users", team.Users);
            await collection.UpdateOneAsync(basa => basa.Id == team.Id, UpdateDef);
        }

        public async static Task<List<User>> TakeUserList()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<User>(userCollectionName);
            return await collection.FindAsync(x => true).GetAwaiter().GetResult().ToListAsync();
        }  
        
        public async static Task<List<Team>> TakeTeamList()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<Team>(teamCollectionName);
            return await collection.FindAsync(x => true).GetAwaiter().GetResult().ToListAsync();
        }
    }
}
