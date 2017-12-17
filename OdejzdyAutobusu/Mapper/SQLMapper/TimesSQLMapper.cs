using Mapper.DataMapper;
using Mapper.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace Mapper.SQLMapper
{
    [XmlRoot("Times")]
    public class TimesAdd
    {
        
        public int id { get; set; }
        public int s_id { get; set; }
        public int b_id { get; set; }
        public DateTime leaving { get; set; }
        public int delay { get; set; }
        public int next_stop { get; set; }
        public int last_known_stop { get; set; }
    }

    public class TimesSQLMapper
    {
        private static List<Times> times = new List<Times>();
        /*
         class TimesDG
    {
        string stop { get; set; }
        int bus { get; set; }
        string last { get; set; }
        TimeSpan leaving { get; set; }
        int delay { get; set; }
        string last_known { get; set; }
    }select s.sname, t.b_id, t.leaving, t.tdelay, s1.sname from Times t LEFT JOIN Stops s ON t.s_id = s.id LEFT JOIN Stops s1 ON t.last_known_stop = s1.id WHERE t.leaving >= GETDATE()
             */
        private static string SQL_INSERT = "INSERT INTO Times VALUES (@id, @s_id, @b_id, @leaving, @delay, @next_stop, @last_known_stop)";
        private static string SQL_SINGLE_SELECT = "select TOP 10 s.sname, t.b_id, t.leaving, t.tdelay, s1.sname from Times t LEFT JOIN Stops s ON t.s_id = s.id LEFT JOIN Stops s1 ON t.last_known_stop = s1.id WHERE id = @id AND t.leaving >= GETDATE()";
        private static string SQL_SELECT_SID = "select TOP 10 s.sname, t.b_id, t.leaving, t.tdelay, s1.sname from Times t LEFT JOIN Stops s ON t.s_id = s.id LEFT JOIN Stops s1 ON t.last_known_stop = s1.id WHERE s_id = @s_id AND t.leaving >= GETDATE()";
        private static string SQL_UPDATE = "UPDATE Times SET leaving = @leaving, tdelay = @delay, next_stop = @next_stop, last_known_stop = @last_known_stop WHERE id = @id";
        private static string SQL_SELECT_FOR_UPDATE = "SELECT * FROM Times WHERE s_id = @s_id AND b_id = @b_id AND leaving = @leaving";

        // INSERT time
        // -----------

        public static int Insert(TimesAdd time)
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, time);
            int ret = db.ExecuteNonQuery(command);

            db.Close();

            return ret;
        }

        // UPDATE USER
        // -----------

        public static int Update(TimesAdd time)
        {
            Database db;

            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, time);
            int ret = db.ExecuteNonQuery(command);

            db.Close();

            return ret;
        }

        // GET ALL Times
        // -------------
        public static Collection<Times> GetTimesAll()
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand("select TOP 20 s.sname, t.b_id, s2.sname, t.leaving, t.tdelay, s1.sname from Times t LEFT JOIN Stops s ON t.s_id = s.id LEFT JOIN Stops s1 ON t.last_known_stop = s1.id LEFT JOIN Buses b ON b.number = t.b_id JOIN Stops s2 ON s2.id = b.sto");
            SqlDataReader reader = command.ExecuteReader();

            Collection<Times> times = Read(reader);
            reader.Close();

            db.Close();

            return times;
        }

        public static Collection<TimesAdd> GetTimesBackup()
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand("select * from Times");
            SqlDataReader reader = command.ExecuteReader();

            Collection<TimesAdd> times = Read2(reader);
            reader.Close();

            db.Close();

            return times;
        }

        public static Collection<Times> GetTimes(int s_id)
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_SID);
            PrepareCommandSID(command, s_id);
            SqlDataReader reader = command.ExecuteReader();

            Collection<Times> times = Read(reader);
            reader.Close();

            db.Close();

            return times;
        }

        // GET time by ID
        // --------------

        public static Collection<Times> GetTime(int id)
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SINGLE_SELECT);
            PrepareCommandID(command, id);
            SqlDataReader reader = db.Select(command);

            Collection<Times> times = Read(reader);
            reader.Close();

            db.Close();

            return times;
        }

        public static Collection<TimesAdd> GetTimeForUpdate(int sid, int bid, DateTime dt)
        {
            Database db;
            db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_FOR_UPDATE);
            PrepareCommand(command, sid, bid, dt);
            SqlDataReader reader = command.ExecuteReader();

            Collection<TimesAdd> times = Read2(reader);
            reader.Close();

            db.Close();

            return times;
        }

        // PREPARE COMMAND
        // ---------------

        private static void PrepareCommand(SqlCommand command, TimesAdd time)
        {
            command.Parameters.AddWithValue("@id", time.id);
            command.Parameters.AddWithValue("@s_id", time.s_id);
            command.Parameters.AddWithValue("@b_id", time.b_id);
            command.Parameters.AddWithValue("@leaving", time.leaving);
            command.Parameters.AddWithValue("@delay", time.delay);
            command.Parameters.AddWithValue("@last_known_stop", time.last_known_stop);
            command.Parameters.AddWithValue("@next_stop", time.next_stop);
        }

        private static void PrepareCommandSID(SqlCommand command, int s_id)
        {
            command.Parameters.AddWithValue("@s_id", s_id);
        }

        private static void PrepareCommandID(SqlCommand command, int id)
        {
            command.Parameters.AddWithValue("@id", id);
        }

        private static void PrepareCommand(SqlCommand command, int sid, int bid, DateTime dt)
        {
            command.Parameters.AddWithValue("@s_id", sid);
            command.Parameters.AddWithValue("@b_id", bid);
            command.Parameters.AddWithValue("@leaving", dt);
        }

        // READ
        // ----

        private static Collection<Times> Read(SqlDataReader reader)
        {
            Collection<Times> times = new Collection<Times>();

            while (reader.Read())
            {
                int i = -1;
                Times time = new Times();
                time.stop = reader.GetString(++i);
                time.bus = reader.GetInt32(++i);
                time.last = reader.GetString(++i);
                time.leaving = reader.GetDateTime(++i);
                time.delay = reader.GetInt32(++i);
                time.last_known = reader.GetString(++i);
                times.Add(time);
            }
            return times;
        }

        private static Collection<TimesAdd> Read2(SqlDataReader reader)
        {
            Collection<TimesAdd> times = new Collection<TimesAdd>();

            while (reader.Read())
            {
                int i = -1;
                TimesAdd time = new TimesAdd();
                time.id = reader.GetInt32(++i);
                time.s_id = reader.GetInt32(++i);
                time.b_id = reader.GetInt32(++i);
                time.leaving = reader.GetDateTime(++i);
                time.delay = reader.GetInt32(++i);
                time.last_known_stop = reader.GetInt32(++i);
                times.Add(time);
            }
            return times;
        }
    }
}

