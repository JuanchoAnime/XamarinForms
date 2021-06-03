namespace Xamarin.Agora.Full.Forms
{
    public class AgoraServiceDroid
    {
        /// <summary>
        /// Init this instance.
        /// </summary>
        public static void Init()
        {
            AgoraService.Init(new AgoraServiceImplementation());
        }
    }
}