using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace WindowsFormsApp1
{
    public class User
    {
        private List<Identity> userContainer;

        public User()
        {
            userContainer = new List<Identity>();
        }

        public void LoadUsersFromJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                userContainer = JsonSerializer.Deserialize<List<Identity>>(json);
            }
        }

        public bool IsValid(string username, string password)
        {
            foreach (var user in userContainer)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
