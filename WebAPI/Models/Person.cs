using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [Table("Person")]
    public class Person
    {
        public int id { get; set; }
        [Column("First Name")]
        public string firstName { get; set; }
        [Column("Maiden Name")]
        public string maidenName { get; set; }
        [Column("Last Name")]
        public string lastName { get; set; }
        [Column("ID Number")]
        public int idNumber { get; set; }
        [Column("DOB")]
        public DateTime dateOfBirth { get; set; }
        [Column("Gender")]
        public string gender { get; set; }
        [Column("Tel")]
        public int? tel { get; set; }
        [Column("Cell")]
        public int cell { get; set; }
        [Column("Email")]
        public string email { get; set; }
        [Column("Address Line 1")]
        public string addressLine1 { get; set; }
        [Column("Address Line 2")]
        public string addressLine2 { get; set; }
        [Column("Address Line 3")]
        public string addressLine3 { get; set; }
    }
}
