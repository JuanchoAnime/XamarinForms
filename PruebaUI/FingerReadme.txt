Finger Print
	Android
	=>
	AndroidManifest.xml,  Agregar permiso => <uses-permission android:name="android.permission.USE_FINGERPRINT" />
	Install nuget Plugin.CurrentActivity
	En el MainActivity => agregar CrossCurrentActivity.Current.Init(this, savedInstanceState);, Con el using => using Plugin.CurrentActivity;
	
	Install => Xamarin.AndroidX.Browser, Xamarin.AndroidX.Legacy.Support.V4, Xamarin.AndroidX.Lifecycle.LiveData, Xamarin.Google.Android.Material

	
	IOS => solo agreguemos el permiso para hacer uso del Face ID
	
	Xamarin Forms
	=>
	Instalar el NuGet Plugin.CurrentActivity
		Android => Agregar en el MainActivity => CrossFingerprint.SetCurrentActivityResolver(() => CrossCurrentActivity.Current.Activity);
			   con el using => using Plugin.Fingerprint;
	
	Y Ya puedes usarlo