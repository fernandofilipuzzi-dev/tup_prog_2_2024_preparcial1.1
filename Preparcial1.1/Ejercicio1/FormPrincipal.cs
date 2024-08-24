using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        ArrayList envios = new ArrayList();

        private void btnAltaEnvio_Click(object sender, EventArgs e)
        {
            Envio env;
            
            env=new Envio();
            env.AgregarCosto(new Fijo("Peaje puente Zárate", 300));
            env.AgregarCosto(new Variable("Combustible", 1500.5, 500));
            envios.Add(env);

            env = new Envio();
            env.AgregarCosto(new Fijo("Peaje túnel", 300));
            env.AgregarCosto(new Variable("Horas de conducción", 500, 10));
            envios.Add(env);
        }

        private void btnListarEnvios_Click(object sender, EventArgs e)
        {
            foreach (Envio env in envios)
            {
                tbEnviosDetalles.Text += env.VerDetalle()+ "\r\n";
                tbEnviosDetalles.Text += $"Total:$ {env.ValorTotal,10:f2}\r\n\r\n";
            }
        }
    }
}
