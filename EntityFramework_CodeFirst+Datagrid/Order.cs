﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_Datagrid
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }

        public Order(int OrderNumber, string Name, string Surname, string Address)
        {
            this.Address = Address;
            this.OrderNumber = OrderNumber;
            this.Name = Name;
            this.Surname = Surname;
        }

        public Order()
        {
        }

    }
}
