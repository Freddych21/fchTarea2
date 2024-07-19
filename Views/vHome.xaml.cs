namespace fchTarea2.Views;

public partial class vHome : ContentPage
{
    public vHome(string nombre)
    {
        InitializeComponent();
        lblNombre.Text = "Bienvenido " + nombre;

    }

    private void btbRegistrarNotas_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vNotas());
    }
}