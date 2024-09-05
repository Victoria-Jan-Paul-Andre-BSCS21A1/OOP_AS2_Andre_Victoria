using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace WindowsFormsApp1
{
    public class User
    {
        private List<Identity> _userList;

        public User()
        {
            _userList = new List<Identity>();
        }

        public void LoadUsersFromJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                _userList = JsonSerializer.Deserialize<List<Identity>>(json);
            }
        }

        public bool IsValid(string username, string password)
        {
            foreach (var user in _userList)
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
