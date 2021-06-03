using System;
using Xamarin.Forms;

namespace Xamarin.Agora.Full.Forms
{
    public partial class AgoraVideoView : View
    {
        public AgoraVideoView()
        {
            GUID = Guid.NewGuid();
        }

        public static readonly BindableProperty GUIDProperty = BindableProperty.Create(
                                                           "GUID", //Public name to use
                                                           typeof(Guid), //this type
                                                           typeof(AgoraVideoView), //parent type (this control)
                                                           Guid.Empty); //default value

        public Guid GUID
        {
            get => (Guid)GetValue(GUIDProperty);
            protected set => SetValue(GUIDProperty, value);
        }

        public static readonly BindableProperty StreamUIDProperty = BindableProperty.Create(
                                                           "StreamUID", //Public name to use
                                                           typeof(uint), //this type
                                                           typeof(AgoraVideoView), //parent type (this control)
                                                           AgoraService.UnknownRemoteStreamId); //default value

        public uint StreamUID
        {
            get => (uint)GetValue(StreamUIDProperty);
            set => SetValue(StreamUIDProperty, value);
        }

        public bool IsVideoMuted
        {
            get => (bool)GetValue(IsVideoMutedProperty);
            set => SetValue(IsVideoMutedProperty, value);
        }

        public static readonly BindableProperty IsVideoMutedProperty = BindableProperty.Create(
                                                           "IsVideoMuted", //Public name to use
                                                           typeof(bool), //this type
                                                           typeof(AgoraVideoView), //parent type (this control)
                                                           false); //default value
        public bool IsAudioMuted
        {
            get => (bool)GetValue(IsAudioMutedProperty);
            set => SetValue(IsAudioMutedProperty, value);
        }

        public static readonly BindableProperty IsAudioMutedProperty = BindableProperty.Create(
                                                           "IsAudioMuted", //Public name to use
                                                           typeof(bool), //this type
                                                           typeof(AgoraVideoView), //parent type (this control)
                                                           false); //default value

        public bool IsTalking
        {
            get => (bool)GetValue(IsTalkingProperty);
            set => SetValue(IsTalkingProperty, value);
        }

        public static readonly BindableProperty IsTalkingProperty = BindableProperty.Create(
                                                           "IsTalking", //Public name to use
                                                           typeof(bool), //this type
                                                           typeof(AgoraVideoView), //parent type (this control)
                                                           false); //default value

        public bool IsOffline
        {
            get => (bool)GetValue(IsOfflineProperty);
            set => SetValue(IsOfflineProperty, value);
        }

        public static readonly BindableProperty IsOfflineProperty = BindableProperty.Create(
                                                           "IsOffline", //Public name to use
                                                           typeof(bool), //this type
                                                           typeof(AgoraVideoView), //parent type (this control)
                                                           true); //default value

        public bool IsVideoEnabled
        {
            get => (bool)GetValue(IsVideoEnabledProperty);
            set => SetValue(IsVideoEnabledProperty, value);
        }

        public static readonly BindableProperty IsVideoEnabledProperty = BindableProperty.Create(
                                                           "IsVideoEnabled", //Public name to use
                                                           typeof(bool), //this type
                                                           typeof(AgoraVideoView), //parent type (this control)
                                                           true); //default value   

        public VideoDisplayMode Mode
        {
            get => (VideoDisplayMode)GetValue(ModeProperty);
            set => SetValue(ModeProperty, value);
        }

        public static readonly BindableProperty ModeProperty = BindableProperty.Create(
                                                           "Mode", //Public name to use
                                                           typeof(VideoDisplayMode), //this type
                                                           typeof(AgoraVideoView), //parent type (this control)
                                                           VideoDisplayMode.Fit); //default value   


        public bool IsStatic
        {
            get => (bool)GetValue(IsStaticProperty);
            set => SetValue(IsStaticProperty, value);
        }

        public static readonly BindableProperty IsStaticProperty = BindableProperty.Create(
                                                           "IsStatic", //Public name to use
                                                           typeof(bool), //this type
                                                           typeof(AgoraVideoView), //parent type (this control)
                                                           false); //default value

    }
}