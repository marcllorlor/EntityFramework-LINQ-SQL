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
    public partial class FrmMain : Form
    {

        public FrmEstudiants frmEstu = null;
        public FrmMatricules frmMatri = null;
        public FrmExpedients frmExpe = null;
        public FrmCursos frmCurs = null;
        public FrmNotes frmNot = null;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void estudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ja_està_obert("FrmEstudiants"))
            {
                //Recorda que sempre per obrir un nou formulari hem de tenir el mdi parent activat
                frmEstu = new FrmEstudiants(); //En el cas que sigui importar posarem la connSQL i el tipus de dades que volem importar
                frmEstu.MdiParent = this;           // --- hem fet que FRM_MAIN sigui MdiContainer i posem aquest Form com a fill seu ---

                frmEstu.WindowState = FormWindowState.Normal;
                frmEstu.Location = new System.Drawing.Point(0, 0);
                frmEstu.Show();
            }
        }

        private void matrículesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ja_està_obert("FrmMatricules"))
            {
                //Recorda que sempre per obrir un nou formulari hem de tenir el mdi parent activat
                frmMatri = new FrmMatricules(); //En el cas que sigui importar posarem la connSQL i el tipus de dades que volem importar
                frmMatri.MdiParent = this;           // --- hem fet que FRM_MAIN sigui MdiContainer i posem aquest Form com a fill seu ---

                frmMatri.WindowState = FormWindowState.Normal;
                frmMatri.Location = new System.Drawing.Point(0, 0);
                frmMatri.Show();
            }
        }

        private void notesPerCursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ja_està_obert("FrmNotes"))
            {
                //Recorda que sempre per obrir un nou formulari hem de tenir el mdi parent activat
                frmNot = new FrmNotes(); //En el cas que sigui importar posarem la connSQL i el tipus de dades que volem importar
                frmNot.MdiParent = this;           // --- hem fet que FRM_MAIN sigui MdiContainer i posem aquest Form com a fill seu ---

                frmNot.WindowState = FormWindowState.Normal;
                frmNot.Location = new System.Drawing.Point(0, 0);
                frmNot.Show();
            }
        }

        private void expedientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ja_està_obert("FrmExpedients"))
            {
                //Recorda que sempre per obrir un nou formulari hem de tenir el mdi parent activat
                frmExpe = new FrmExpedients(); //En el cas que sigui importar posarem la connSQL i el tipus de dades que volem importar
                //frmMatri.MdiParent = this;           // --- hem fet que FRM_MAIN sigui MdiContainer i posem aquest Form com a fill seu ---

                frmExpe.WindowState = FormWindowState.Normal;
                frmExpe.Location = new System.Drawing.Point(0, 0);
                frmExpe.Show();
            }
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ja_està_obert("FrmCursos"))
            {
                //Recorda que sempre per obrir un nou formulari hem de tenir el mdi parent activat
                frmCurs = new FrmCursos(); //En el cas que sigui importar posarem la connSQL i el tipus de dades que volem importar
                frmCurs.MdiParent = this;           // --- hem fet que FRM_MAIN sigui MdiContainer i posem aquest Form com a fill seu ---

                frmCurs.WindowState = FormWindowState.Normal;
                frmCurs.Location = new System.Drawing.Point(0, 0);
                frmCurs.Show();
            }
        }

        Boolean ja_està_obert(String xnom_frm)
        {
            //Aquesta es la funcio que farem servir per saber si una pagina ja esta oberta actualment o no
            int x1 = 0;
            Boolean xb = false;

            while ((x1 < this.MdiChildren.Length) && (!(xb)))
            {
                xb = (this.MdiChildren[x1].Name == xnom_frm);
                x1++;
            }
            return (xb); //Aqui retornara el valor TRUE si esta oberta i FALSE si la pagina no esta oberta
        }


    }
}
