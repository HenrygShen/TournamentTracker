using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitialiseConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO: Set up the sql connector properly
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO: create the text connection
                TextConnection textConnection = new TextConnection();
                Connections.Add(textConnection);
            }
        }
    }
}
