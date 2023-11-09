using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.App.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobPosition { get; set; }
        public string Email { get; set; }

        public int? ProjectMemberId { get; set; }
        public ProjectMember? ProjectMember { get; set; }

        public ICollection <Competence>? Competences { get; set;}

    }
}
