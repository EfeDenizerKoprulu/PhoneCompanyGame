﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Display : ManageID, IEntity
    {
        public int ItemId { get; set; }
        public string Brand { get; set; }
        public string DisplayType { get; set; }
        public string Inc { get; set; }

        public Item Item { get; set; }
    }
}
