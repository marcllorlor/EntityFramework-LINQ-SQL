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
    public partial class FrmAMBMatricules : Form
    {

        private SchoolEntities schoolContext = new SchoolEntities();

        //public Course curs;
        public StudentGrade MatriculesAlumne = new StudentGrade();


        public char operacio = ' ';
        public Boolean hanfetOK = false;

        public int idMatricula = 0;

        public FrmAMBMatricules()
        {
            InitializeComponent();
        }

        private void FrmAMBMatricules_Load(object sender, EventArgs e)
        {
            afegirvalorscomboboxAlumnes();
            afegirvalorscomboboxCursos();
            if (operacio == 'M')
            {
                //Aqui haurem d'agafar les dades de Persona
                agafardadesmatricula();
            }            
        }

        private void agafardadesmatricula()
        {
            MatriculesAlumne = schoolContext.StudentGrade.Find(idMatricula);
            cbNomAlumne.SelectedValue = MatriculesAlumne.StudentID;
            cbNomCurs.SelectedValue = MatriculesAlumne.CourseID;
            if (MatriculesAlumne.Grade == null)
            {
                nudNotaAlumne.Value = 0;
            }
            else
            {
                nudNotaAlumne.Value = (decimal)MatriculesAlumne.Grade;
            }
            
        }

        private bool afegirMatricula()
        {
            this.Cursor = Cursors.WaitCursor;

            Boolean hanfetOK = false;

            if (cbNomCurs.SelectedItem.ToString() == "" || cbNomAlumne.SelectedItem.ToString() == "" || nudNotaAlumne.Value.ToString() == "")
            {
                MessageBox.Show("Has d'omplir totes les dades", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // tractem la taula de cursos com una classe d'objecte
                MatriculesAlumne.CourseID = (int)cbNomCurs.SelectedValue;
                MatriculesAlumne.StudentID = (int)cbNomAlumne.SelectedValue;
                //Aqui hauriem de fer un if per fer que la persona 
                if (cbPosarNota.Checked)
                {
                    MatriculesAlumne.Grade = nudNotaAlumne.Value;
                }
                else
                {
                    MatriculesAlumne.Grade = null;
                }
                

                schoolContext.StudentGrade.Add(MatriculesAlumne);     // la inserció esdevé una crida a Add

                try
                {
                    schoolContext.SaveChanges();
                    hanfetOK = true;// la inserció no es fa efectiva fins que fem el SaveChanges
                }
                catch (Exception excp)
                {
                    MessageBox.Show(excp.Message + Environment.NewLine + excp.InnerException, "Excepció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    schoolContext.StudentGrade.Remove(MatriculesAlumne);     // eliminem la instància que ha provocat l'error per a que no quedi a la cua
                }
            }
            this.Cursor = Cursors.Default;

            return hanfetOK;
        }

        private void afegirvalorscomboboxCursos()
        {
            var qryCursos = (from Cursos in schoolContext.Course
                                 orderby Cursos.Title
                                 select new
                                 {
                                     id = Cursos.CourseID,
                                     nomCurs = Cursos.Title,
                                 });

            cbNomCurs.DataSource = qryCursos.ToList().Distinct().ToList();

            cbNomCurs.DisplayMember = "nomCurs";
            cbNomCurs.ValueMember = "id";
        }

        private void afegirvalorscomboboxAlumnes()
        {
            var qryEstudiants = (from Estudiants in schoolContext.Person
                                 where Estudiants.HireDate == null
                                 orderby Estudiants.LastName
                                 select new
                                 {
                                     id = Estudiants.PersonID,
                                     nomAlumne = Estudiants.FirstName + " " + Estudiants.LastName,
                                 });

            cbNomAlumne.DataSource = qryEstudiants.ToList().Distinct().ToList();

            cbNomAlumne.DisplayMember = "nomAlumne";
            cbNomAlumne.ValueMember = "id";
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            //Aqui haurem de fer tota la gestio de la base de dades i afegir a la nova persona matriculada
            switch (operacio)
            {
                case 'A':
                    hanfetOK = afegirMatricula();
                    break;
                case 'M':
                    hanfetOK = modificarMatricula();
                    break;
                default: break;
            }

            if (hanfetOK)
            {
                this.Close();
            }
        }

        private bool modificarMatricula()
        {
            Boolean xb = false;

            this.Cursor = Cursors.WaitCursor;

            if (cbNomCurs.SelectedItem.ToString() == "" || cbNomAlumne.SelectedItem.ToString() == "" || nudNotaAlumne.Value.ToString() == "")
            {
                MessageBox.Show("Has d'omplir totes les dades", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MatriculesAlumne = schoolContext.StudentGrade.Find(idMatricula);

                MatriculesAlumne.CourseID = (int)cbNomCurs.SelectedValue;
                MatriculesAlumne.StudentID = (int)cbNomAlumne.SelectedValue;
                if (cbPosarNota.Checked)
                {
                    MatriculesAlumne.Grade = nudNotaAlumne.Value;
                }
                else
                {
                    MatriculesAlumne.Grade = null;
                }
                

                try
                {
                    schoolContext.SaveChanges();        // la modificació no es fa efectiva fins que fem el SaveChanges
                    xb = true;
                }
                catch (Exception excp)
                {
                    MessageBox.Show(excp.Message + Environment.NewLine + excp.InnerException, "Excepció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Cursor = Cursors.Default;
            return xb;
        }

        private void cbPosarNota_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPosarNota.Checked)
            {
                nudNotaAlumne.Enabled = true;
            }
            else
            {
                nudNotaAlumne.Enabled = false;
            }
        }
    }
}
