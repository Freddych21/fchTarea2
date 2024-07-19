namespace fchTarea2.Views;

public partial class vNotas : ContentPage
{
	public vNotas()
	{
		InitializeComponent();
	}

    private void btbCalcular_Clicked(object sender, EventArgs e)
    {
        if (pkEstudiantes.SelectedIndex >= 0)
        {
            string estudiante = pkEstudiantes.Items[pkEstudiantes.SelectedIndex];
            string fecha = dpFecha.Date.ToString("dd/MM/yyyy");
            double notaP1 = Convert.ToDouble(txtDato1.Text);
            double notaP2 = Convert.ToDouble(txtDato2.Text);
            double examen = Convert.ToDouble(txtDato3.Text);
            double examen2 = Convert.ToDouble(txtDato4.Text);

            
            double multip1 = notaP1 * 0.3;
            double multiExa = examen * 0.2;
            double resultadop1 = multip1 + multiExa;
            resultadop1 = Math.Round(resultadop1, 2);

            
            double multip2 = notaP2 * 0.3;
            double multiExa2 = examen2 * 0.2;
            double resultadop2 = multip2 + multiExa2;
            resultadop2 = Math.Round(resultadop2, 2);
            double sumaTotal = resultadop1 + resultadop2;

            if (sumaTotal >= 7)
            {
                DisplayAlert($"{fecha} \n Estimad@ {estudiante} ", $"Sus notas son: \n Parcial 1: {resultadop1}\n Parcial 2: {resultadop2} \n Aprobado con {sumaTotal} ", "CERRAR");
            }
            else
            {
                DisplayAlert($"{fecha} \n Estimad@ {estudiante} ", $"Sus notas son: \n Parcial 1: {resultadop1}\n Parcial 2: {resultadop2} \n Reprobado con {sumaTotal} ", "CERRAR");


            }
        }
        else
        {
            DisplayAlert("ERROR", "Seleccione un estudiante", "CERRAR");
        }
    }

    private void txtDato1_TextChanged(object sender, TextChangedEventArgs e)
    {
        string nombre = "txtDato1";
        validacion(txtDato1.Text, nombre);
    }

    private void validacion(string valorCampo, string nombreCampo)
    {
        try
        {
            if (!string.IsNullOrWhiteSpace(valorCampo))
            {
                double nota = Convert.ToDouble(valorCampo);
                if (nota > 10 || nota < 0)
                {
                    DisplayAlert("Valor incorrecto", "RANGO 0-10 ", "CERRAR");

                    vaciarCampos(nombreCampo);

                }
            }
        }
        catch (Exception)
        {

        }
    }

    private void vaciarCampos(object nombreCampo)
    {
        switch (nombreCampo)
        {
            case "txtnotaP1":
                txtDato1.Text = "";
                txtDato1.Focus();
                break;

            case "txtnotaP2":
                txtDato2.Text = "";
                txtDato2.Focus();
                break;
            case "txtnotaExamen":
                txtDato3.Text = "";
                txtDato3.Focus();
                break;
            case "txtnotaExamen2":
                txtDato4.Text = "";
                txtDato4.Focus();
                break;
        }
    }

    private void txtDato2_TextChanged(object sender, TextChangedEventArgs e)
    {
        string nombre = "txtDato2";
        validacion(txtDato2.Text, nombre);
    }

    private void txtDato3_TextChanged(object sender, TextChangedEventArgs e)
    {
        string nombre = "txtDato3";
        validacion(txtDato3.Text, nombre);
    }

    private void txtDato4_TextChanged(object sender, TextChangedEventArgs e)
    {
        string nombre = "txtDato4";
        validacion(txtDato4.Text, nombre);
    }
}