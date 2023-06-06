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
    public partial class FrmMatricules : Form
    {

        private SchoolEntities schoolContext = new SchoolEntities();

        public Course curs;
        public FrmMatricules()
        {
            InitializeComponent();
        }

        private void FrmMatricules_Load(object sender, EventArgs e)
        {
            consultaMatricules();
            iniGrid();
        }

        private void iniGrid()
        {
            dgMatricules.Columns[0].Visible = false;
            dgMatricules.Columns[2].Visible = false;
            dgMatricules.Columns[5].Visible = false;
            //dgMatricules.Columns[1].HeaderText = "nom família";
            dgMatricules.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgMatricules.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgMatricules.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void consultaMatricules()
        {
            var qryMatricules = (from MatriculaAlumne in schoolContext.StudentGrade
                                 orderby MatriculaAlumne.Person.PersonID
                                 select new
                                 {
                                     idCurs = MatriculaAlumne.Course.CourseID,
                                     nomCurs = MatriculaAlumne.Course.Title,
                                     idAlumne = MatriculaAlumne.Person.PersonID,
                                     nomAlumne = MatriculaAlumne.Person.FirstName + " " + MatriculaAlumne.Person.LastName,
                                     nota = MatriculaAlumne.Grade,
                                     idMatricula = MatriculaAlumne.EnrollmentID,
                                 });


            dgMatricules.DataSource = qryMatricules.ToList().Distinct().ToList();
        }

        private void btNou_Click(object sender, EventArgs e)
        {
            FrmAMBMatricules frm = new FrmAMBMatricules();

            frm.Text = "Donar d'alta alumne a matricula";
            frm.operacio = 'A';
            
            frm.ShowDialog();
            if (frm.hanfetOK)
            {
                consultaMatricules();
            }
            frm = null;
            GC.Collect();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int idMatricula = -1;
            StudentGrade Matricula;

            if (dgMatricules.SelectedRows.Count > 0 && dgMatricules.SelectedRows[0].Cells[4] == null)
            {
                this.Cursor = Cursors.WaitCursor;
                idMatricula = Convert.ToInt32(dgMatricules.SelectedRows[0].Cells[5].Value);   // agafem la clau primària
                Matricula = schoolContext.StudentGrade.Find(idMatricula);                           // busquem a la taula de cursos per clau primària
                schoolContext.StudentGrade.Remove(Matricula);                                  // eliminem 

                try
                {
                    schoolContext.SaveChanges();        // l'eliminació no es fa efectiva fins que fem el SaveChanges
                }
                catch (Exception excp)
                {
                    MessageBox.Show(excp.Message + Environment.NewLine + excp.InnerException, "Excepció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //consultarCursos(((Department)cbDepartaments.SelectedItem).Name);
                this.Cursor = Cursors.Default;
                consultaMatricules();
            }
            else if(dgMatricules.SelectedRows[0].Cells[4] != null)
            {
                //Posar un missatge mes detallat
                MessageBox.Show("Titu ,has de borrar una persona que no tingui una nota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (dgMatricules.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccionar una fila no marranot?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgMatricules_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 quinafila = 0;
            FrmAMBMatricules frm;

            if (dgMatricules.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cal seleccionar una fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                quinafila = dgMatricules.SelectedRows[0].Index;
                frm = new FrmAMBMatricules();
                //frm.frmPare = this;
                frm.Text = "Modificar un Estudiant";
                frm.operacio = 'M';
                frm.idMatricula = (int)dgMatricules.SelectedRows[0].Cells[5].Value;
                //Aqui li haurem de passar la id de la persona per saber

                frm.ShowDialog();
                if (frm.hanfetOK)
                {
                    consultaMatricules();
                }
                frm = null;
                GC.Collect();
            }
        }
    }
}
