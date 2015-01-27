using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.UI.Win.EntityServiceReference;

namespace pfw.UI.Win.Managers
{
    public class RemoteCallData
    {
        //public string Key { get; set; }

        public EntityRequest Request { get; set; }

        public EntityServiceClient Client { get; set; }

        //public long ClientTickStartCount { get; set; }

        //public bool IsAbortRequested { get; set; }
    }
}
