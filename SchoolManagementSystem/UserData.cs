
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SchoolManagementSystem
{
    public class UserAccount
    {
        public string Id { get; set; } = "";
        public string Username { get; set; } = "";
        public string FullName { get; set; } = "";
        public string Role { get; set; } = "";
        public byte[] PasswordSalt { get; set; } = Array.Empty<byte>();
        public byte[] PasswordHash { get; set; } = Array.Empty<byte>();
    }

    public static class UserData
    {
        public static List<UserAccount> Users { get; } = new List<UserAccount>();

        static UserData()
        {
            AddUser("1", "admin", "Administrator", "Admin", "1234");
        }

        public static void AddUser(
            string id,
            string username,
            string fullName,
            string role,
            string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                100000,
                HashAlgorithmName.SHA256,
                32);

            Users.Add(new UserAccount
            {
                Id = id,
                Username = username,
                FullName = fullName,
                Role = role,
                PasswordSalt = salt,
                PasswordHash = hash
            });
        }

        public static bool VerifyPassword(UserAccount user, string password)
        {
            byte[] enteredHash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                user.PasswordSalt,
                100000,
                HashAlgorithmName.SHA256,
                32);

            return CryptographicOperations.FixedTimeEquals(
                enteredHash,
                user.PasswordHash);
        }
    }
}
