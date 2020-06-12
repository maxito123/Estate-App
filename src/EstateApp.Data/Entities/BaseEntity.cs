using System;
namespace EstateApp.Data.Entities
{
    public abstract class BaseEntity
    {
        public string id { get; set;}
        public bool IsDeletedAt { get; set;}
        public DateTime CreateAt { get; set;}
        public DateTime ModifiedAt { get; set;}
        public DateTime DeletedAt { get; set;}

    }
}