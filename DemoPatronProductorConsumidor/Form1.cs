namespace DemoPatronProductorConsumidor
{
    public partial class Form1 : Form
    {
        private int ContadorId = 1;
        private Cola<Usuario> ColaUsuarios;
        private Productor productor;
        private Consumidor consumidor;
        public Form1()
        {
            InitializeComponent();
            ColaUsuarios = new Cola<Usuario>(10);
            productor = new Productor(ColaUsuarios);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

            Usuario nuevoUsuario = new Usuario(
                ContadorId++,
                TxtNombres.Text,
                TxtCorreo.Text
                );

            ThreadPool.QueueUserWorkItem(
            state =>
            {
                ColaUsuarios.Agregar(nuevoUsuario);
            }
             );
            TxtNombres.Clear();
            TxtCorreo.Clear();
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            Thread hiloConsumidor = new Thread(ProcesarUsuario);
            hiloConsumidor.Start();
        }
        private void ProcesarUsuario()
        {
            Usuario usuario = ColaUsuarios.Extraer();
            AgregarUsuarioADatGrid(usuario);
        }
        private void AgregarUsuarioADatGrid(Usuario usuario)
        {
            if (DgvUsuarios.InvokeRequired)
            {
                DgvUsuarios.Invoke(new Action(() =>
                {
                    DgvUsuarios.Rows.Add(
                       usuario.Id, usuario.Nombre,
                       usuario.CorreoElectronico,
                       usuario.FechaCreacion
                       );
                })
                );
            }
            else
            {
                DgvUsuarios.Rows.Add(
                       usuario.Id, usuario.Nombre,
                       usuario.CorreoElectronico,
                       usuario.FechaCreacion
                       );
            }
        }
    }
}
