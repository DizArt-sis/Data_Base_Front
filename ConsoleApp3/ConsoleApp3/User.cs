using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

  
        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }
    }

    public class FileManager
    {
        private readonly string filePath;

        
        public FileManager(string filePath)
        {
            this.filePath = filePath;
        }

        
        public void SaveUser(User user)
        {
            
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                
                writer.WriteLine(user.Username);
                writer.WriteLine(user.Password);
                writer.WriteLine(user.Email);
                writer.WriteLine();
            }
        }

       
        public bool UserExists(string username, string password)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isUsernameMatch = false;

                while ((line = reader.ReadLine()) != null)
                {
                    
                    if (line.Equals(username))
                    {
                        isUsernameMatch = true;

                        
                        line = reader.ReadLine();
                        if (line.Equals(password))
                        {
                            return true;
                        }
                    }
                }

                
                return isUsernameMatch;
            }
        }
    }
}
