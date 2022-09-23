using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAlvarezTPBiblioteca
{
    public partial class frmBiblioteca : Form
    {
        //declaracion de matriz
        string[,] MatrizDatos = new string[21,5];

        //variables de columnas y filas
        int varFila = 0;

        int contador = 0;

        public frmBiblioteca()
        {



            InitializeComponent();
            StreamReader SrArchivos = new StreamReader("./LIBRO.txt" ,true);//lee el archivo 
            char separador = Convert.ToChar(",");

            while (!SrArchivos.EndOfStream)
            {
                string[] arrArchivoDatos = SrArchivos.ReadLine().Split(separador);
               
                int editorial = Convert.ToInt32(arrArchivoDatos[2]);
                string editIndicador = "";

                switch (editorial)//segun sea
                {//compara var editorial y cuando sea igual 
                    case 1: editIndicador = "Prentice Hall"; break;//break para que no busque el siguiente
                    case 2: editIndicador = "Cuspide"; break;
                    case 3: editIndicador = "Rama"; break;
                    case 4: editIndicador = "Mc Graw Hill"; break;
                    case 5: editIndicador = "Anay Multimedia"; break;
                    case 6: editIndicador = "Peuser"; break;
                    case 7: editIndicador = "Colombo"; break;
                }//case 1 = (if editorial = 1)

                int distribuidor = Convert.ToInt32(arrArchivoDatos[4]);
                string distribIndicador = "";

                switch (distribuidor)//segun sea
                {
                    case 1: distribIndicador = "Los alarces"; break;
                    case 2: distribIndicador = "Mayocor Libros"; break;
                    case 3: distribIndicador = "La buena lectura"; break;
                    case 4: distribIndicador = "Sam Walter"; break;
                    case 5: distribIndicador = "Infinito"; break;
                    case 6: distribIndicador = "Delta al Cuadrado"; break;
                    case 7: distribIndicador = "Rapilent"; break;
                }

                MatrizDatos[varFila, 0] = arrArchivoDatos[0];//codigo
                MatrizDatos[varFila, 1] = arrArchivoDatos[1];//nombre
                MatrizDatos[varFila, 2] = editIndicador;   //editorial
                MatrizDatos[varFila, 3] = arrArchivoDatos[3];//autor
                MatrizDatos[varFila, 4] = distribIndicador;//distribuidor
                varFila++;
            }

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dgvBliblioteca.Rows.Clear();
            btnConsultarTodos.Enabled = true;
            btnAtras.Enabled = true;
            btnSiguientes.Enabled = true;
            contador = 0;

        }

        private void btnSiguientes_Click(object sender, EventArgs e)
        {
            

            if (contador < 21)
            {
                dgvBliblioteca.Rows.Add(
                    MatrizDatos[contador, 0],
                    MatrizDatos[contador, 1],
                    MatrizDatos[contador, 2],
                    MatrizDatos[contador, 3],
                    MatrizDatos[contador, 4]);

                contador++;
                
            }
            else
            {
                MessageBox.Show("NO HAY MAS REGISTROS");
                btnConsultarTodos.Enabled = false;
            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (contador > 0)
            {
                dgvBliblioteca.Rows.RemoveAt(contador - 1);
                contador--;
                
            }
            else
            {
                btnConsultarTodos.Enabled = true;
               
            }
        }

        private void frmBiblioteca_Load(object sender, EventArgs e)
        {
           
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int i = 0;
            dgvBliblioteca.Rows.Clear();

            while ( i < 21 )//muestra todos los datos
            {
                dgvBliblioteca.Rows.Add(
                    MatrizDatos[i, 0],
                    MatrizDatos[i, 1],
                    MatrizDatos[i, 2],
                    MatrizDatos[i, 3],
                    MatrizDatos[i, 4]

                    );
                i++;
            }
            
            btnConsultarTodos.Enabled = false;
            btnSiguientes.Enabled = false;
            btnAtras.Enabled = false;
        }
    }
}
