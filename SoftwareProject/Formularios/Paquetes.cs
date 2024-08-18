using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoftwareProject.Formularios
{
    public partial class Paquetes : Form
    {
        private SqlConnection cnx;
        private int userID;

        SqlCommand cmd;
        SqlDataReader data;

        string Panel1Ser1, Panel1Ser2, Panel1Ser3,
               Panel2Ser1, Panel2Ser2, Panel2Ser3,
               Panel3Ser1, Panel3Ser2, Panel3Ser3;

        public Paquetes()
        {
            InitializeComponent();
        }
        public Paquetes(SqlConnection conexion, int usuario)
        {
            InitializeComponent();
            cnx = conexion;
            userID = usuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Paquetes_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            try
            {
                cmd = new SqlCommand("spServioPorPaquete", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@paqueteid", 1);

                
                data=cmd.ExecuteReader();

                List<string> columna1Datos = new List<string>();

                while (data.Read())
                {
                    // Accede a los datos de cada fila
                    string valorColumna1 = data["nombre"].ToString();
                    columna1Datos.Add(valorColumna1);
                }

                Panel1Ser1 = columna1Datos[0];
                Panel1Ser2 = columna1Datos[1];
                Panel1Ser3 = columna1Datos[2];
                
                data.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrio un Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Servicio1.Text = Panel1Ser1;
            servicio2.Text = Panel1Ser2;
            servicio3.Text = Panel1Ser3;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                cmd = new SqlCommand("spServioPorPaquete", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@paqueteid", 2);


                data = cmd.ExecuteReader();

                List<string> columna1Datos = new List<string>();

                while (data.Read())
                {
                    // Accede a los datos de cada fila
                    string valorColumna1 = data["nombre"].ToString();
                    columna1Datos.Add(valorColumna1);
                }

                Panel2Ser1 = columna1Datos[0];
                Panel2Ser2 = columna1Datos[1];
                Panel2Ser3 = columna1Datos[2];

                data.Close();

                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrio un Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Servicio4.Text = Panel2Ser1;
            Servicio5.Text = Panel2Ser2;
            Servicio6.Text = Panel2Ser3;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                cmd = new SqlCommand("spServioPorPaquete", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@paqueteid", 3);


                data = cmd.ExecuteReader();

                List<string> columna1Datos = new List<string>();

                while (data.Read())
                {
                    // Accede a los datos de cada fila
                    string valorColumna1 = data["nombre"].ToString();
                    columna1Datos.Add(valorColumna1);
                }

                Panel3Ser1 = columna1Datos[0];
                Panel3Ser2 = columna1Datos[1];
                Panel3Ser3 = columna1Datos[2];

                data.Close();

                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrio un Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Servicio7.Text = Panel3Ser1;
            Servicio8.Text = Panel3Ser2;
            Servicio9.Text = Panel3Ser3;

        }
       

    }
}
