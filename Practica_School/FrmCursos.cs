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
    public partial class FrmCursos : Form
    {
        public FrmCursos()
        {
            InitializeComponent();
        }

        private SchoolEntities schoolContext = new SchoolEntities();

        private void FrmCursos_Load(object sender, EventArgs e)
        {
            consultacursos();
            iniGrid();
        }

        private void iniGrid()
        {
            dgCursos.Columns[0].HeaderText = "Nom Departament";
            dgCursos.Columns[1].HeaderText = "Nom Curs";
        }

        private void consultacursos()
        {
            var qryMatricules = (from Curs in schoolContext.Course
                                 orderby Curs.Department.Name, Curs.Credits
                                 select new
                                 {
                                     nomDepartament = Curs.Title,
                                     nomCurs = Curs.Title,
                                     Credits = Curs.Credits,
                                 });


            dgCursos.DataSource = qryMatricules.ToList().Distinct().ToList();
        }
    }
}
