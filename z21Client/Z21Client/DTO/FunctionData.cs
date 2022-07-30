using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainDatabase.Z21Client.DTO;
using TrainDatabase.Z21Client.Enums;

namespace Z21Client.DTO
{
    public class FunctionData
    {
        public LokAdresse LokAdresse { get; set; } = new(-1);

        public int FunctionAdress { get; set; }

        public ToggleType ToggleType { get; set; }
    }
}
