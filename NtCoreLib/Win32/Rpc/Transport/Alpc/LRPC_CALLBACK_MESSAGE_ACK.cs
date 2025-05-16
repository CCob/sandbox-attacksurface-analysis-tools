using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NtCoreLib.Win32.Rpc.Transport.Alpc {

    [StructLayout(LayoutKind.Sequential)]
    internal struct LRPC_CALLBACK_MESSAGE_ACK {
        public LRPC_HEADER Header;
        public LRPC_RESPONSE_MESSAGE_FLAGS Flags;
        public uint CallId;

        public LRPC_CALLBACK_MESSAGE_ACK(LRPC_RESPONSE_MESSAGE_FLAGS flags, uint callId) {
            Header = new LRPC_HEADER(LRPC_MESSAGE_TYPE.lmtCallbackAck);
            Flags = flags;
            CallId = callId;
        }
    }
}
