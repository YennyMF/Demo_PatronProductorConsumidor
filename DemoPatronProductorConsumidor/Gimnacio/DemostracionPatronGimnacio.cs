using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoPatronProductorConsumidor.Gimnacio
{
    public partial class DemostracionPatronGimnacio : Form
    {
        private int ContadorId = 1;
        private ColaGim<Clientes> ColaClientes;
        private ProductorGim productor;
        private ConsumidorGim consumidor;
        public DemostracionPatronGimnacio()
        {
            InitializeComponent();
            ColaClientes = new ColaGim<Clientes>(10);
            productor = new ProductorGim(ColaClientes);
        }
        private void BtnRegistrar_Click_1(object sender, EventArgs e)
        {

            Clientes nuevoCliente = new Clientes(
                ContadorId++,
                TxtNombres.Text,
                TxtCorreo.Text,
                txtTelefono.Text
                );

            ThreadPool.QueueUserWorkItem(
            state =>
            {
                ColaClientes.Agregar(nuevoCliente);
            }
             );
            TxtNombres.Clear();
            TxtCorreo.Clear();
            txtTelefono.Clear();
        }

        private void BtnProcesar_Click_1(object sender, EventArgs e)
        {
            Thread hiloConsumidor = new Thread(ProcesarCliente);
            hiloConsumidor.Start();
        }
        private void ProcesarCliente()
        {
            Clientes clientes = ColaClientes.Extraer();
            AgregarClientesADatGrid(clientes);
        }
        private void AgregarClientesADatGrid(Clientes clientes)
        {
            if (DgvClientes.InvokeRequired)
            {
                DgvClientes.Invoke(new Action(() =>
                {
                    DgvClientes.Rows.Add(
                       clientes.Id_gimnasio, clientes.Nombre,
                       clientes.CorreoElectronico,
                       clientes.Telefono,
                       clientes.FechaInauguracion
                       );
                })
                );
            }
            else
            {
                DgvClientes.Rows.Add(
                       clientes.Id_gimnasio, clientes.Nombre,
                       clientes.CorreoElectronico,
                       clientes.Telefono,
                       clientes.FechaInauguracion
                       );
            }
        }
    }
}

          

       