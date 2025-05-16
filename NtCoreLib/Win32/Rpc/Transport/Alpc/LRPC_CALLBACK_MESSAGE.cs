using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtCoreLib.Win32.Rpc.Transport.Alpc {
    internal struct LRPC_CALLBACK_MESSAGE {
        // 0
        public LRPC_HEADER Header;
        // 2 - 0x08
        public LRPC_REQUEST_MESSAGE_FLAGS Flags;
        // 3 - 0x0C
        public int CallId;
    }
}
