using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission8.Models
{
    public class TaskFormResponse
    {
        [Key]
        [Required]
        public int TaskID { get; set; }
        [Required]
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        [Required]
        [Range(1,4)]
        public int Quadrant { get; set; }
        public bool Completed { get; set; }

        // foreign key relationship
        public string CategoryID { get; set; }
        public Category CategoryName { get; set; }
    }
}
