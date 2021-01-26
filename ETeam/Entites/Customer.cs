using ETeam.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETeam.Entites
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string CustomerTag { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public DateTime DateOfBirth { get; set; }  
    }
}
