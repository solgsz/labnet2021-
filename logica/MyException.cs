using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class MyException : Exception
    {
        private string MyMessage;
        public MyException(string message)
        {
            MyMessage = message;
        }
        public override string Message
        {
            get
            {
                return new StringBuilder(MyMessage).Append(" ").Append(base.Message).ToString();
            }

        }



    }
}
