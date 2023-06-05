using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

/*Ideas para mejorar: Hacer que haya una mina que sea que al encontrarla gane el juego o 
    en vez de ser mina sea una caja sorpresa*/

//Cosas para hacer
/*Hacer que muestre un numero con la suma en
    las celdas adyacentes si en la celda hay mina---Parcialmente hecho
    Ver el tema del despeje de las celdas, termina en una celda y despeja en 
    diagonal a partir de alli Ver un patrón de roseta.
 */

/*Se podria hacer que los botones cambien de color 
 * aleatoriamente y genere un sonido aleatorio al cambiar de color?
 */

namespace tp_Proyecto_juego
{


    public partial class Form1 : Form
    {
        int cantMinas;
        int minasPuestas;
        int minasEncontradas;
        //Flag de perder
        bool lose;
        //Flag de finalizacion
        bool fin;
        bool deshabilitada = false;
        private String[,] tablero;
        private String[,] tableroImg;

        List<int> filasList = new List<int>();
        List<int> columnasList = new List<int>();
        List<bool> flagfilList = new List<bool>();
        List<bool> flagcolList = new List<bool>();

        //Imagenes
        Image danger = Properties.Resources.danger;
        Image boom = Properties.Resources.boom;
        Image ok = Properties.Resources.ok;
        Image bomb = Properties.Resources.bomb;
        Image bombPercha = Properties.Resources.bombPercha;
        Image X = Properties.Resources.x;
        Image btnRed = Properties.Resources.btnRed;
        Image btnGreen = Properties.Resources.btn;
        Image uno = Properties.Resources._1;
        Image dos = Properties.Resources._2;
        Image tres = Properties.Resources._3;
        Image cuatro = Properties.Resources._4;
        Image cinco = Properties.Resources._5;
        Image seis = Properties.Resources._6;
        Image siete = Properties.Resources._7;
        Image ocho = Properties.Resources._8;


        public Form1()
        {
            InitializeComponent();
            int filas;
            int columnas;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            filCol.Columns.Clear();
            dataGridView1.Columns.Clear();


            minasPuestas = 0;
            minasEncontradas = 0;
            cantMinas = 0;
            lose = false;
            fin = false;
            deshabilitada = false;

            //Inicia el datagrid
            dataGridView1.Visible = true;

            //tabla de datos
            int filas = 2;
            int columnas = 2;


            filas = int.Parse(nroFilas.Text);
            columnas = int.Parse(nroColumnas.Text);
            cantMinas = int.Parse(nroMinas.Text);


            //Declaro filas y columnas random
            if (cantMinas > filas * columnas)
            {
                cantMinas = (filas * columnas) - 1;
            }

            if (cantMinas == 0)
                cantMinas = 1;

            int cantCeldas = filas * columnas;
            int rFila;
            int rColumna;


            //Construccion del array de tablero
            tablero = new String[filas,columnas];
            tableroImg= new String[filas,columnas];

            //Contruccion de tablero gráfico

            for (int i = 0; i < columnas; i++)
            {
                //Defino tamaño del tablero
                dataGridView1.Height = 40 * filas + 10*filas; //- (1 / 3) * 60 * filas;
                dataGridView1.Width = 40 * columnas + 10*columnas;// - (1 / 3) * 60 * columnas;
                //dataGridView1.Height=Form.ActiveForm.Height;
                //dataGridView1.Width=Form.ActiveForm.Width;
                //Defino tamaño del cuadro de info
                flowTablero.Width = dataGridView1.Width;
                flowTablero.Height = TableroBox.Height;
                //Crea columnas con botones verdes
                createGraphicsColumn(i);

                //Crea columnas de la tabla auxiliar de datos
                filCol.Columns.Add("", "");

            }
            //Crea filas de la tabla auxiliar de datos
            for (int j = 0; j < filas; j++)
            {
                dataGridView1.Rows.Add();
                filCol.Rows.Add();
            }

            //Elimina la seleccion de la celda 0,0 que viene por default
            dataGridView1.Rows[0].Cells[0].Selected = false;
            //Declaro un objeto random
            Random rnd = new Random();

            //Carga de tabla de datos auxiliar
            while (minasPuestas < cantMinas)
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        //Asignacion de numeros randoms para poner minas
                        int celdax = rnd.Next(0, filas);
                        int celday = rnd.Next(0, columnas);

                        //Muestro valores de * para bombas, e para vacias 
                        //if (i == celdax && j == celday && filCol.Rows[i].Cells[j].Value != "*")
                        if (i == celdax && j == celday && tablero[i,j]!="*")
                        {
                            minasPuestas++;
                            //filCol.Rows[i].Cells[j].Value = "*";
                            tablero[i, j] = "*";

                        }
                        //if (filCol.Rows[i].Cells[j].Value != "*")
                        if (tablero[i, j] != "*")
                        {
                            //filCol.Rows[i].Cells[j].Value = "e";
                            tablero[i, j] = "e";
                        }

                    }
                }

            }
            //Calcula la cantidad de minas alrededor de una celda y coloca la cantidad 
            calcularNumeros(filas, columnas);
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Toma filas y columnas de los textViews

            int filas = int.Parse(nroFilas.Text);
            int columnas = int.Parse(nroColumnas.Text);

            //selecciona la celda que clickea
            int filImg = dataGridView1.CurrentRow.Index;
            // DataGridViewImageCell imageCell = new DataGridViewImageCell();

            int colImg = dataGridView1.CurrentCell.ColumnIndex;

            //Referencio la celda de las grid con otras variables
            //DataGridViewCell cellData = filCol.Rows[filImg].Cells[colImg];
            DataGridViewCell cellImg = dataGridView1.Rows[filImg].Cells[colImg];

            //Comprueba que no se haya ganado o perdido y habilita la ejecucución
            if (deshabilitada == false)
            {

                if (e.Button == MouseButtons.Left)
                {
                    //Verifica que en la celda de datos no haya * (bomba) o sea una bomba marcada (flagb)
                    //if (cellData.Value == "*" || cellData.Value == "flagb")
                    if (tablero[filImg,colImg]=="*"|| tablero[filImg, colImg] == "flagb")
                    
                    {
                        //condicion perdedora cumplida
                        lose = true;

                        //Hace que todas las celdas con minas "salten" y se muestren
                        MostrarMinas(filImg, colImg, filas, columnas);

                        //Pone imagen de bomba en celda clickada
                        cellImg.Value = boom;

                        //Reproduce un sonido al ganar o perder
                        playSoundFromResource(sender, e);
                        MessageBox.Show("Perdiste!");

                        /*Marca la condición de deshabilitar la
                        interaccion de usuario con la grilla*/
                        deshabilitada = true;
                    }
                    else
                    {
                        //Si no hay bomba marca la casilla con v y asigna imagen de checkeado vacio
                        //dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[dataGridView1.CurrentCell.ColumnIndex].Value = ok;

                        //Chequea que la celda no tenga un número
                        //if (cellData.Value.ToString().All(char.IsDigit) == false)
                        if(tablero[filImg,colImg].ToString().All(char.IsDigit) == false)
                        
                        {
                            cellImg.Value = ok;
                            //cellData.Value = "v";
                            tablero[filImg, colImg] = "v";
                        }
                        else
                        {
                            //funcion de asignar la imagen a numeros segun cantidad de minas cercanas
                            //Esta función 
                            dibujarNumero(filImg, colImg);
                        }

                        hacerClaros(filImg, colImg, filas, columnas);
                        //calcularNumeros(filas,columnas);

                    }
                }
                //Si el botón clickeado es el derecho pone cartel de peligro
                if (e.Button == MouseButtons.Right && (filas >= 0 && columnas >= 0))
                {
                    DataGridViewCell cellImge = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //DataGridViewCell cellDatae = filCol.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = danger;
                    cellImge.Value = danger;
                    //object line = filCol.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    String line = tablero[e.RowIndex,e.ColumnIndex];

                    if (line == "*")
                    {
                        //cellDatae.Value = "flagb";
                        tablero[e.RowIndex, e.ColumnIndex] = "flagb";
                        minasEncontradas++;
                        me.Text = minasEncontradas.ToString() + "," + minasPuestas.ToString();
                        fc.Text = e.RowIndex.ToString() + "," + e.ColumnIndex.ToString();
                        ;
                    }

                    if (line == "e" || line == "v")
                    {
                        //cellDatae.Value = "flage";
                        tablero[e.RowIndex, e.ColumnIndex] = "flage";
                    }

                    if (line == "flagb")
                    {
                        //cellDatae.Value = "flagb";
                        tablero[e.RowIndex, e.ColumnIndex] = "flagb";
                        //Para control!!--Quitar
                       
                    }

                    if (line == "flage")
                    {
                        //cellDatae.Value = "flage";
                        tablero[e.RowIndex, e.ColumnIndex] = "flage";
                    }
                    if (line.ToString().All(char.IsDigit))
                    {
                        //cellDatae.Value = line;
                        tablero[e.RowIndex, e.ColumnIndex] = line;
                    }


                }
                //}
                //Revisar porqué No me está dando ganador al reiniciar el juego

                if ((minasEncontradas == minasPuestas) && lose == false)
                {
                    //Comprueba que no queden casilleros vacios y devuelve true si no hay
                    fin = ComprobarMinas(filas, columnas);
                    MostrarMinas(filImg, colImg, filas, columnas);
                }

                if ((fin == true) && (lose == false))
                {
                    MessageBox.Show("Ganaste!!", "Todas las minas Encontradas!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    playSoundFromResource(sender, e);
                    deshabilitada = true;
                }
            }
        }


        private void dibujarNumero(int filImg, int colImg)
        {
            //DataGridViewCell cellData = filCol.Rows[filImg].Cells[colImg];

            DataGridViewCell cellImg = dataGridView1.Rows[filImg].Cells[colImg];
            //switch (cellData.Value.ToString())
            switch (tablero[filImg,colImg])
            {

                case "1":
                    cellImg.Value = uno;
                    break;
                case "2":
                    cellImg.Value = dos;
                    break;
                case "3":
                    cellImg.Value = tres;
                    break;
                case "4":
                    cellImg.Value = cuatro;
                    break;
                case "5":
                    cellImg.Value = cinco;
                    break;
                case "6":
                    cellImg.Value = seis;
                    break;
                case "7":
                    cellImg.Value = siete;
                    break;
                case "8":
                    cellImg.Value = ocho;
                    break;

            }
        }

        private bool ComprobarMinas(int nfilas, int ncols)
        {
            int count = 0;
            for (int i = 0; i < nfilas; i++)
            {
                for (int j = 0; j < ncols; j++)
                {
                    //DataGridViewCell cellData = filCol.Rows[i].Cells[j];
                    DataGridViewCell cellImg = dataGridView1.Rows[i].Cells[j];
                    //object val = cellData.Value;
                    String val = tablero[i, j];
                    object img = cellImg.Value;
                    //Comprueba que no haya:
                    //columnas marcadas erroneas como vacias(flage)
                    //o que no queden espacios vacios sin descubrir (e) o btnGreen
                    //o minas sin marcar(*)
                    //o botones sin descubrir que sean numeros (char.IsDigit)

                    if (val == "flage" || val == "e" || val == "*" || img == btnGreen || (img == danger && val.ToString().All(char.IsDigit)))
                    {
                        count++;
                    }
                }
            }
            //Devuelve true si hay alguno
            return (count == 0);
        }

        private void MostrarMinas(int fil, int col, int nfilas, int ncols)
        {

            for (int i = 0; i < nfilas; i++)
            {
                for (int j = 0; j < ncols; j++)
                {
                    DataGridViewCell cellImg = dataGridView1.Rows[i].Cells[j];
                    //DataGridViewCell cellData = filCol.Rows[i].Cells[j];
                    //Cambiar la expresion por data
                    if (lose == true || fin == true)
                    {
                        //if (cellData.Value == "*")
                        if (tablero[i, j] == "*")

                        {
                            cellImg.Value = bomb;
                        }
                        //if (cellData.Value == "flagb")
                        if (tablero[i, j] == "flagb")
                        {
                            cellImg.Value = bombPercha;
                        }

                        //if (cellData.Value == "flage" || (cellData.Value.ToString().All(char.IsDigit) && cellImg.Value == danger))
                        if (tablero[i, j] == "flage" || (tablero[i, j].All(char.IsDigit) && cellImg.Value == danger))
                        {

                            cellImg.Value = X;
                        }
                        //if (cellData.Value == "e")
                        if (tablero[i, j] == "e")
                        {
                            cellImg.Value = btnRed;
                        }
                        //if (cellData.Value == "v" || cellImg.Value == ok)
                        if (tablero[i, j] == "v" || cellImg.Value == ok)
                        {
                            cellImg.Value = ok;
                        }
                        //if (cellData.Value.ToString().All(char.IsDigit) && cellImg.Value == btnGreen)
                        if (tablero[i, j].All(char.IsDigit) && cellImg.Value == btnGreen)
                        {
                            dibujarNumero(i, j);
                        }
                    }
                    else
                    {

                    }
                }
            }
        }

        private void calcularNumeros(int fil, int col)
        {
            //En caso de ser clickeada una celda vacia chequear los alrededores
            //y si no hay mina se despeja automaticamente el resto y si hay 
            //mina agrega un numero sumando si hay mas de una 

            //Posiciones alrededor de la mina
            int[] arrayPosx = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int[] arrayPosy = { 1, 1, 1, 0, -1, -1, -1, 0 };

            for (int i = 0; i < fil; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //if (filCol.Rows[i].Cells[j].Value == "e")
                    if (tablero[i, j] == "e")
                    {
                        int cont = 0;
                        //Recorrido de la tabla de datos
                        for (int k = 0; k < arrayPosx.Length; k++)
                        {
                            //Evalua que las posiciones donde poner numeros no se salgan de la tabla
                            if ((i + arrayPosx[k] >= 0 && j + arrayPosy[k] >= 0) && (i + arrayPosx[k] < fil && j + arrayPosy[k] < col))
                            {
                                //Si hay minas
                                //if (filCol.Rows[i + arrayPosx[k]].Cells[j + arrayPosy[k]].Value == "*")
                                if(tablero[i + arrayPosx[k],j + arrayPosy[k]] == "*")
                                {
                                    cont++;
                                    //Coloco el nro de minas que hay alrededor
                                    //filCol.Rows[i].Cells[j].Value = cont.ToString();
                                    tablero[i,j]=cont.ToString();
                                }

                            }

                        }

                    }

                }
            }
        }
        private void hacerClaros(int f, int c, int filas, int columnas)
        {
            //Celdas alrededor
            //Hasta que celda contigua tenga numero sumar o restar un numero a la posicion
            //si celda anterior tiene numero buscar en la anterior
            //Si celda siguiente tiene numero buscar en la que sigue sumar a la posicion
            //"Blanquear"
            //Si tiene numero parar

            int[] arrayPosx = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int[] arrayPosy = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int filIn;
            int colIn;
            int filFin;
            int colFin;

            //Ver que pasa sin un while
            //while (filCol.Rows[f].Cells[c].Value.ToString().All(char.IsDigit) == false)
            //{
            if ((f >= 0 && c >= 0) && (f < filas && c < columnas))
            {
                if (f <= 0)
                {
                    filIn = 0;
                }
                else
                {
                    filIn = f - 1;
                }
                if (c <= 0)
                {
                    colIn = 0;
                }
                else
                {
                    colIn = c - 1;
                }
                if (f >= filas - 1)
                {
                    filFin = f;
                }
                else
                {
                    filFin = f + 1;
                }
                if (c >= columnas - 1)
                {
                    colFin = c;
                }
                else
                {
                    colFin = c + 1;
                }

                for (int i = filIn; i <= filFin; i++)
                {
                    for (int j = colIn; j <= colFin; j++)
                    {
                        //if (filCol.Rows[i].Cells[j].Value == "e" || filCol.Rows[i].Cells[j].Value == "v")
                        if (tablero[i, j] == "e" || tablero[i, j] == "v")
                        {
                            dataGridView1.Rows[i].Cells[j].Value = ok;
                            //filCol.Rows[i].Cells[j].Value = "v";
                            tablero[i, j] = "v";
                            //Llamo a la misma función ejecuta lo mismo en las filas de alrededor.
                            hacerClaros(i, j, f, c);
                        }

                    }
                }

            }

        }


        //private void On_mouse_click_secondary(object sender key)

        private void createGraphicsColumn(int columnindex)
        {
            //Crea las columnas con imagenes de botones al iniciar el tablero


            DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
            iconColumn.Image = btnGreen;

            dataGridView1.Columns.Insert(columnindex, iconColumn);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            iconColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        private void filCol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void playSoundFromResource(object sender, EventArgs e)
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream s = a.GetManifestResourceStream("<AssemblyName>.chimes.wav");
            SoundPlayer player = new SoundPlayer(s);
            player.Play();
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (deshabilitada == false)
            {
                //Sombrea de naranja la celda al entrar
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Coral;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.White;

            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            {
                //Devuelve a su color origina la celda al salir
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.White;
            }
        }


        private void nroFilas_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nroMinas_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TableroBox_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Tablero
    {

        private int fila { get; set; }
        private int columna { get; set; }
        public Tablero()
        {
            this.fila = 4;
            this.columna = 4;
        }

    }
    public class Juego
    {
        private int totalMinas { get; set; }
        private double tiempoTrancurrido { get; set; }
        private bool partida { get; set; }
        private int minasEncontradas { get; set; }
        private int minasColocadas { get; set; }
        private int minasSueltas { get; set; }

        public Juego()
        {
            totalMinas = 10;
        }

    }
    public class Celda
    {
        private int filax { get; set; }
        private int coly { get; set; }
        private bool tieneMina { get; set; }
        private bool incognita { get; set; }
        private bool hasFlag { get; set; }


        public Celda()
        {
            incognita = false;
            tieneMina = false;
            hasFlag = false;
        }

    }

    public class Mina
    {
        public int mina { get; set; }
        public int coordx { get; set; }
        public int coordy { get; set; }
        public Mina()
        {
            mina = 0;
            coordx = 0;
            coordy = 0;
        }
    }

}



