using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code22.NewFolder1
{
    
    public class test:ICloneable
    {
        public ListNode listnode1 { get; set; }

        public test(int va)
        {
            listnode1 = new ListNode(va);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
