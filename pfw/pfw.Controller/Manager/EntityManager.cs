﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.Controller.Base;

namespace pfw.Controller.Manager
{
    public abstract class EntityManager : IDisposable
    {
        #region Public Properties

        public EntityTypeName EntityTypeName { get; set; }

        #endregion

        #region Constructor

        public EntityManager()
        {
            
        }
        #endregion

        public abstract EntityBase GetEntity(EntityTypeName entityTypeName);

        #region IDisposable Members

        public virtual void Dispose()
        {
            
        } 

        #endregion

        public abstract void CreateManager();
    }
}