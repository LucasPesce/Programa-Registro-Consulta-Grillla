using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace PRACTICA_PARCIAL_II
{
    public partial class Form1 : Form
    {
        //---------- Clase/Struct Cliente - Declaracion ---------->
        public struct CLIENTE
        {
            public string Cliente;
            public string Dìspositivo;
            public string Reparacion;
            public int Pago;
            public float Importe;
        }        

        //---------- Declaracion de Lista y Contador ---------->
        public CLIENTE[] Clientes;
        const int MAX = 30;
        public int CONTADOR;

        //---------- Variables ---------->
        int Smartphone = 2500;
        int Tablet  = 1850;
        int ConsolaDeVideojuego = 3000;

        int Pantalla = 2500;
        int Teclado = 1500;
        int SistemaOperativo = 1000;

        float DescuentoContado = 0.2f;
        float RecargoCredito = 0.05f;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //---------- CONTADOR Inicializado ---------->
            CONTADOR = 0;

            //---------- Creacion de Lista y asignacion de valores nulos ---------->
            Clientes = new CLIENTE[MAX];
            
            for(int i = 0; i < MAX; i++)        
            {
                Clientes[i].Cliente = "";
                Clientes[i].Dìspositivo = "";
                Clientes[i].Reparacion = "";
                Clientes[i].Pago = 0;
                Clientes[i].Importe = 0; 
            }

            //---------- Cargado de Items de Tipo de Dispositivos ---------->
            cmbConsultaTipoDispositivo.Items.Add("Smartphone");
            cmbConsultaTipoDispositivo.Items.Add("Tablet");
            cmbConsultaTipoDispositivo.Items.Add("Consola de VideoJuego");

            //---------- Cargado de Items de Tipo de Reparación ---------->
            cmbReparacion.Items.Add("Pantalla");
            cmbReparacion.Items.Add("Teclado");
            cmbReparacion.Items.Add("Sistema Operativo");

            //---------- Solo Lectura ---------->
            txtImporteTotal.ReadOnly = true;

            //---------- Cargado de Items de Tipo de Dispositivos/Seccion Consulta ---------->
            cmbTipoDispositivo.Items.Add("Smartphone");
            cmbTipoDispositivo.Items.Add("Tablet");
            cmbTipoDispositivo.Items.Add("Consola de VideoJuego");

            Limpiar();
        }

        //---------- Metodo Limpiar ---------->
        private void Limpiar ()
        {
            txtNombreCliente.Text = "";
            cmbTipoDispositivo.SelectedIndex = 0;
            cmbReparacion.SelectedIndex = 0;
            OpcContado.Checked = true;

            cmbConsultaTipoDispositivo.SelectedIndex = 0;

            txtImporteTotal.Text = "";

        }

        //---------- Boton Limpiar ---------->
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        //---------- Boton Calcular ---------->
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float ImporteTotal = 0;

            //---------- Calculo del Tipo de Dispositivo ---------->
            switch (cmbTipoDispositivo.SelectedIndex)
            {
                case 0: ImporteTotal += Smartphone ;break;
                case 1: ImporteTotal += Tablet; break;
                case 2: ImporteTotal += ConsolaDeVideojuego; break;
            }

            //---------- Calculo del Tipo de Reparacion ---------->
            switch (cmbReparacion.SelectedIndex)
            {
                case 0: ImporteTotal += Pantalla; break;
                case 1: ImporteTotal += Teclado; break;
                case 2: ImporteTotal += SistemaOperativo; break;
            }

            //---------- Calculo del Descuento/Recargo ---------->
            if (OpcContado.Checked == true) 
            {
                ImporteTotal -= (ImporteTotal * DescuentoContado);
            }
            else if (OpcCredito.Checked == true)
            {
                ImporteTotal += (ImporteTotal * RecargoCredito);
            }

            txtImporteTotal.Text = ImporteTotal.ToString();
        }

        //---------- Boton Registrar ---------->
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //---------- Error Campo del NOMBRE DEL CLIENTE vacío ---------->
            if (txtNombreCliente.Text == "")
            {
                MessageBox.Show("Complete el campo Nombre del Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNombreCliente.Text != "")
            {
                //---------- Error Campo del NOMBRE DEL CLIENTE con menos de 3 caracteres ---------->
                if (txtNombreCliente.Text.Length < 3)
                {
                    MessageBox.Show("El nombre del cliente debe tener al menos 3 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //---------- REGISTRO de datos en la LISTA---------->
                else
                {
                    if (CONTADOR < MAX)
                    {
                        Clientes[CONTADOR].Cliente = txtNombreCliente.Text;
                        Clientes[CONTADOR].Dìspositivo = cmbTipoDispositivo.Text;
                        Clientes[CONTADOR].Reparacion = cmbReparacion.Text;

                        if (OpcContado.Checked == true)
                        {
                            Clientes[CONTADOR].Pago = 1;
                        }
                        else if (OpcCredito.Checked == true)
                        {
                            Clientes[CONTADOR].Pago = 2;

                        }
                        //---------- Error IMPORTE TOTAL vacío ---------->
                        if (txtImporteTotal.Text != "")
                        {
                            Clientes[CONTADOR].Importe = float.Parse(txtImporteTotal.Text);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Importe total vacío. Realizar el calculo primero, para registrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        CONTADOR++;
                    }
                    //---------- Error carga de datos COMPLETADA ---------->
                    else if(CONTADOR == MAX)
                    {
                        MessageBox.Show("Se alcanzo la capacidad maxima de carga de datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        btnRegistrar.Enabled = false;
                    }
                }
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //---------- LIMPIA la GRILLA ---------->
            dgvCONSULTA.Rows.Clear();

            //---------- CONSULTAR LISTA ---------->
            for(int i = 0; i < CONTADOR; i++)
            {
                switch(cmbConsultaTipoDispositivo.SelectedIndex)
                {
                    case 0:
                        if (Clientes[i].Dìspositivo == cmbConsultaTipoDispositivo.Text)
                        {
                            dgvCONSULTA.Rows.Add(Clientes[i].Cliente, Clientes[i].Dìspositivo,
                                Clientes[i].Reparacion, Clientes[i].Pago, Clientes[i].Importe);
                        }
                        break;

                    case 1:
                        if (Clientes[i].Dìspositivo == cmbConsultaTipoDispositivo.Text)
                        {
                            dgvCONSULTA.Rows.Add(Clientes[i].Cliente, Clientes[i].Dìspositivo,
                                Clientes[i].Reparacion, Clientes[i].Pago, Clientes[i].Importe);
                        }
                        break;

                    case 2:
                        if (Clientes[i].Dìspositivo == cmbConsultaTipoDispositivo.Text)
                        {
                            dgvCONSULTA.Rows.Add(Clientes[i].Cliente, Clientes[i].Dìspositivo,
                                Clientes[i].Reparacion, Clientes[i].Pago, Clientes[i].Importe);
                        }
                        break;
                }
            }
        }
    }
}
