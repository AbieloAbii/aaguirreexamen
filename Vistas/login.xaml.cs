namespace aaguirreexamen.Vistas;

public partial class login : ContentPage
{
	public login()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        //Creaci�n de los usuarios
        string[] usuarios = { "estudiante2024", "examen1", "NombreEstudiante" };
        string[] contrasenas = { "uisrael2024", "parcial1", "2024" };

        string usuario = txtUsuario.Text;
        string contrasena = txtContrasena.Text;

        bool verificar = false;

        //Recorrer los usuarios 
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuario == usuarios[i] && contrasena == contrasenas[i])
            {
                verificar = true;
                break; //Salimos del bucle si encontr� coincidencias
            }
        }


        //Verificamos credenciales
        if (verificar == true)
        {
            Navigation.PushAsync(new registro(usuario));
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contrase�a incorrectos", "Cancelar");
        }

    }

    private void btnIniciar_Clicked_1(object sender, EventArgs e)
    {

    }
}