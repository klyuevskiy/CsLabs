using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    // интерфейс доктора
    interface IDoctor
    {
        // список болезеней которые он лечит
        List<int> HealDiseaseIndexes { get; }
    }
}
