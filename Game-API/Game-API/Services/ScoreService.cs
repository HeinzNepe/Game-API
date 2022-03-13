using Game_API.Interfaces;
using MySqlConnector;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace Game_API.Services;

public class ScoreService : IScoreService
{
    public int CreateScore(int uid, int points)
    {
        var sid = new int();

        using var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);        
        const string commandString =
            "insert into scores.scores (suid,points) values (@uid, @points)";
        const string idCommandString = "select id from scores.scores where suid = @uid and points = @points";
        var command = new MySqlCommand(commandString, connection);
        var idCommand = new MySqlCommand(idCommandString, connection);
        idCommand.Parameters.AddWithValue("@uid", uid);
        idCommand.Parameters.AddWithValue("@points", points);
        command.Parameters.AddWithValue("@uid", uid);
        command.Parameters.AddWithValue("@points", points);

        
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
        connection.Open();
        using var reader = idCommand.ExecuteReader();
        while (reader.Read())
        {
            sid = (int) reader["id"];
        }
        
        
        return sid;
    }
}