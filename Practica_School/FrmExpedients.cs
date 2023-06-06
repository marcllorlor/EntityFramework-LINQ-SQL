using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_School
{
    public partial class FrmExpedients : Form
    {
        private SchoolEntities schoolContext = new SchoolEntities();

        public StudentGrade MatriculesAlumne = new StudentGrade();

        public FrmExpedients()
        {
            InitializeComponent();
        }

        private void btnBotoBuscar_Click(object sender, EventArgs e)
        {
            busquedapernomdepersona();
            lbEstudiants.Text = "Estas mirant les notes de: " + cbNomAlumne.Text;
            lbEstudiants.Visible = true;
            dgEstudiants.Visible = true;
        }

        private void busquedapernomdepersona()
        {
            var qryMatricules = (from MatriculaAlumne in schoolContext.StudentGrade
                                 orderby MatriculaAlumne.Course.Title
                                 where MatriculaAlumne.StudentID == (int)cbNomAlumne.SelectedValue
                                 select new
                                 {
                                     nomCurs = MatriculaAlumne.Course.Title,
                                     nota = MatriculaAlumne.Grade,
                                 });


            dgEstudiants.DataSource = qryMatricules.ToList().Distinct().ToList();
        }

        private void FrmExpedients_Load(object sender, EventArgs e)
        {
            //Aqui hem de fer la carrega de les ids i el nom de la persona i posarlo a dins del combobox
            carregarvalorcomboboxalumnes();
        }

        private void carregarvalorcomboboxalumnes()
        {
            var qryEstudiants = (from Estudiants in schoolContext.Person
                                 where Estudiants.HireDate == null
                                 orderby Estudiants.FirstName, Estudiants.LastName
                                 select new
                                 {
                                     id = Estudiants.PersonID,
                                     nomAlumne = Estudiants.FirstName + " " + Estudiants.LastName,
                                 });

            cbNomAlumne.DataSource = qryEstudiants.ToList().Distinct().ToList();

            cbNomAlumne.DisplayMember = "nomAlumne";
            cbNomAlumne.ValueMember = "id";
        }
    }
}
