namespace SFY.Business.Exceptions.AppUser
{
    public class AppUserCreatedFailedException : Exception
    {
        public AppUserCreatedFailedException():base("User cannot be crated")
        {   
        }

        public AppUserCreatedFailedException(string? message) : base(message)
        {
        }
    }
}
