using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DCWebApiCore.Entities
{
    [Table("Class")]
    public class ClassEntity
    {
        [Key]
        public Guid ClassId { get; set; }
        public string ClassName { get; set; }
        public Guid DayCareId { get; set; }
    }
}
