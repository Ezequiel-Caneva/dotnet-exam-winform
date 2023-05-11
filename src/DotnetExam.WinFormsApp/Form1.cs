using DotnetExam.Entities;
using System.Data;

namespace DotnetExam.WinFormsApp
{
    public partial class Form1 : Form
    {
        private List<Materia> materias = new List<Materia>();
        private List<Alumno> alumnos = new List<Alumno>();
        int n = 0;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            iniciador();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Listado de alumnos ";


        }

        private void iniciador()
        {
            MateriaGenerador generador = new MateriaGenerador();
            materias = generador.Generar(20, 30);

            dgvMaterias.AutoGenerateColumns = false;
            dgvMaterias.DataSource = materias;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscador.Text))
            {
                var busqueda = txtBuscador.Text;
                if (txtBuscador.Text != string.Empty)
                {
                    
                    List<Materia> lista = (from a in materias
                                           where a.Nombre.ToLower().StartsWith(busqueda.ToLower())
                                           select a).ToList();
                    dgvMaterias.DataSource = lista;   
                    txtBuscador.Text = "";
                }
            }

            else
            {
                MessageBox.Show("Complete el campo con un nombre de materia valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvMaterias.DataSource = materias;
                
            }



            }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var alumnos = (from a in materias
                           where a.Nombre == dgvMaterias.SelectedCells[0].Value.ToString()
                           select a.Alumnos);


            dt = new DataTable();
            dt.Columns.Add("Nombre Completo");
            dt.Columns.Add("Nota");
            
            foreach (var lista in alumnos)
            {
                foreach (var alumno in lista)
                {
                    DataRow row = dt.NewRow();
                    row["Nombre Completo"] = $"{alumno.NombreCompleto}";
                    row["Nota"] = alumno.Nota;
                    dt.Rows.Add(row);
                }
            }
            dgvAlumnos.DataSource = dt;
            

        }

        private void dgvMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                var mostrar = dgvMaterias.Rows[n].Cells[1].Value.ToString();
                lblAlumnos.Text = $"Alumnos de la materia: {mostrar}";
            }
        }
        private void dgvAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            {
                if (this.dgvAlumnos.Columns[e.ColumnIndex].Name == "Nota")
                {
                    if (e.Value != null)
                    {
                        if (e.Value.GetType() != typeof(System.DBNull))
                        {

                            if (Convert.ToInt32(e.Value) < 6)
                            {
                                e.CellStyle.BackColor = Color.Red;
                                e.CellStyle.ForeColor = Color.Black;
                            }
                        }
                    }
                }

            }
        }
    }
}