using System;
using System.Collections.Generic;
using System.Text;

namespace Natalia.Business.Models
{
    public abstract class Entity
    {
        public Entity()
        {            
        }

        public int Id { get; private set; }
    }
}
