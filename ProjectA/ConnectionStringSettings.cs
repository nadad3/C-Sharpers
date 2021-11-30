using System;

namespace ProjectA
{
    internal class ConnectionStringSettings
    {
        public string ConnectionString { get; internal set; }

        public static implicit operator ConnectionStringSettings(System.Configuration.ConnectionStringSettings v)
        {
            throw new NotImplementedException();
        }
    }
}