using System;

namespace Aisoftware.Tracker.Borders.Users.DTO
{
    ///<summary>
    ///Gerenciamento de sessão de usuário
    ///</summary>
    public class SessionRequest
    {
        private string _email;
        private string _password;

        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
