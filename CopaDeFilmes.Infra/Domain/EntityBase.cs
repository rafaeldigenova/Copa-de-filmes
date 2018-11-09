using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Infra.Domain
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public EntityBase()
        {
            CreatedAt = DateTime.Now;
        }

    }
}
