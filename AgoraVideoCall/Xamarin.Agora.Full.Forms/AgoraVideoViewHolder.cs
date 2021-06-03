using System;

namespace Xamarin.Agora.Full.Forms
{
    public class AgoraVideoViewHolder<T>
    {
        public AgoraVideoView VideoView { get; set; }

        public T NativeView { get; set; }

        public Guid GUID => VideoView.GUID;

        public bool IsStatic => VideoView.IsStatic;

        public uint StreamUID
        {
            get => VideoView.StreamUID;
            set => VideoView.StreamUID = value;
        }

        public AgoraVideoViewHolder(AgoraVideoView view, T nativeView)
        {
            VideoView = view;
            NativeView = nativeView;
        }
    }
}
