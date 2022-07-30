using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainDatabase.Z21Client.DTO;
using TrainDatabase.Z21Client.Enums;

namespace Z21Client.DTO
{
    internal class FunctionData
    {
        public int LokAdresse { get; set; }

        public int FunctionAdress { get; set; }

        public ToggleType ToggleType { get; set; }
    }
}
