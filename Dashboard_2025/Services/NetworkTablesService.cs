using NetworkTables;

namespace Dashboard_2025.Services
{
    public class NetworkTablesService
    {
        public NetworkTableInstance ntInstance;
        public NetworkTable table;

        public NetworkTablesService()
        { 
            var tempInstance = NetworkTableInstance.Default;
            ntInstance.SetServerTeam(8117); // Replace with your team number
            ntInstance.StartDsClient();
            var tempTable = ntInstance.GetTable("SmartDashboard");
        }

        public double GetNumber(string key, double defaultValue = 0)
        {
            return table.GetEntry(key).GetDouble(defaultValue);
        }

        public void SetNumber(string key, double value)
        {
            table.GetEntry(key).SetDouble(value);
        }

        //public string GetString(string key, string defaultValue = "")
        //{
        //    return table.GetEntry(key).get(defaultValue);
        //}

        //public void SetString(string key, string value)
        //{
        //    table.GetEntry(key).SetString(value);
        //}

        public bool IsConnected()
        {
            return ntInstance.Connected;
        }
    }
    
}