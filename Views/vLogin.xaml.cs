namespace fchTarea2.Views;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        
        string[] usuario = { "carlos", "ana", "jose" };

        
        string[] contrasena = { "carlos123", "ana123", "jose123" };

        
        Console.Write("Ingrese su nombre de usuario: ");
        string usuarioIngresado = txtUsuario.Text;

        
        Console.Write("Ingrese su contrase�a: ");
        string contrasenaIngresada = txtContrase�a.Text;

        
        bool usuarioValido = false;
        for (int i = 0; i < usuario.Length; i++)
        {
            if (usuario[i] == usuarioIngresado && contrasena[i] == contrasenaIngresada)
            {
                Navigation.PushAsync(new vHome(usuarioIngresado));
                break;
            }
        }
        
        if (usuarioValido)
        {
            DisplayAlert("Alerta", "Inicio de sesi�n exitoso", "OK");

        }
        else
        {
            DisplayAlert("ALERTA", "USUARIO Y CONTRASE�A SON INCORRECTOS", "OK");

        }

    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());
    }
}