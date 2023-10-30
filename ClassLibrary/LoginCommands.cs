using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LoginCommands
    {
        public bool _tem = false;
        public string _message;
        // Método que verifica se contem o email e a senha na base de dados
        SqlCommand _cmd = new SqlCommand();
        Connecion _con = new Connecion();
        SqlDataReader _dr;
        public bool CheckLogin (string login, string password)
        {
            // Comandos sql para verificar se tem na base de dados
          _cmd.CommandText= "Select * from logins where login = @login and password = @password ";
          _cmd.Parameters.AddWithValue("@login", login);
          _cmd.Parameters.AddWithValue("@password", password);

            try
            {
                _cmd.Connection = _con.Connect();
                _dr = _cmd.ExecuteReader();
                if (_dr.HasRows) 
                { 
                   _tem = true; 
                }
            }
            catch (SqlException)
            {

                this._message = "Erro com Banco de Dados!";
            }

            return _tem;
        }
        // Método que registra uma nova senha caso o usúario tenha esquecido
        public string RegisterPassword (string email, string password) 
        {
            return _message;
         
        }

    }
}
