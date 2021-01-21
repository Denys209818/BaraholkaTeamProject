using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BaraholkaTeamProject.DAL.ContextData
{
    [Table("tblUsersTeamProject")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [Required, StringLength(255)]
        public string Surname { get; set; }
        [Required, StringLength(255)]
        public string Login { get; set; }
        [Required, StringLength(255,MinimumLength = 6)]
        public string Password { get; set; }
    }
}
