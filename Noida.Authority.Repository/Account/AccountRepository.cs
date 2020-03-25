using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noida.Authority.DAL.EF;
using System.Linq;

namespace Noida.Authority.Repository.Account
{

    public class AccountRepository
    {
        private NoidaMigrationEntities dbContext;
        public AccountRepository()
        {
            dbContext = new NoidaMigrationEntities();
        }

        public int Login()
        {
            //var user = dbContext.CustomerMsts.s
            return 1;
        }
    }
}
