using Mapper.DB;
using Mapper.DataMapper;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;


namespace Mapper.SQLMapper
{
    public class StopsSQLMapper
    {
        private static List<Stops> stops = new List<Stops>();

        public static string SQL_INSERT = "INSERT INTO Stops VALUES (@id, @name)";
        public static string SQL_SINGLE_SELECT = "SELECT * FROM Stops WHERE id = @id";
        public static string SQL_SELECT = "SELECT * FROM Stops";
        public static string SQL_UPDATE = "UPDATE Stops SET sname = @sname WHERE id=@id";

        public static List<Stops> Stops { get => stops; set => stops = value; }

        // INSERT STOP
        // -----------

        public static int Insert(Stops stop)
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, stop);
            int ret = db.ExecuteNonQuery(command);

            db.Close();

            return ret;
        }

        // UPDATE USER
        // -----------

        public static int Update(Stops stop)
        {
            Database db;

            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, stop);
            int ret = db.ExecuteNonQuery(command);

            db.Close();

            return ret;
        }

        // GET ALL STOPS
        // -------------

        public static Collection<Stops> GetStops()
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT);

            SqlDataReader reader = db.Select(command);

            Collection<Stops> stops = Read(reader);
            reader.Close();

            db.Close();

            return stops;
        }

        // GET STOP by ID
        // --------------

        public static Collection<Stops> GetStop(int id)
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SINGLE_SELECT);
            PrepareCommand(command, id);
            SqlDataReader reader = db.Select(command);

            Collection<Stops> stops = Read(reader);
            reader.Close();

            db.Close();

            return stops;
        }

        // PREPARE COMMAND
        // ---------------

        private static void PrepareCommand(SqlCommand command, Stops Stop)
        {
            command.Parameters.AddWithValue("@id", Stop.id);
            command.Parameters.AddWithValue("@sname", Stop.sname);
        }

        private static void PrepareCommand(SqlCommand command, int id)
        {
            command.Parameters.AddWithValue("@id", id);
        }

        // READ
        // ----

        private static Collection<Stops> Read(SqlDataReader reader)
        {
            Collection<Stops> stops = new Collection<Stops>();

            while (reader.Read())
            {
                int i = -1;
                Stops stop = new Stops();
                stop.id = reader.GetInt32(++i);
                stop.sname = reader.GetString(++i);
                stops.Add(stop);
            }
            return stops;
        }
    }
}
