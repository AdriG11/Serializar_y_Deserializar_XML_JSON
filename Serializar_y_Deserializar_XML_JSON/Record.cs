﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializar_y_Deserializar_XML_JSON
{
    public class Record
    {
        public int Account { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public decimal Balance { get; set; }

        public Record(): this(0, string .Empty, string.Empty, 0M) { }
        

        public Record (int account, string firstName, string lastName, decimal balance)
        {
            Account = account;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }
    }
}
