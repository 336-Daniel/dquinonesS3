namespace dquinonesS3.Views;

public partial class vReporte : ContentPage
{
	public vReporte(string usuario)
	{
		InitializeComponent();
		DisplayAlertAsync("BIENVENIDO", usuario, "CERRAR");
	}
}