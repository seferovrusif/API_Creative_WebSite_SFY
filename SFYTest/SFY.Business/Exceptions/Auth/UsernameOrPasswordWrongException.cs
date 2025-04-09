namespace SFY.Business.Exceptions.Auth
{
    public class UsernameOrPasswordWrongException : Exception
    {
        public UsernameOrPasswordWrongException() : base("Username or Password is wrong.")
        {
        }

        public UsernameOrPasswordWrongException(string? message) : base(message)
        {
        }
    }
}
