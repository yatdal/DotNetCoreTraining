namespace dotnettraining.Models
{
    public interface DataAccessLayer : IDataAccessLayer
    {
        public List<UserCredential> GetUsers()
        {
            /*
             * using dbcon:
             *    select * from users 
             *    ...
             
             */

            return new List<UserCredential>()
            {
                new UserCredential(){ Username= "DAL1 - User1"},
                new UserCredential(){ Username= "DAL1 - User2"},
                new UserCredential(){ Username= "DAL1 - User3"}
            };
        }
    }

    
}
