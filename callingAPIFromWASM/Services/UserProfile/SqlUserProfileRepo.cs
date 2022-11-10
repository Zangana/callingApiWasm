using accounting.Models;
using System.Net.Http.Json;

namespace callingAPIFromWASM.Services.UserProfile
{
    /// <summary>
    /// Implementing the IUserProfileRepo which is an interface. 
    /// </summary>
    public class SqlUserProfileRepo : IUserProfileRepo
    {
        private readonly HttpClient _httpClient;

        public SqlUserProfileRepo(HttpClient httpClient)
        {
            httpClient = _httpClient;
        }
        public Task CreateUser(TblUserProfile user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TblUserProfile>> GetAllUserProfiles()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<TblUserProfile>>("/userprofile/TblUserProfile");
            
        }

        public Task<TblUserProfile?> GetUserById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
