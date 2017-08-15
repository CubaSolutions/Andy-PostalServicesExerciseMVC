using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFSI_APP.Models
{
    [Table("PFSI_tblPFSI")]
    public class PFSIModel
    {
        public PFSIModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        [Column("EmpId", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; } = "Andy";

        [Required]
        public string LastName { get; set; } = "Duran";

        public string Email { get; set; } = "andyodr@gmail.com";

        public string GetFullName => LastName + ", " + FirstName;
    }

}