using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SkillImage:IEntity
    {
        public int Id { get; set; }
        public int SkillsId { get; set; }
        public string ImagePath { get; set; }
    }
}
