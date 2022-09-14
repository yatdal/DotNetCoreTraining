namespace dotnettraining.Models
{
    public class DataAccessTextLayer : IDataAccessLayer
    {
        public List<UserCredential> GetUsers()
        {
            /***
             * read text file to get the usrs
             * 
             */

            return new List<UserCredential>()
            {
                new UserCredential(){ Username= "DAL2 - User1"},
                new UserCredential(){ Username= "DAL2 - User2"},
                new UserCredential(){ Username= "DAL2 - User3"}
            };
        }
    }
}
