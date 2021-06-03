using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgoraVideoCall.ViewModels
{
    public class ConnectViewModel : BaseViewModel
    {
        private string _roomName;

        public string RoomName
        {
            get => _roomName;
            set => SetProperty(ref _roomName, value);
        }

        public ConnectViewModel()
        {
            Title = "Join Room";
            CheckPermissionsAndStart();
        }

        private async Task CheckPermissionsAndStart()
        {
            if (Device.RuntimePlatform != Device.macOS)
            {
                List<Permission> permissionsToRequest = new List<Permission>();
                PermissionStatus cameraPermissionState = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Camera);
                if (cameraPermissionState != PermissionStatus.Granted)
                {
                    permissionsToRequest.Add(Permission.Camera);
                }

                PermissionStatus microphonePermissionState = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Microphone);
                if (microphonePermissionState != PermissionStatus.Granted)
                {
                    permissionsToRequest.Add(Permission.Microphone);
                }

                if (permissionsToRequest.Count > 0)
                {
                    await CrossPermissions.Current.RequestPermissionsAsync(permissionsToRequest.ToArray());
                }
            }
        }
    }
}
