using Z21Client.Enums;

namespace Z21Client.DTO
{
    public class FunctionData
    {
        public LokAdresse LokAdresse { get; set; } = new(-1);

        public int FunctionAdress { get; set; }

        public ToggleType ToggleType { get; set; }
    }
}
