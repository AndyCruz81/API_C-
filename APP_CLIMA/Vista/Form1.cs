using APP_CLIMA.Controlador;
using APP_CLIMA.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace APP_CLIMA
{
    public partial class Form1 : Form
    {
        private CiudadControl ciudadControl;
        private CiudadInfo ciudadInfo;

        public Form1()
        {
            InitializeComponent();
            ciudadControl = new CiudadControl();
            ciudadInfo = new CiudadInfo();
        }

        private async void GetInfoCiudad(string C)
        {
            ciudadInfo = await ciudadControl.GetInfoCiudad(C);

            if (ciudadInfo != null)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvPrincipal);

                row.Cells[0].Value = ciudadInfo.Main.Temperatura;
                row.Cells[1].Value = ciudadInfo.Main.TempMin;
                row.Cells[2].Value = ciudadInfo.Main.TempMax;
                row.Cells[3].Value = ciudadInfo.Main.Humedad;

                dgvPrincipal.Visible = true;
                dgvPrincipal.Rows.Add(row);
            }
            else
            {
                MessageBox.Show("No se pudo cargar la Informacion de la API..", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CiudadControl ciudadControl = new CiudadControl(); // Asegúrate de instanciarlo

            // Obtener ciudades de forma asíncrona
            List<string> ciudades = ciudadControl.GetCiudadesDisponibles();

            if (ciudades != null && ciudades.Count > 0)
            {
                cboCiudades.DataSource = ciudades;
            }
            else
            {
                MessageBox.Show("No se encontraron ciudades.");
            }
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            if (cboCiudades.SelectedItem != null)
            {
                string ciudadSeleccionada = cboCiudades.SelectedItem.ToString();
                GetInfoCiudad(ciudadSeleccionada);
            }
        }


    }
}
