using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Week2.ComplexNumber
{
    public class NumeroComplessoException : Exception


    {

        public NumeroComplesso PrimoOperatore  {get; set; }
        public NumeroComplesso SecondoOperatore { get; set; }

        public NumeroComplessoException() : base()
        {
        }

        public NumeroComplessoException(string message) : base(message)
        {
        }

        protected NumeroComplessoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
