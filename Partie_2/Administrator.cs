using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_2
{
    public class Administrator
    {
        public int Id { get; set; }
        public const string TypePart = "Particulier";
        public const string TypeEntr = "Entreprise";
        public string Sort { get; set; }
        public int MaxTransac { get; set; }
        public List<Account> listAccount;

        public Administrator(int id,string sort,int maxTransac)
        {
            Id = id;
            Sort = sort;
            MaxTransac = maxTransac;
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

        internal static bool accountExist(int id, List<AccountLine> account)
        {
            throw new NotImplementedException();
        }
    }
}
