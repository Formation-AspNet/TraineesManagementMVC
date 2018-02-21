using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TraineesManagementMVC.Models
{
    public class Trainee
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }

        public int GroupId { get; set; }
        public virtual Group Group { set; get; }
       
    }
}