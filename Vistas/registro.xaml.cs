namespace aaguirreexamen.Vistas;

public partial class registro : ContentPage
{
	public registro( string usuario)
	{
		InitializeComponent();
        lblUsuario.Text = "Usuario conectado:" + usuario;
    }
}