using Z21Client.Enums;

namespace Z21Client.DTO
{
    public class LokInfoFunctionData
    {
        public int FunctionAddress { get; set; }

        public LokAdresse LokAdresse { get; set; } = default!;

        public ToggleType ToggleType { get; set; }
    }
}