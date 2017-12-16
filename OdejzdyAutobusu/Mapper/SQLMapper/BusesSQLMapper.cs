using Mapper.DataMapper;
using Mapper.DB;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;


namespace Mapper.SQLMapper
{
    public class BusesSQLMapper
    {
        private static List<Buses> buses = new List<Buses>();

        public static string SQL_INSERT = "INSERT INTO Buses VALUES (@lnumber, @sfrom, @sto)";
        public static string SQL_SINGLE_SELECT = "SELECT * FROM Buses WHERE lnumber = @lnumber";
        public static string SQL_SELECT = "SELECT * FROM Buses";
        public static string SQL_UPDATE = "UPDATE Buses SET sfrom = @sfrom, sto = @sto WHERE lnumber=@lnumber";

        public static List<Buses> Buses { get => buses; set => buses = value; }

        // INSERT BUS
        // ----------

        public static int Insert(Buses bus)
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, bus);
            int ret = db.ExecuteNonQuery(command);

            db.Close();

            return ret;
        }

        // UPDATE BUS
        // ----------

        public static int Update(Buses bus)
        {
            Database db;

            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, bus);
            int ret = db.ExecuteNonQuery(command);

            db.Close();

            return ret;
        }

        // GET ALL BUSES
        // -------------

        public static Collection<Buses> GetBuses()
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT);

            SqlDataReader reader = db.Select(command);

            Collection<Buses> buses = Read(reader);
            reader.Close();

            db.Close();

            return buses;
        }

        // GET BUP by ID
        // -------------

        public static Collection<Buses> GetBus(int lnumber)
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SINGLE_SELECT);
            PrepareCommand(command, lnumber);
            SqlDataReader reader = db.Select(command);

            Collection<Buses> buses = Read(reader);
            reader.Close();

            db.Close();

            return buses;
        }

        // PREPARE COMMAND
        // ---------------

        private static void PrepareCommand(SqlCommand command, Buses bus)
        {
            command.Parameters.AddWithValue("@lnumber", bus.lnumber);
            command.Parameters.AddWithValue("@sfrom", bus.sfrom);
            command.Parameters.AddWithValue("@sto", bus.sto);
        }

        private static void PrepareCommand(SqlCommand command, int lnumber)
        {
            command.Parameters.AddWithValue("@lnumber", lnumber);
        }

        // READ
        // ----

        private static Collection<Buses> Read(SqlDataReader reader)
        {
            Collection<Buses> buses = new Collection<Buses>();

            while (reader.Read())
            {
                int i = -1;
                Buses bus = new Buses();
                bus.lnumber = reader.GetInt32(++i);
                bus.sfrom = reader.GetInt32(++i);
                bus.sto = reader.GetInt32(++i);
                buses.Add(bus);
            }
            return buses;
        }
    }
}
