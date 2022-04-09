﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Catalog
    {
        private int itemID;
        private string itemName;
        private string itemShortDescription;

        public Catalog(int itemID, string itemName, string itemShortDescription)
        {
            this.itemID = itemID;
            this.itemName = itemName;
            this.itemShortDescription = itemShortDescription;
        }

        public int ItemID { get { return itemID; } set { } }
        public string ItemName { get { return itemName; } set { itemName = value; } }
        public string ItemShortDescription { get { return itemShortDescription; } set { itemShortDescription = value; } }
    }



}
