using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendingMachine.Entities
{
    public class User
    {
        public string Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
        public DateTime CreationTime { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
