using System.Security.Cryptography;
using System.Text;

namespace TwitterLikeApp.Entity
{
    public static class UserProfileExtensions
    {
        public static string GetEmailHash(this UserProfile p)
        {
            var email = p.Email.ToLower();

            byte[] hash;
            using (var md5 = MD5.Create())
            {
                hash = md5.ComputeHash(Encoding.UTF8.GetBytes(email));
            }

            var sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(i.ToString("x2"));
            }

            return sb.ToString();

        }
    }
}