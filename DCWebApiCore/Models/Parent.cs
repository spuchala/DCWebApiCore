using System;
using System.Collections.Generic;

namespace DCWebApiCore.Models
{
    public class Parent : User
    {
        public Guid ParentId { get; set; }
        public string KidId { get; set; }
        public List<Kid> Kids { get; set; }
        public bool IsRegistered { get; set; }
        public bool HasKidInSystem { get; set; }
    }
}