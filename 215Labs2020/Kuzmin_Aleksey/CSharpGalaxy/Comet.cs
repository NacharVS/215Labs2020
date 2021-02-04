using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.CSharpGalaxy
{
    class Comet : Abstract
    {
        public static void Program()
        {
            MongoConnect("Comet").GetAwaiter().GetResult();
            Comet HaleBopp = new Comet { _name = "Hale-Bopp", _speed=19, _length=1000000};
            Comet Lovejoy = new Comet { _name = "Lovejoy", _speed = 660, _length = 4000000 };
            MongoInsert(HaleBopp).GetAwaiter().GetResult();
            MongoInsert(Lovejoy).GetAwaiter().GetResult();
        }
    }
}
