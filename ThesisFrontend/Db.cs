using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisFrontend
{
    public class Account
    {
        public int ID { get; private set; }
        public float Balance { get; private set; }

        public Account(int id, float balance)
        {
            ID = id;
            Balance = balance;
        }
    }

    public class Db
    {
        public List<Account> Accounts { get; set; }
        
        /// <summary>
        /// Establishes connection with the database hosted locally
        /// </summary>
        public void InitDb()
        {
            Accounts = new List<Account>();
        }

        public Account RetrieveAccountInfo(int accId)
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].ID == accId)
                    return Accounts[i];
            }
            return null;
        }

    }
}
