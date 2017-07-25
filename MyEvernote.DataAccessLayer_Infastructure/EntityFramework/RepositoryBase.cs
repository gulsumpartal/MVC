namespace MyEvernote.DataAccessLayer_Infastructure.EntityFramework
{
    public class RepositoryBase
    {
        protected static DatabaseContext db;
        private static object _lockSync = new object();
        protected RepositoryBase()
        {
            //bir constructure ın protected olması demek sadece onu miras alan classlar newleyebilir demek
           CreateContext();
        }

        private static void CreateContext()
        {
            if (db == null)
            {
                lock (_lockSync)
                {
                    if (db == null)
                    {
                        db = new DatabaseContext();
                    }

                }
            }
        }
    }
}
