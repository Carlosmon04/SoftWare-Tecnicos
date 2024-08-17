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

      

    }
}
