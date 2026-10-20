namespace dquinonesS3.Views;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuarioNuevo = txtUsuarioNuevo.Text;
			string contraseñaNueva = txtContraseñaNueva.Text;

			Navigation.PushAsync(new vLogin(usuarioNuevo, contraseñaNueva));
			DisplayAlertAsync("ALERTA", "Usuario Guardado", "Cerrar");


		}
		catch (Exception)
		{

			throw;
		}
    }
}