namespace dotnettraining.Models
{
    public class UserCredential
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Message { get; set; } = string.Empty;

        public string NewUsername { get; set; }
        public string NewPassword { get; set; }
        public string RepeatPassword { get; set; }
    }
}
