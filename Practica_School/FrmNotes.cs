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
    public partial class FrmNotes : Form
    {
        public FrmNotes()
        {
            InitializeComponent();
        }

        private SchoolEntities schoolContext = new SchoolEntities();

        private void FrmNotes_Load(object sender, EventArgs e)
        {
            //Aqui haurem d'afegir els valors a dins del combo box per veure tots els cursos de tots els departaments amb totes les notes de les persones
            afegirvalorscombobox();
        }

        private void btnBotoBuscar_Click(object sender, EventArgs e)
        {
            selectdadesgridview();
            posaravisible();
        }

        private void selectdadesgridview()
        {
            var qryMatricules = (from NotesAlumnes in schoolContext.StudentGrade
                                 where NotesAlumnes.Course.Title == cbNomAssignatura.Text
                                 orderby NotesAlumnes.Person.FirstName
                                 select new
                                 {
                                     nomAlumne = NotesAlumnes.Person.FirstName + " " + NotesAlumnes.Person.LastName,
                                     nota = NotesAlumnes.Grade,
                                 });


            dgEstudiants.DataSource = qryMatricules.ToList().Distinct().ToList();
        }

        private void afegirvalorscombobox()
        {
            var qryMatricules = (from Curs in schoolContext.Course
                                 orderby Curs.Title
                                 select new
                                 {
                                     nomCurs = Curs.Title,
                                     idCurs = Curs.CourseID,
                                 });


            cbNomAssignatura.DataSource = qryMatricules.ToList().Distinct().ToList();

            cbNomAssignatura.DisplayMember = "nomCurs";
            cbNomAssignatura.ValueMember = "idCurs";
        }

        private void posaravisible()
        {
            lbNomAssignatura.Text = "Estas mirant les notes de: " + cbNomAssignatura.Text;
            lbNomAssignatura.Visible = true;

            dgEstudiants.Visible = true;
            btDel.Visible = true;
            btNou.Visible = true;
        }
    }
}
