﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities.Concrete
{
    public class Blog : IEntity 
    {
        public int Id { get; set; }
        public string BlogName { get; set; }
        public string BlogText { get; set; }
    }
}
