using System.Text;

namespace SimpleRegistrationProject.Crypt
{
    public class CryptPassword
    {
        public string Encode(string password)
        {
            try
            {
                byte[] encBytes = new byte[password.Length];
                encBytes = Encoding.UTF8.GetBytes(password);
                string encryptPassword = Convert.ToBase64String(encBytes);
                return encryptPassword;
            }
            catch (Exception e)
            {
                throw new Exception($"Error in encode: {e.Message}");
            }
        }
    }
}