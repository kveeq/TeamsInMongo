using Microsoft.AspNetCore.Components;
using TeamsInMongo.Data;

namespace TeamsInMongo.Pages
{
    public partial class Index
    {
        [Inject]
        User user { get; set; }
        private string Name { get; set; }
        private string Login { get; set; }
        private string Email { get; set; }

        public void Submit()
        {
            user.Submit(new User(Name, Login, Email));
        }
    }
}
