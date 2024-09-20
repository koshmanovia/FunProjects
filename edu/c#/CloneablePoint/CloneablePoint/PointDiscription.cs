using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class PointDiscription
    {
        public string PetName { get; set; }
        public Guid PointID { get; set; }
        public PointDiscription() 
        {
            PetName = "No-Name";
            PointID = Guid.NewGuid();
        }
    }
}
