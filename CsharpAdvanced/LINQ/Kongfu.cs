using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Kongfu
    {
        public int KongfuId { get; set; }
        public string KongfuName { get; set; }
        public int Lethality { get; set; }

        public override string ToString()
        {
            return $"{nameof(KongfuId)}: {KongfuId}  \t  {nameof(KongfuName)}: {KongfuName}  \t  {nameof(Lethality)}: {Lethality}  \t  ";
        }
    }
}
