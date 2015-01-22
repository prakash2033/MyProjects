using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.Controller.Base;

namespace pfw.Controller.Manager
{
    [Serializable]
    public abstract class Manager : IDisposable
    {
        #region Public Properties

        public EntityTypeName EntityTypeName { get; set; }
        public Guid ManagerGuid { get; set; }

        #endregion

        #region Constructor

        public Manager()
        {
            ManagerGuid = Guid.NewGuid();
        }

        #endregion

        #region IDisposable Members

        public virtual void Dispose()
        {
            
        } 

        #endregion


        public abstract EntityBase GetEntity(EntityTypeName entityTypeName);
    }
}
