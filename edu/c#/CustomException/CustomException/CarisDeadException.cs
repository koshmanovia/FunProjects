using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    [Serializable]
    public class CarisDeadException : ApplicationException
    {
        public CarisDeadException() { }
        public CarisDeadException(string message) : base(message) { }
        public CarisDeadException(string message, Exception inner) : base(message, inner) { }
        protected CarisDeadException(
      System.Runtime.Serialization.SerializationInfo info,
      System.Runtime.Serialization.StreamingContext context)
        : base(info, context) { }
        // private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }
       
        public CarisDeadException(string message, string cause, DateTime time) 
            :base(message)
        {
          //  messageDetails = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
       //public override string Message => $"Car Error Message: {messageDetails}";
    }
}
