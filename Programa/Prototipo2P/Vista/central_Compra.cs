using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class central_Compra : Form
    {
        public central_Compra()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            //Metodo para cubrir los paneles
            panelCompras.Visible = false;
 
        }

        private void hideSubMenu()
        {
            if (panelCompras.Visible == true)
                panelCompras.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCompras);
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formulario = new ComprasCompras();
            formulario.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnRecepción_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formRecepcionesCompras = new RecepcionesCompras();
            formRecepcionesCompras.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formOrdenesCompras = new OrdenesCompras();
            formOrdenesCompras.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnComprobantesCompras_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formComprobantesCompras = new ComprobantesCompras();
            formComprobantesCompras.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnCajaClientes_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }


        private void btnComprobantesProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnMovimientosProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnCajaProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }



    }
}
