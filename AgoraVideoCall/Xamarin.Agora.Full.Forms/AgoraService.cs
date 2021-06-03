using System;
using System.Threading;

namespace Xamarin.Agora.Full.Forms
{
    public class AgoraService
    {
        public const uint UnknownLocalStreamId = 0;

        public const uint UnknownRemoteStreamId = 1;

        static readonly Lazy<IAgoraService> Implementation = new Lazy<IAgoraService>(() => CreateService(), LazyThreadSafetyMode.PublicationOnly);

        static IAgoraService CreateService()
        {
#if NETSTANDARD2_0
            return null;
#else
            return new AgoraServiceImplementation();
#endif
        }

        public static IAgoraService Instance 
        {
            get {
                IAgoraService realValue = Implementation.Value ?? throw new NotImplementedException();
                return realValue;
            }
        }

        public static IAgoraService Current { get; private set; }

        public static void Init(IAgoraService instance)
        {
            Current = instance;
        }
    }
}
