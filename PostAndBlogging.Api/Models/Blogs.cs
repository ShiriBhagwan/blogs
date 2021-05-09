using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PostAndBlogging.Api.Models
{
    public class Blogs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime Updatedate { get; set; }

        public string Email { get; set; }
    }
}
