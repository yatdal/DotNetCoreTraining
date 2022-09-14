namespace dotnettraining.Models
{
    public interface IDataAccessLayer
    {
        public List<UserCredential> GetUsers();
    }
}