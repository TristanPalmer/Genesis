using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Genesis.Orders
{

    public partial class Order
    {
        public Order(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
