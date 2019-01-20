using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsamaCommon.Lib.Validater
{
  public   class EmailValidater
    {
        public bool IsValid { get; private set; }

       public void Validate(string email)
        {

        }

        public static bool Validate(out string email)
        {

            email = "fsdkf";
            return true;
        }

    }
}
