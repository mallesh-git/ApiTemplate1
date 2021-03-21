namespace ApiTemplate1.Services
{
    using System;

    /// <summary>
    /// Represent user service definition
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Validate User
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="password">password</param>
        /// <returns>True if valid else False</returns>
        bool ValidateCredentials(String username, String password);
    }
}
