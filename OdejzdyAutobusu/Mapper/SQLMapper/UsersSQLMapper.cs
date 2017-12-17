using Mapper.DataMapper;
using Mapper.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Mapper.SQLMapper
{
    public class UsersSQLMapper
    {
        private static List<Users> users = new List<Users>();

        private static string SQL_SINGLE_SELECT = "SELECT * FROM Users WHERE id = @id";
        private static string SQL_SELECT_ROLE = "SELECT * FROM Users WHERE email = @email AND pwd = @pwd AND permision=@perm";
        private static string SQL_INSERT = "INSERT INTO Users VALUES (@id, @firstname, @lastname, @email, @pwd, @permision)";
        private static string SQL_SELECT = "SELECT * FROM Users";
        private static string SQL_UPDATE = "UPDATE Users SET firstname = @firstname, lsatname=@lastname, email=@email, pwd=@pwd WHERE id=@id";
        private static string SQL_SELECT_LOGIN = "SELECT * FROM Users WHERE email = @email AND pwd = @pwd";

        // INSERT USER
        // -----------

        public static int Insert(Users user)
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, user);
            int ret = db.ExecuteNonQuery(command);

            db.Close();

            return ret;
        }

        // UPDATE USER
        // -----------

        public static int Update(Users user)
        {
            Database db;

            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, user);
            int ret = db.ExecuteNonQuery(command);

            db.Close();

            return ret;
        }

        // GET ALL USERS
        // -------------

        public static Collection<Users> GetUsers()
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT);
            
            SqlDataReader reader = db.Select(command);

            Collection<Users> users = Read(reader);
            reader.Close();

            db.Close();

            return users;
        }

        // GET USER by ID
        // --------------

        public static Collection<Users> GetUser(int id)
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SINGLE_SELECT);
            PrepareCommand(command, id);
            SqlDataReader reader = db.Select(command);

            Collection<Users> users = Read(reader);
            reader.Close();

            db.Close();

            return users;
        }

        public static Collection<Users> Role(string email, string pwd, char perm)
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_ROLE);
            PrepareCommand(command, email, pwd, perm);
            SqlDataReader reader = command.ExecuteReader();

            Collection<Users> users = Read(reader);
            reader.Close();

            db.Close();

            return users;
        }

        // PREPARE COMMAND
        // ---------------

        private static void PrepareCommand(SqlCommand command, Users User)
        {
            command.Parameters.AddWithValue("@id", User.id);
            command.Parameters.AddWithValue("@firstname", User.firstname);
            command.Parameters.AddWithValue("@lastname", User.lastname);
            command.Parameters.AddWithValue("@email", User.email);
            command.Parameters.AddWithValue("@pwd", User.pwd);
            command.Parameters.AddWithValue("@permision", User.permision);
        }

        private static void PrepareCommand(SqlCommand command, string email, string pwd, char perm)
        {
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@pwd", pwd);
            command.Parameters.AddWithValue("@perm", perm);
        }

        private static void PrepareCommand(SqlCommand command, int id)
        {
            command.Parameters.AddWithValue("@id", id);
        }


        // READ
        // ----

        private static Collection<Users> Read(SqlDataReader reader)
        {
            Collection<Users> users = new Collection<Users>();

            while (reader.Read())
            {
                int i = -1;
                Users user = new Users();
                user.id = reader.GetInt32(++i);
                user.firstname = reader.GetString(++i);
                user.lastname = reader.GetString(++i);
                user.email = reader.GetString(++i);
                user.pwd = reader.GetString(++i);
                user.permision = reader.GetString(++i);
                users.Add(user);
            }
            return users;
        }

        public static int GetCount()
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand("SELECT COUNT(*) FROM Users");
            Int32 res = (Int32)command.ExecuteScalar();

            db.Close();

            return res;
        }
    }
}
