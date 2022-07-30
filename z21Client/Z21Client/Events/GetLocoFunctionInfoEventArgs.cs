using System;
using Z21Client.DTO;

namespace Z21Client.Events
{
    public class GetLocoFunctionInfoEventArgs : EventArgs
    {
        public LokInfoFunctionData Data;

        public GetLocoFunctionInfoEventArgs(LokInfoFunctionData data) : base()
        {
            Data = data;
        }
    }
}