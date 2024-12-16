namespace FuncionalidadesPO
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void GetDeviceInfo(object sender, EventArgs e)
        {
            InfoDevice.Text = $"Fabricante: {DeviceInfo.Manufacturer}\n" +
                                  $"Modelo: {DeviceInfo.Model}\n" +
                              $"Plataforma: {DeviceInfo.Platform}\n" +
                                 $"Version: {DeviceInfo.Version}";
        }

        public void OnVibrateClicked(object sender, EventArgs e)
        {
            Vibration.Vibrate();
        }

        public void GetBateryInfo(object sender, EventArgs e)
        {
            var level = Battery.ChargeLevel ;
            var state = Battery.State ;
            var source = Battery.PowerSource ;

            InfoBattery.Text = $"Porcentaje de bateria: {level}\n" +
                               $"Estado: {state}\n" +
                               $"Source: {source}";

        }

        public async void Getphoto(object sender, EventArgs e)
        {
            var photo = await MediaPicker.CapturePhotoAsync();
            if (photo != null)
            {
                PhotoImage.Source = ImageSource.FromStream(() => photo.OpenReadAsync().Result);
            }
        }
    }

}
