using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericos
{
    class DollFactory : IFactory<Doll>
    {
        public Doll MakeElement() {

            return new Doll();
        }
       
    }
}
