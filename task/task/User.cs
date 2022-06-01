using System;
namespace task
{
    public class User
    {

        private string _username;
        private string _password;

        public User(string username)
        {
            this._username = username;
        }
        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 6 && value.Length <= 25)
                    _username = value;
            }
        }


            public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 8 && value.Length <= 25)
                    _password = value;
            }
        }

        static bool SetPassword(string password)
        {
            bool hasDigit = false;
            bool hasUpper = false;
            bool hasLower = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                    hasDigit = true;
                else if (Char.IsUpper(password[i]))
                    hasUpper = true;
                else if (Char.IsLower(password[i]))
                    hasLower = true;

                if (hasLower && hasUpper && hasDigit)
                    return true;
            }
            return false;
        }


    }


    }

