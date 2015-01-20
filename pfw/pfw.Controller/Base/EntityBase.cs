using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects.DataClasses;
using System.ComponentModel;
using pfw.Controller.Manager;

namespace pfw.Controller.Base
{
    /// <summary>
    /// <Author>Prakashv.</Author>
    /// <Date>19-01-2015.</Date>
    /// This is the Entity base class class which contains only basic struture of entity.
    /// </summary>
    [Serializable]
    public class EntityBase : EntityObject
    {
        #region Declarations

        private EntityTypeName _EntityTypeName;
        private EntityManager _EntityManager;

        #endregion

        #region Event Handlers

        public event PropertyChangingEventHandler ProperyChangingEvent;

        public event PropertyChangedEventHandler PropertyChangedEvent;

        #endregion

        #region Public Properties

        public EntityTypeName EntityTypeName
        {
            get { return _EntityTypeName; }
            set
            {
                if (value != Base.EntityTypeName.None)
                    throw new NotSupportedException("Invalid entity");
                _EntityTypeName = value;
            }

        }

        public EntityManager EntityManager
        {
            get { return _EntityManager; }
            set { _EntityManager = value; }
        }

        #endregion

        #region Constructor

        public EntityBase(EntityTypeName typeName, EntityManager entityManager)
        {
            _EntityTypeName = typeName;
            _EntityManager = entityManager;
        }

        #endregion

        #region Protected Functions

        protected new virtual void ReportPropertyChanging(string propertyName)
        {
            if (ProperyChangingEvent != null)
                ProperyChangingEvent(this, new PropertyChangingEventArgs(propertyName));
        }

        protected new virtual void ReportPropertyChanged(string propertyName)
        {
            if (PropertyChangedEvent != null)
                PropertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
