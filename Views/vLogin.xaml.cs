namespace dquinonesS3.Views;

public partial class vLogin : ContentPage
{

    string usuario= " ", contraseña= " ";
    
	public vLogin()
	{
		InitializeComponent();
	}

    public vLogin(string nuevoUsuario, string nuevaContraseña)
    {
        InitializeComponent();
        usuario = nuevoUsuario;
        contraseña = nuevaContraseña;
    }

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        try
        {
            string usuarioIngreso = txtUsuario.Text;
            string contraseñaIngreso = txtContraseña.Text;

            if (usuarioIngreso == usuario && contraseñaIngreso == contraseña)
            {
                Navigation.PushAsync(new vReporte(usuario));
            }else
            {
                DisplayAlertAsync("ALERTA", "Usuario o contraseña incorrecta", "ok");
            }

        }
        catch (Exception ex)
        {
            DisplayAlertAsync("ERROR", ex.Message, "CERRAR");

        }


    }

    private void btnRegistrarse_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());


    }
}