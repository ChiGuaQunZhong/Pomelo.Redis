#if !FEATURE_SOCKET_MODE_POLL

namespace Pomelo.Redis
{
    partial class SocketManager
    {
        internal const SocketMode DefaultSocketMode = SocketMode.Async;

        private void OnAddRead(System.Net.Sockets.Socket socket, ISocketCallback callback)
        {
            throw new System.NotSupportedException();
        }
    }
}

#endif