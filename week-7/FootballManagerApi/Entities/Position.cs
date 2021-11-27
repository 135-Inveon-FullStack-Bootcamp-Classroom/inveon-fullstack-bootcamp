using FootballManagerApi.EntityBases;
using System;

namespace FootballManagerApi.Entities
{
    public class Position : IEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
