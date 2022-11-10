using accounting.Models;

namespace callingAPIFromWASM.Services.UserProfile
{
    /// <summary>
    /// An interface for get create delete users. 
    /// </summary>
    public interface IUserProfileRepo
    {
        Task<IEnumerable<TblUserProfile>> GetAllUserProfiles();
        Task<TblUserProfile?> GetUserById(long id);

        Task CreateUser(TblUserProfile user);
        // Task UpdateUser(TblUserProfile user);
        Task DeleteUser(int id);
    }
}
