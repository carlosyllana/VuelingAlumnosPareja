using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vueling.Business.Logic;
using Vueling.Common.Logic.Model;

namespace Vueling.Presentation.WinSite
{
    public partial class AlumnosShowForm : Form
    {
        private List<Alumno> listaAlumnos;
       
        private IAlumnoBL<Alumno> alumnoBL;

        public AlumnosShowForm()
        {
            InitializeComponent();
            alumnoBL = new AlumnoBl();
            alumnoBL.Formatear(TipoFichero.TXT);
            listaAlumnos = alumnoBL.GetList();
            this.dataGridView1.DataSource = listaAlumnos;
        }

   

        private void btnshowjson_Click(object sender, EventArgs e)
        {
            alumnoBL.Formatear(TipoFichero.JSON);
            listaAlumnos = alumnoBL.GetList();
            this.dataGridView1.DataSource = listaAlumnos;
        }

        private void btnshowxml_Click(object sender, EventArgs e)
        {
            alumnoBL.Formatear(TipoFichero.XML);
            listaAlumnos = alumnoBL.GetList();
            this.dataGridView1.DataSource = listaAlumnos;
        }

        private void btnShowTxt_Click(object sender, EventArgs e)
        {
            alumnoBL.Formatear(TipoFichero.TXT);
            listaAlumnos = alumnoBL.GetList();
            this.dataGridView1.DataSource = listaAlumnos;
        }

        private void btnAñadirAlumnos_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(this.textBox1.Text)) { 
            var query =
                from Alumno item in listaAlumnos
                where item.nombre == this.textBox1.Text
                select item;
            this.dataGridView1.DataSource = query.ToList();
            }
            else
            {
                this.dataGridView1.DataSource = listaAlumnos;
            }
        }
    }
}
