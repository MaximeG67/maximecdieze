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
        public List<Account> ListAccount;

        public Administrator(int id, string sort, int maxTransac)
        {
            Id = id;
            Sort = sort;
            MaxTransac = maxTransac;
            ListAccount = new List<Account>();
        }

        public void AddAcount(Account acnt)
        {
            if (!ListAccount.Contains(acnt))
                ListAccount.Add(acnt);
        }

        public static bool AccountExist(int id, List<Account> listAccount)
        {
            if (!listAccount.Any(x => x.Id == id))
            {
                return false;
            }
            return true;
        }
    }
}
