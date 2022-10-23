using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkUsage.EntityFramework
{
    [Table("Goodses")]
    public class Goods
    {
        [Required]
        public Guid Id { get; set; }

        public string? Name { get; set; }
    }
}
