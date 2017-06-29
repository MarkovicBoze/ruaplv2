using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class Contact
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
    }
}