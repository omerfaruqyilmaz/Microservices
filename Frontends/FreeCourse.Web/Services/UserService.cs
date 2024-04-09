using FreeCourse.Web.Models;
using FreeCourse.Web.Services.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace FreeCourse.Web.Services
{

    public class UserService : IUserService
    {
        private readonly HttpClient _client;

        public UserService(HttpClient client)
        {
            _client = client;
        }

        public async Task<UserViewModel> GetUser()
        {
            return await _client.GetFromJsonAsync<UserViewModel>("/api/user/getuser");
        }
    }
}
