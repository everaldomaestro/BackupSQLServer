using System;
using Microsoft.SqlServer.Management.Smo;

namespace Model
{
    public class MSSQLServer
    {
        public void BackupSQL()
        {
            Server server = new Server("TI");
            Backup backup = new Backup()
            {
                Database = "NORTHWND",
                Incremental = false
            };
            string nomeArquivoBackup = string.Format("{0}_{1:yyyyMMdd_HHmmss}.bak", "NORTHWND", DateTime.Now);
            backup.Devices.AddDevice(nomeArquivoBackup, DeviceType.File);
            backup.SqlBackup(server);
        }
    }
}
