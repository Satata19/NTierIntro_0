﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public  class OrderDetailConfiguration:BaseConfiguration<OrderDetail>
    {
        public OrderDetailConfiguration()
        {
            ToTable("Satislar");


            Ignore(x => x.Id);
            HasKey(x => new
            {
                x.OrderId,
                x.ProductId
            });
        }
    }
}
