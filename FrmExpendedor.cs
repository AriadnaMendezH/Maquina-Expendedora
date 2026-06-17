using System;
using System.Windows.Forms;
using Maquina_Expendedora;

namespace Maquina_Expendedora 
{ 

public partial class FrmExpendedor : Form
{
    Menu menu;
    public FrmExpendedor()
    {
        InitializeComponent();
        menu = new Menu();
        MostrarStocks();
    }


    // Método para mostrar los stocks
    private void MostrarStocks()
    {
        foreach (Producto p in menu.ObeteProductos())
        {
            if (p.Nombre == "Poki")
                lblPoki.Text = "Stock: " + p.Stock;
            else if (p.Nombre == "Pay")
                lblPay.Text = "Stock: " + p.Stock;
            else if (p.Nombre == "Yomi")
                lblLeche.Text = "Stock: " + p.Stock;
            else if (p.Nombre == "Vuala")
                lblVuala.Text = "Stock: " + p.Stock;
        }
    }

    // Evento al hacer clic en la imagen de Poki
    private void picPoki_Click(object sender, EventArgs e)
    {
        Producto p = menu.ProductoSelect("Poki");
        if (p != null)
        {
            lblProducto.Text = "Producto: " + p.Nombre;
            lblPrecio.Text = "Precio: $" + p.Precio;
            numericUpDown1.Enabled = true;
            txtPago.Enabled = true;
            btnPagar.Enabled = true;
            CalcularTotal();
        }
    }

    // Evento al hacer clic en la imagen de Pay
    private void picPay_Click(object sender, EventArgs e)
    {
        Producto p = menu.ProductoSelect("Pay");
        if (p != null)
        {
            lblProducto.Text = "Producto: " + p.Nombre;
            lblPrecio.Text = "Precio: $" + p.Precio;
            numericUpDown1.Enabled = true;
            txtPago.Enabled = true;
            btnPagar.Enabled = true;
            CalcularTotal();
        }
    }

    // Evento al hacer clic en la imagen de Yomi
    private void picYomi_Click(object sender, EventArgs e)
    {
        Producto p = menu.ProductoSelect("Yomi");
        if (p != null)
        {
            lblProducto.Text = "Producto: " + p.Nombre;
            lblPrecio.Text = "Precio: $" + p.Precio;
            numericUpDown1.Enabled = true;
            txtPago.Enabled = true;
            btnPagar.Enabled = true;
            CalcularTotal();
        }
    }

    // Evento al hacer clic en la imagen de Vuala
    private void picVuala_Click(object sender, EventArgs e)
    {
        Producto p = menu.ProductoSelect("Vuala");
        if (p != null)
        {
            lblProducto.Text = "Producto: " + p.Nombre;
            lblPrecio.Text = "Precio: $" + p.Precio;
            numericUpDown1.Enabled = true;
            txtPago.Enabled = true;
            btnPagar.Enabled = true;
            CalcularTotal();
        }
    }

    // Método para calcular el total
    private void CalcularTotal()
    {
        string nombreProducto = lblProducto.Text.Replace("Producto: ", "");
        Producto p = menu.ProductoSelect(nombreProducto);

        if (p != null)
        {
            int cantidad = (int)numericUpDown1.Value;
            double total = p.Total(cantidad);
            lblCantidad.Text = "CANTIDAD: " + cantidad;
            lblTotal.Text = "TOTAL: $" + total;
        }
    }

    // Evento cuando cambia la cantidad
    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
        CalcularTotal();
    }

    // Evento del botón Comprar
    private void btnComprar_Click(object sender, EventArgs e)
    {
        string nombreProducto = lblProducto.Text.Replace("Producto: ", "");
        Producto p = menu.ProductoSelect(nombreProducto);

        if (p == null)
        {
            MessageBox.Show("Seleccione un producto");
            return;
        }

        int cantidad = (int)numericUpDown1.Value;
        double total = p.Total(cantidad);

        lblCantidad.Text = "CANTIDAD: " + cantidad;
        lblTotal.Text = "TOTAL: $" + total;

        double dinero;

        if (!double.TryParse(txtPago.Text, out dinero))
        {
            MessageBox.Show("Ingrese dinero válido");
            return;
        }

        if (dinero < total)
        {
            MessageBox.Show("Dinero insuficiente");
            return;
        }

        if (p.Comprar(cantidad))
        {
            double cambio = dinero - total;

            MostrarStocks();
            MessageBox.Show(
                "Compra realizada\nCambio: $" + cambio
            );

            // Resetear el formulario
            lblProducto.Text = "Producto:";
            lblPrecio.Text = "Precio:";
            lblCantidad.Text = "CANTIDAD: 0";
            lblTotal.Text = "TOTAL: $0";
            txtPago.Clear();
            numericUpDown1.Value = 1;
            numericUpDown1.Enabled = false;
            txtPago.Enabled = false;
            btnPagar.Enabled = false;
        }
        else
        {
            MessageBox.Show("Stock insuficiente");
        }
    }
}
}

