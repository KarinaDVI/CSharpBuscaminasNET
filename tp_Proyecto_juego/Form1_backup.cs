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
        int banderas;
        int filas, columnas;
        //Flag de perder
        bool lose;
        //Flag de finalizacion
        bool fin;
        bool deshabilitada = false;
        private String[,] tablero;
        private String[,] tableroImg;
        private int[,] tableroNum;
        private String[,] tableroImgNum;
        public Form2 info = new Form2();

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
        Image incognita = Properties.Resources.incognita;

        //Sonidos


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            try
            {
                //Primero vacia las columnas de datos y las variables claves
                dataGridView1.Columns.Clear();
                minasPuestas = 0;
                minasEncontradas = 0;
                cantMinas = 0;
                filas = 0;
                columnas = 0;
                //Marca si pisó mina
                lose = false;
                fin = false;
                //Deshabilita la grid luego de ganar o perder
                deshabilitada = false;

                //Inicia el datagrid
                dataGridView1.Visible = true;

                filas = int.Parse(nroFilas.Text);
                columnas = int.Parse(nroColumnas.Text);
                cantMinas = int.Parse(nroMinas.Text);
  
                banderas = cantMinas;
                flagText.Text = cantMinas.ToString();

                int cantCeldas = filas * columnas;

                //Construccion del array de tablero de datos
                tablero = new String[filas, columnas];
                //Construccion del array de tablero de datos de imagenes para boton derecho
                tableroImg = new String[filas, columnas];
                //Construccion de array de datos para celda incognita;
                tableroNum = new int[filas, columnas];
                //Construccion de array de datos ded nombre de imagenes para incognita
                tableroImgNum = new String[filas, columnas];

                //Contruccion de tablero gráfico

                //Defino tamaño del tablero
                dataGridView1.Height = 40 * filas + 10 * filas;
                dataGridView1.Width = 40 * columnas + 10 * columnas;
               // Size.Height += 100;

                for (int i = 0; i < columnas; i++)
                {
                //Crea columnas con botones verdes
                    createGraphicsColumn(i);
                }

                //Crea filas del datagrid de imagenes
                for (int j = 0; j < filas; j++)
                {
                    dataGridView1.Rows.Add();
                }

                /*Asignar nombres de imagenes en tablero de imagenes de botón izquierdo y
                de imagenes para incógnita*/
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        tableroImg[i, j] = "btnGreen";
                        tableroImgNum[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                //Inicia el tablero a 0
                vaciarTablero(tableroNum,filas, columnas);

                //Defino tamaño del cuadro de info
                flowTablero.Height = TableroBox.Height;
                if (dataGridView1.Width < (controlBox.Width + btnIniciar.Width + TableroBox.Width + 50))
                {
                    flowTablero.Width = (controlBox.Width + btnIniciar.Width + TableroBox.Width + 50);
                }
                else
                {
                    flowTablero.Width = dataGridView1.Width;
                }

                //Elimina la seleccion de la celda 0,0 que viene por default(Por motivos estéticos)
                dataGridView1.Rows[0].Cells[0].Selected = false;

                //Declaro un objeto random para calcular las filas y columnas donde irán las minas
                Random rnd = new Random();

                //Carga de matriz de datos auxiliar
                while (minasPuestas < cantMinas)
                {
                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            //Asignacion de numeros randoms para poner minas
                            int celdax = rnd.Next(0, filas);
                            int celday = rnd.Next(0, columnas);

                            //Coloca minas en la matriz auxiliar o e para espacios vacios.
                            if (i == celdax && j == celday && tablero[i, j] != "*")
                            {
                                minasPuestas++;
                                tablero[i, j] = "*";
                            }
                            if (tablero[i, j] != "*")
                            {
                                tablero[i, j] = "e";
                            }
                        }
                    }
                }
                //Calcula la cantidad de minas alrededor de una celda y coloca la cantidad 
                calcularNumeros(filas, columnas);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ingresa filas , columnas y cantidad de minas","Dato erróneo");
                
            }
        }

        //Función de vacair matriz
        private void vaciarTablero(int[,] matriz, int filas, int columnas)
        { 
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = 0;
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Reproduciria un sonido si andara...
            //SonidoAmbiente();

            //Toma filas y columnas de los textViews
            int filImg = dataGridView1.CurrentRow.Index;
            int colImg = dataGridView1.CurrentCell.ColumnIndex;

            //Referencio la celda de las grid con otras variables
            DataGridViewCell cellImg = dataGridView1.Rows[filImg].Cells[colImg];

            //Comprueba que no se haya ganado o perdido y habilita la ejecución
            if (deshabilitada == false)
            {

                //BOTON IZQUIERDO

                if (e.Button == MouseButtons.Left)
                {
                    //Verifica que en la celda de datos no haya * (bomba) o sea una bomba marcada (flagb)
                    if (tableroNum[filImg,colImg] != 1)
                    {
                        if (tablero[filImg, colImg] == "*")

                        {
                            //condicion perdedora cumplida
                            lose = true;

                            //Hace que todas las celdas con minas "salten" y se muestren
                            MostrarMinas(filImg, colImg, filas, columnas);

                            //Pone imagen de bomba en celda clickada
                            cellImg.Value = boom;

                            //Reproduce un sonido al ganar o perder
                            playSoundFromResource(sender, e);
                            MessageBox.Show("Perdiste! tal vez la próxima..","Boom!",MessageBoxButtons.OK,MessageBoxIcon.Stop);

                            /*bDeshabilita la
                            interaccion de usuario con la grilla */
                            deshabilitada = true;
                        }
                        else
                        {
                            //Chequea que la celda NO tenga un número
                            //Si no hay bomba marca la casilla con v de descubierto y
                            //se asigna imagen de checkeado vacio 

                            if (tablero[filImg, colImg].ToString().All(char.IsDigit) == false)
                            {
                                cellImg.Value = ok;
                                //Chequea que la celda no esté con imagen de incógnita
                                if (tableroNum[filImg, colImg] == 2)
                                {
                                    banderas++;
                                }
                                tablero[filImg, colImg] = "v";
                                tableroImg[filImg, colImg] = "ok";
                            }
                            else
                            {
                                //Si HAY numero y hay bandera de peligro se deja 
                                //Sino se marca celda ok y se dibuja el numero
                                if (tableroImg[filImg, colImg] == "danger")
                                {
                                    tableroImg[filImg, colImg] = "danger";
                                }
                                else
                                {

                                    tableroImg[filImg, colImg] = "ok";
                                    dibujarNumero(filImg, colImg);
                                }

                            }
                            //Despeja un claro alrededor de la mina vacia
                            int n =1;
                            hacerClaros(filImg,colImg,filas, columnas,n);

                        }
                    }
                }

                //BOTON DERECHO

                //Si el botón clickeado es el derecho y no se sale dde la tabla
                if (e.Button == MouseButtons.Right && (filas >= 0 && columnas >= 0))
                {
                    //Evalua que si la casilla no esté clickeada y está vacia
                    if (tableroImg[e.RowIndex, e.ColumnIndex]!="ok")
                    {
                        DataGridViewCell cellImge = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        /*Se suma al valor correspondiente de celda de la 
                         matriz de numero de clicks +1 */
                        tableroNum[e.RowIndex, e.ColumnIndex]++;

                        String line = tablero[e.RowIndex, e.ColumnIndex];

                        //Evaluar que hacer cuando se clickea el botón derecho
                        evaluarBotonDerecho(e.RowIndex, e.ColumnIndex);

                        //Muestra banderas puestas
                        flagText.Text = banderas.ToString();
                    }
                    
                    
                }

                //Evaluar si gana:
                //Si se encontraron todaas las minas puestas y no se pis+object ninguna
                if ((minasEncontradas == minasPuestas) && lose == false)
                {
                    //Comprueba que no queden casilleros vacios y devuelve true si no hay
                    fin = ComprobarMinas(filas, columnas);
                    MostrarMinas(filImg, colImg, filas, columnas);
                }
                /*Si hay condicion ganadora muestra mensaje y deshabilita
                la iteraccion del usuario con la grilla*/

                if ((fin == true) && (lose == false))
                {
                    MessageBox.Show("Ganaste!!", "Todas las minas Encontradas!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    playSoundFromResource(sender, e);
                    deshabilitada = true;
                }
            }
        }
        //Función de evaluar que pasa cuando se clickea el botón derecho un numero n de veces
        private void evaluarBotonDerecho(int i, int j)
        {
            DataGridViewCell cellImge = dataGridView1.Rows[i].Cells[j];
            String line = tablero[i, j];

            //Si la celda se clickeo dos veces
            switch (tableroNum[i, j])
            {
                case 2:

                    //cambiar a celda con incognita y suma a banderas +1 

                    cellImge.Value = incognita;

                    tableroImgNum[i, j] = "incognita";
                    //Marca tablero para botón izquierdo
                    tableroImg[i, j] = "btnGreen";
                    banderas++;

                    //Si era una bomba descubierta la devuelve a sin descubrir
                    //y descuenta de minas encontradas 1

                    if (tablero[i, j] == "flagb")
                    {
                        tablero[i, j] = "*";
                        minasEncontradas--;
                    }

                    //Si era un falso positivo lo vuelve a vacio 
                    if ((tablero[i, j] == "flage"))
                    {
                        tablero[i, j] = "e";
                    }
                    break;

                //Si se cickeo una vez el botón derecho
                case 1:

                    //Resta a banderas -1
                    banderas--;

                    //Pone la imagen de peligro
                    tableroImg[i, j] = "danger";
                    cellImge.Value = danger;

                    /*Si la celda esta vacia sin descubrir o descubierta vacia le pone
                    la bandera de falso positivo*/
                    if ((tablero[i, j] == "e" || line == "v"))
                    {

                        tablero[i, j] = "flage";
                    }
                    //Si hay bomba se marca como bomba descubierta
                    if (line == "*")
                    {
                        tablero[i, j] = "flagb";
                        minasEncontradas++;

                    }
                    break;

                //Si se clickeo con botón derecho sobre la  celda 3 veces
                case 3:

                    //cambiar a botón no descubierto
                    cellImge.Value = btnGreen;
                    tableroImg[i, j] = "btnGreen";

                    //Si era una bomba descubierta la devuelve a sin descubrir
                    if (tablero[i, j] == "flagb")
                    {
                        tablero[i, j] = "*";
                        //minasEncontradas--;
                    }

                    //Si era un falso positivo lo vuelve a vacio 
                    if ((tablero[i, j] == "flage"))
                    {
                        tablero[i, j] = "e";
                    }

                    //Vuelve la cantidad de veces clickeadas de la celda a 0
                    tableroNum[i, j] = 0;
                    break;
            }

           
        }
        //Dibuja el numero de minas que hay alrededor de la celda.
        private void dibujarNumero(int filImg, int colImg)
        {
            DataGridViewCell cellImg = dataGridView1.Rows[filImg].Cells[colImg];

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
        //Comprueba que no haya celdas sin descubrir y que todas las minas hayan sido marcadas
        private bool ComprobarMinas(int nfilas, int ncols)
        {
            int count = 0;
            for (int i = 0; i < nfilas; i++)
            {
                for (int j = 0; j < ncols; j++)
                {
                    String val = tablero[i, j];
                    String valImg = tableroImg[i, j];

                    //Comprueba que no haya:
                    //columnas marcadas erroneas como vacias(flage)
                    //o que no queden espacios vacios sin descubrir (e) o btnGreen
                    //o minas sin marcar(*)
                    //o botones sin descubrir que sean numeros (char.IsDigit)

                    if (val == "flage" || val == "e" || val == "*" || valImg == "btnGreen" || (valImg == "danger" && val.ToString().All(char.IsDigit)))
                    {
                        count++;
                    }
                }
            }
            //Devuelve true si hay alguno
            return (count == 0);
        }
        //Muestra las minas sin descubrir
        private void MostrarMinas(int fil, int col, int nfilas, int ncols)
        {

            for (int i = 0; i < nfilas; i++)
            {
                for (int j = 0; j < ncols; j++)
                {
                    DataGridViewCell cellImg = dataGridView1.Rows[i].Cells[j];
                    
                    /*Si perdió o hay minas sin descubrir
                    evalua que imagen poner */
                    if (lose == true || fin == true)
                    {
                        if (tablero[i, j] == "*")
                        {
                            cellImg.Value = bomb;
                        }

                        if (tablero[i, j] == "flagb")
                        {
                            cellImg.Value = bombPercha;
                        }

                        if (tablero[i, j] == "flage" || (tablero[i, j].All(char.IsDigit) && tableroImg[i, j] == "danger"))
                        {
                            cellImg.Value = X;
                        }

                        if (tablero[i, j] == "e" || tableroImg[i, j] == "btnGreen")
                        {
                            cellImg.Value = btnGreen;
                        }
                        
                        if (tablero[i, j] == "v" || tableroImg[i, j] == "ok")
                        {
                            cellImg.Value = ok;
                        }

                        if (tablero[i, j].All(char.IsDigit) && tableroImg[i, j] == "ok")
                        {
                            dibujarNumero(i, j);
                        }

                        if (tablero[i, j] == "*" && tableroImg[i, j] == "btnGreen")
                        {
                            cellImg.Value = bomb;
                        }
                    }
                    else
                    {

                    }
                }
            }
        }
        //Calcular cuantas minas hay alrededor de una celda.
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
                                if(tablero[i + arrayPosx[k],j + arrayPosy[k]] == "*")
                                {
                                    cont++;
                                    //Coloco el nro de minas que hay alrededor
                                    tablero[i,j]=cont.ToString();
                                    tableroImg[i,j]="btnGreen";
                                    
                                }
                            }
                        }
                    }
                }
            }
        }

        //Hacer claros cuando clickea una casilla vacia
        //Revisar que solo los hace en diagonal

        private void hacerClaros(int f, int c, int filas, int columnas, int n)
        {
            //Celdas alrededor
            //Hasta que celda contigua tenga numero sumar o restar un numero a la posicion
            //si celda anterior tiene numero buscar en la anterior
            //Si celda siguiente tiene numero buscar en la que sigue sumar a la posicion
            //"Blanquear"
            //Si tiene numero parar

            int filIn;
            int colIn;
            int filFin;
            int colFin;

            //Ver que pasa sin un while
            //Si las celdas evaluadas están dentro de la grilla y no se salen o en la celda hay digito.
            if ((f >= 0 && c >= 0) && (f < filas && c < columnas))
            {

                if (f - n <= 0 || tablero[f - n, c].All(char.IsDigit))
                {
                    filIn = f;
                }
                else
                {
                    filIn = f - n;
                }

                if (c - n <= 0 || tablero[f, c - n].All(char.IsDigit))
                {
                    colIn = c;
                }
                else
                {
                    colIn = c - n;
                }

                if (f + n >= filas - 1 || tablero[f + n, c].All(char.IsDigit))
                {
                    filFin = f;
                }
                else
                {
                    filFin = f + n;
                }

                if (c + n >= columnas - 1 || tablero[f, c + n].All(char.IsDigit))
                {
                    colFin = c;
                }
                else
                {
                    colFin = c + n;
                }


                for (int i = filIn; i <= filFin; i++)
                {
                    for (int j = colIn; j <= colFin; j++)
                    {
                        if ((tablero[i, j] == "e" || tablero[i, j] == "v") && tableroImgNum[i,j]!="incognita")
                        {
                            dataGridView1.Rows[i].Cells[j].Value = ok;
                            tablero[i, j] = "v";
                            tableroImg[i, j] = "ok";
                            //Llamo a la misma función ejecuta lo mismo en las filas de alrededor.
                            hacerClaros(i, j, f, c, n++);
                        }
                        if (tablero[i, j].All(char.IsDigit) && tableroImgNum[i, j] != "incognita")
                        {
                            dibujarNumero(i, j);
                            tableroImg[i, j] = "ok";
                        }
                    }
                }
            }
        }
        


        //Crea las celdas con botones verdes.
        private void createGraphicsColumn(int columnindex)
        {
            //Crea las columnas con imagenes de botones al iniciar el tablero


            DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
            iconColumn.Image = btnGreen;

            dataGridView1.Columns.Insert(columnindex, iconColumn);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            iconColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        //Reproduce sonido al ganar o perder
        private void playSoundFromResource(object sender, EventArgs e)
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream s = a.GetManifestResourceStream("<AssemblyName>.chimes.wav");
            SoundPlayer player = new SoundPlayer(s);
            player.Play();
        }

        public void SonidoAmbiente()
        {

            //sonidoEntradaCarga = new SoundPlayer("Resources\\Sonidos\\ambient.wav");
            //sonidoEntradaCarga.PlayLooping();
            SoundPlayer soundPlayer = new SoundPlayer();
           soundPlayer.Stream = Properties.Resources._148694__metwo99__beep;
           // soundPlayer.SoundLocation = "..sounds\\";
            soundPlayer.Play();
        }

        //Cambia de color la celda al entrar
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                me.Text = tablero[e.RowIndex, e.ColumnIndex].ToString();
                fc.Text = e.RowIndex.ToString() + ", " + e.ColumnIndex.ToString();
                vDi.Text = tablero[e.RowIndex, e.ColumnIndex].ToString() + ", " + tableroImg[e.RowIndex, e.ColumnIndex].ToString();
                // dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Coral;
                // dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.White;
            }
            catch (Exception)
            {

                MessageBox.Show("Faltó ingresar nro de minas", "Faltan datos");
            }

        }
        //Devuelve la celda a su color original
        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                //Devuelve a su color origina la celda al salir

                //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                // dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.White;
            }
            catch (Exception)
            {

                MessageBox.Show("Faltó ingresar nro de minas", "Faltan datos");
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void TableroBox_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Para abrir el cuadro de referencia de iconos de celdas
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 help = new Form2();

            //this.Hide();
            help.ShowDialog();
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



