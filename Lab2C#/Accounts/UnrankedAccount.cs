using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2C_.Accounts
{
    class UnrankedAccount : GameAccount
    {
        public UnrankedAccount(string userName) : base(userName)
        {

        }
        public override int RatingCalc(int rating)
        {
            return 0;
        }
    }
}
