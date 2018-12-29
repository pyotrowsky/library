using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySolution
{
    public class CustomInitializer<T> : DropCreateDatabaseAlways<LibraryDb>
    {
        public override void InitializeDatabase(LibraryDb context)
        {
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction
                , string.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", context.Database.Connection.Database));

            base.InitializeDatabase(context);
        }

        protected override void Seed(LibraryDb context)
        {
            // Seed code goes here...

            base.Seed(context);
        }
    }
}
