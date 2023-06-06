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
    public partial class FrmAMBPersones : Form
    {

        private SchoolEntities schoolContext = new SchoolEntities();
        Person person = new Person();

        public char operacio = ' ';
        public char persona = ' ';
        public Boolean hanfetOK = false;

        public int idPersona = 0;

        public FrmAMBPersones()
        {
            InitializeComponent();
        }

        private void FrmAMBPersones_Load(object sender, EventArgs e)
        {
            if (operacio == 'M')
            {
                //Aqui haurem d'agafar les dades de Persona
                agafardadespersones();
                //tbId.Text = frmPare.ctrlModuls.idModul;
                //tbNom.Text = frmPare.ctrlModuls.nomModul;
            }   
        }

        private void agafardadespersones()
        {
            person = schoolContext.Person.Find(idPersona);
            tbNom.Text = person.FirstName;
            tbCognom.Text = person.LastName;
            if(persona == 'E')
            {
                dtpData.Value = (DateTime)person.EnrollmentDate;
            }
            else
            {
                dtpData.Value = (DateTime)person.HireDate;
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            //Primer hem dagafar les dades 
            switch (persona)
            {
                case 'E':
                    hanfetOK = gestioAlumne();
                    break;
                case 'P':
                    hanfetOK = gestioProfessor();
                    break;
                default: break;
            }
            
            if (hanfetOK)
            {
                this.Close();
            }
        }

        private bool gestioProfessor()
        {
            Boolean hanfetOK = false;
            switch (operacio)
            {
                case 'A':
                    hanfetOK = nouProfessor();
                    break;
                case 'M':
                    hanfetOK = modificarProfessor();
                    break;
                default: break;
            }

            return hanfetOK;
        }

        private bool modificarProfessor()
        {
            return true;
        }

        private bool nouProfessor()
        {
            this.Cursor = Cursors.WaitCursor;

            Boolean hanfetOK = false;

            if ((tbNom.Text.Trim() == "") || (tbCognom.Text.Trim() == "") || (dtpData.Text.Trim() == ""))
            {
                MessageBox.Show("Has d'omplir totes les dades", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // tractem la taula de cursos com una classe d'objecte
                person.LastName = tbCognom.Text.Trim();
                person.FirstName = tbNom.Text.Trim();
                person.HireDate = dtpData.Value;
                person.EnrollmentDate = null;

                schoolContext.Person.Add(person);     // la inserció esdevé una crida a Add

                try
                {
                    schoolContext.SaveChanges();
                    hanfetOK = true;// la inserció no es fa efectiva fins que fem el SaveChanges
                }
                catch (Exception excp)
                {
                    MessageBox.Show(excp.Message + Environment.NewLine + excp.InnerException, "Excepció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    schoolContext.Person.Remove(person);     // eliminem la instància que ha provocat l'error per a que no quedi a la cua
                }
            }
            this.Cursor = Cursors.Default;

            return hanfetOK;
        }

        private bool gestioAlumne()
        {
            Boolean hanfetOK = false;
            switch (operacio)
            {
                case 'A':
                    hanfetOK = nouAlumne();
                    break;
                case 'M':
                    hanfetOK = modificarAlumne();
                    break;
                default: break;
            }

            return hanfetOK;
        }

        private bool modificarAlumne()
        {

            Boolean xb = false;

            this.Cursor = Cursors.WaitCursor;

            if ((tbNom.Text.Trim() == "") || (tbCognom.Text.Trim() == "") || (dtpData.Value == null))
            {
                MessageBox.Show("Has d'omplir totes les dades", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                person = schoolContext.Person.Find(idPersona);

                person.FirstName = tbNom.Text.Trim();
                person.LastName = tbCognom.Text.Trim();
                person.EnrollmentDate = dtpData.Value;

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

        private bool nouAlumne()
        {
            this.Cursor = Cursors.WaitCursor;

            Boolean hanfetOK = false;

            if ((tbNom.Text.Trim() == "") || (tbCognom.Text.Trim() == "") || (dtpData.Text.Trim() == ""))
            {
                MessageBox.Show("Has d'omplir totes les dades", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Aqui haurem de fer una consulta per saber si la persona existeix
                if (!existeixpersona(tbNom.Text.Trim(), tbCognom.Text.Trim()))
                {
                    person.LastName = tbCognom.Text.Trim();
                    person.FirstName = tbNom.Text.Trim();
                    person.HireDate = null;
                    person.EnrollmentDate = dtpData.Value;

                    schoolContext.Person.Add(person);     // la inserció esdevé una crida a Add

                    try
                    {
                        schoolContext.SaveChanges();
                        hanfetOK = true;// la inserció no es fa efectiva fins que fem el SaveChanges
                    }
                    catch (Exception excp)
                    {
                        MessageBox.Show(excp.Message + Environment.NewLine + excp.InnerException, "Excepció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        schoolContext.Person.Remove(person);     // eliminem la instància que ha provocat l'error per a que no quedi a la cua
                    }
                }

                // tractem la taula de cursos com una classe d'objecte
                
            }
            this.Cursor = Cursors.Default;

            return hanfetOK;
        }

        private bool existeixpersona(string nompersona, string cognompersona)
        {
            Boolean qryEstudiants = (from Estudiants in schoolContext.Person
                                 where Estudiants.FirstName == nompersona && Estudiants.LastName == cognompersona
                                 orderby Estudiants.LastName
                                 select Estudiants).ToList().Count() > 0;

            return qryEstudiants;
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
