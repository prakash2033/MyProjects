using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.ServiceAgent.EntityServiceReference;

namespace pfw.UI.Handlers
{
    public class ErrorHandler
    {
        public Guid ErrorId { get; set; }
        public string ErrorMessage { get; set; }
        public Exception Exception { get; set; }
        public EntityTypeName EntityType { get; set; }
        //public EntityViewName
    }
}
