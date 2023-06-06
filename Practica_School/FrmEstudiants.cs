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
    public partial class FrmEstudiants : Form
    {

        private SchoolEntities schoolContext = new SchoolEntities();

        public Course curs;
        

        public FrmEstudiants()
        {
            InitializeComponent();
        }

        private void FrmEstudiants_Load(object sender, EventArgs e)
        {
            consultaEstudiants();
        }

        private void consultaEstudiants()
        {
            var qryEstudiants = (from Estudiants in schoolContext.Person
                                 where Estudiants.HireDate == null
                                 orderby Estudiants.LastName
                                 select new
                                 {
                                     nom = Estudiants.FirstName,
                                     cognoms = Estudiants.LastName,
                                     dataMatriculacio = Estudiants.EnrollmentDate,
                                 });

            dgEstudiants.DataSource = qryEstudiants.ToList().Distinct().ToList();
        }

        private void btNou_Click(object sender, EventArgs e)
        {
            FrmAMBPersones frm = new FrmAMBPersones();

            //frm.frmPare = this;
            frm.Text = "Alta d'un nou estudiant";
            frm.operacio = 'A';
            frm.persona = 'E'; 
            //ctrlCicles.idCicle = "";
            //ctrlCicles.nomCicle = "";
            //ctrlCicles.idFamilia = "";

            //Aqui declararem una array, que agafara el valor del que retornara
            //ctrlCicles.idsFamilies = retornaridFamilies();

            //Aqui hem de fer una funcio que ens retorni tots els noms de les families per saber quins podem posar i quins no

            frm.ShowDialog();
            if (frm.hanfetOK)
            {
                //MessageBox.Show("S'ha afegit el cicle " + ctrlCicles.idCicle + "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                consultaEstudiants();

                // apliquem LINQ per a trobar al DataGridView la fila on és la familia que s'acaba d'inserir
                //var quinaFila = from DataGridViewRow fila in dgCicles.Rows
                //                where fila.Cells["idCicle"].Value.ToString().Trim() == ctrlCicles.idCicle
                //                select fila.Index;

                //dgCicles.Rows[quinaFila.First()].Selected = true;
                //MessageBox.Show("S'ha afegit el cicle: " + ctrlCicles.idCicle + " amb el nom: " + ctrlCicles.nomCicle, "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frm = null;
            GC.Collect();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int idPersona = -1;
            Person Alumne;

            if (dgEstudiants.SelectedRows.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;
                idPersona = Convert.ToInt32(dgEstudiants.SelectedRows[0].Cells[0].Value);   // agafem la clau primària
                Alumne = schoolContext.Person.Find(idPersona);                           // busquem a la taula de cursos per clau primària
                schoolContext.Person.Remove(Alumne);                                  // eliminem 

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
                consultaEstudiants();
            }
            else{
                MessageBox.Show("Cal seleccionar algun curs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgEstudiants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 quinafila = 0;
            FrmAMBPersones frm;

            if (dgEstudiants.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cal seleccionar una fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                quinafila = dgEstudiants.SelectedRows[0].Index;
                frm = new FrmAMBPersones();
                //frm.frmPare = this;
                frm.Text = "Modificar un Estudiant";
                frm.operacio = 'M';
                frm.persona = 'E';
                frm.idPersona = (int)dgEstudiants.SelectedRows[0].Cells["id"].Value;
                //Aqui li haurem de passar la id de la persona per saber

                frm.ShowDialog();
                if (frm.hanfetOK)
                {
                    consultaEstudiants();
                }
                frm = null;
                GC.Collect();
            }
        }
    }
}
