using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.Controller.Data;
using System.ComponentModel.DataAnnotations;
using pfw.Controller.Entities;
using pfw.Controller.Manager;
using pfw.Controller.Base;

namespace pfw.Model.Masters
{
    [Table("Item")]
    public class Item : MasterEntity
    {
        private string _itemCode;

        #region Constructor

        public Item(EntityManager entityManager)
            : base(EntityTypeName.Item, entityManager)
        { } 

        #endregion
        
        public string ItemCode
        {
            get
            {
                return _itemCode;
            }
            set
            {
                ReportPropertyChanging("ItemCode");
                _itemCode = value;
                ReportPropertyChanged("ItemCode");
            }
        }

    }
}
