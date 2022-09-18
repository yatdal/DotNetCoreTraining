namespace dotnettraining.Models
{
    public interface IDataAccessLayer
    {
        List<UserCredential> GetUsers();
    }
}