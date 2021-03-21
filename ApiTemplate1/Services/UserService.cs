namespace ApiTemplate1.Services
{

    /// <summary>
    /// Represent user service implementation
    /// </summary>
    public class UserService : IUserService
    {
        /// <summary>
        /// Validate User
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="password">password</param>
        /// <returns>True if valid else False</returns>
        public bool ValidateCredentials(string username, string password)
        {
            return username.Equals("me") && password.Equals("Pa$$WoRd");
        }
    }
}
