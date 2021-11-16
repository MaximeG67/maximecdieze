using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_2.Canva
{
    class Administrator
    {
        public int Id { get; set; }
        public string Sort { get; set; }
        public List<Account> listAccount;

        public Administrator(int id,string sort)
        {
            Id = id;
            Sort = sort;
            listAccount = new List<Account>();
        }

        public void AddAcount(Account acnt)
        {
            if (!listAccount.Contains(acnt))
                listAccount.Add(acnt);
        }

        public List<Account> getAllAccount()
        {
            return listAccount;
        }

        public static bool accountExist(int id, List<Account> listAccount)
        {
            if (!listAccount.Any(x=> x.Id == id))
            {
                return false;
            } return true;
        }
    }
}
