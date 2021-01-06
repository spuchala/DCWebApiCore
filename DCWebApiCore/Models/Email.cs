using System;
using System.Collections.Generic;

namespace DCWebApiCore.Models
{
    public class Email
    {
        public Guid From { get; set; }
        public List<int> To { get; set; }
    }
}