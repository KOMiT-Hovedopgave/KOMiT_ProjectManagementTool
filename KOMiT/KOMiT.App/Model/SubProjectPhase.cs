using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.App.Model
{
    public class SubProjectPhase
    {
        public int SubProjectId { get; set; }
        public int PhaseId { get; set; }
        public SubProject SubProject { get; set; }
        public Phase Phase { get; set; }
    }
}
