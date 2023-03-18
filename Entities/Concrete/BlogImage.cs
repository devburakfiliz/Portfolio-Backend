using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BlogImage: IEntity
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string ImagePath { get; set; }
    }
}
