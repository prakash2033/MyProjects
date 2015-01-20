using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.Controller.Data;
using pfw.Controller.Base;
using pfw.Controller.Manager;
using System.ComponentModel.DataAnnotations;

namespace pfw.Controller.Entities
{
    public class MasterEntity : DataEntity
    {
        #region Constructor

        public MasterEntity(EntityTypeName typeName, EntityManager entityManager)
            : base(typeName, entityManager)
        { }

        #endregion

        #region Public Properties

        [Column("Code", TypeName = "ntext")]
        public string Code { get; set; } 

        #endregion
    }
}
