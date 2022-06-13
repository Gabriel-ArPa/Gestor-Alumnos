using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorAlumnos
{
    public partial class Form1 : Form
    {
        Operaciones oper = new Operaciones();

        public Form1()
        {
            InitializeComponent();
        }

        int Codigo()
        {
            try
            {
                return int.Parse(txtCod.Text);

            }
            catch (Exception e)
            {
                MessageBox.Show("Ingrese codigo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
        }

        string Nombre()
        {
            return txtNom.Text;
        }

        string Apellido()
        {
            return txtApe.Text;
        }

        string Sexo()
        {
            return cbxSex.Text;
        }

        int Promedio()
        {
            return int.Parse(txtProm.Text);
        }
        #region Metodos

        void escribir()
        {
            Alumno a = new Alumno(Codigo(), Nombre(), Apellido(), Sexo(), Promedio());
            oper.escribirArchivo(a);
            limpiarFormulario();
        }

        void leer()
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = oper.leerArchivo(GetGrupo());
        }

        void limpiarFormulario()
        {
            txtCod.Text = "";
            txtNom.Text = "";
            txtApe.Text = "";
            cbxSex.Text = "";
            txtProm.Text = "";
        }

        void buscar()
        {
            Alumno x = oper.buscar(Codigo());


            if (x != null)
            {
                txtNom.Text = x.Nombre;
                txtApe.Text = x.Apellido;
                cbxSex.Text = x.Sexo;
                txtProm.Text = x.Promedio.ToString();

            }
        }

        public string GetGrupo()
        {
            if (rbtApro.Checked == true)
            {
                return "aprobados";
            }
            else if (rbtDes.Checked == true)
            {
                return "desaprobados";
            }
            else
            {
                return "todos";
            }

        }

        void eliminar()
        {
            if (txtCod.Text.Length != 0)
            {
                Alumno x = oper.buscar(Codigo());
                oper.eliminar(x);
                leer();
                limpiarFormulario();
            }
            else
            {
                MessageBox.Show("Ingrese codigo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        void modificar()
        {
            Alumno x = oper.buscar(Codigo());
            if (x != null)
            {
                x.Nombre = Nombre();
                x.Apellido = Apellido();
                x.Sexo = Sexo();
                x.Promedio = Promedio();
                ArrayList arrclientes = oper.obtenerarrcliente();
                TextWriter tw = new StreamWriter("alumnos.txt", false);
                tw.Write(string.Empty);
                tw.Close();
                oper.escribirArchivo(arrclientes);
                leer();
                limpiarFormulario();
            }
        }
        #endregion

        #region Botones

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            escribir();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            leer();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }
        #endregion

        private void btnMostarHombres_Click(object sender, EventArgs e)
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = oper.leerArchivo(GetGrupo(), "Masculino");
        }

        private void btnMostarMujeres_Click(object sender, EventArgs e)
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = oper.leerArchivo(GetGrupo(), "Femenino");
        }
    }
}
