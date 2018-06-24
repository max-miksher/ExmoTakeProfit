using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmoTakeProfit
{
    class UserInfo
    {

        public int uid = 0;
        public int server_date = 0;
        public IDictionary<string, float> balances = new Dictionary<string, float>();
        public IDictionary<string, float> reserved  = new Dictionary<string, float>();

    }
}
