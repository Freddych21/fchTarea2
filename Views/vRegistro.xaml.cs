using Android.Webkit;

namespace fchTarea2.Views;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {

        DisplayAlert("ALERTA", "USUARIO GUARDADO", "OK");
        Navigation.PushAsync(new vLogin());
    }

    private void btnCancelar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vLogin());
    }
}