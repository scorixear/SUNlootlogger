﻿using System.Collections.Generic;

namespace SUNLootLogger
{
    public interface IPhotonEventHandler
    {
        void OnEvent(byte code, Dictionary<byte, object> parameters);

        void OnResponse(byte operationCode, short returnCode, Dictionary<byte, object> parameters);

        void OnRequest(byte operationCode, Dictionary<byte, object> parameters);
    }
}
