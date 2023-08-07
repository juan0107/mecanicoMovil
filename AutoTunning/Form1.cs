using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTunning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void grp_user_Enter(object sender, EventArgs e)
        {

        }

        private void txt_liquido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(Convert.ToString(txt_nombre.Text), Convert.ToString(txt_apellido.Text), Convert.ToString(txt_correo.Text), Convert.ToString(txt_numero.Text));

            Automovil auto = new Automovil(Convert.ToInt32(txt_kilometraje.Text),
                                           Convert.ToInt32(txt_consumo.Text),
                                           Convert.ToString(txt_aspiracion.Text),
                                           Convert.ToInt32(txt_potencia.Text),
                                           Convert.ToInt32(txt_torque.Text),
                                           Convert.ToString(txt_tipotransmision.Text),
                                           Convert.ToString(txt_tipoembrague.Text),
                                           Convert.ToString(txt_liquido.Text),
                                           Convert.ToString(txt_escape.Text),
                                           Convert.ToString(txt_modeloecu.Text),
                                           Convert.ToString(txt_suspension.Text),
                                           Convert.ToString(txt_traccion.Text),
                                           Convert.ToString(txt_marca.Text),
                                           Convert.ToString(txt_modelo.Text),
                                           Convert.ToString(txt_cilindrada.Text),
                                           Convert.ToString(txt_modelo.Text),
                                           Convert.ToString(txt_modelomotor.Text),
                                           Convert.ToString(txt_freno.Text)
                                           );
        }

        private void txt_suspension_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
