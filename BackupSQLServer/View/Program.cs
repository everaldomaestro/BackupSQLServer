namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.MSSQLServer ms = new Model.MSSQLServer();
            ms.BackupSQL();
        }
    }
}
