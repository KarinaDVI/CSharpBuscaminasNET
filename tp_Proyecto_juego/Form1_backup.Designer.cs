namespace tp_Proyecto_juego
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TableroBox = new System.Windows.Forms.GroupBox();
            this.nroMinas = new System.Windows.Forms.NumericUpDown();
            this.nroFilas = new System.Windows.Forms.NumericUpDown();
            this.nroColumnas = new System.Windows.Forms.NumericUpDown();
            this.controlBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flagText = new System.Windows.Forms.TextBox();
            this.flag = new System.Windows.Forms.Label();
            this.fc = new System.Windows.Forms.TextBox();
            this.vDi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.me = new System.Windows.Forms.TextBox();
            this.panelTablero = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowTablero = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.TableroBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nroMinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nroFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nroColumnas)).BeginInit();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowTablero.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "me-mp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "f, c";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(14, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nro columnas";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(14, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nro filas";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(15, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Minas";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TableroBox
            // 
            this.TableroBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TableroBox.AutoSize = true;
            this.TableroBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableroBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.TableroBox.Controls.Add(this.nroMinas);
            this.TableroBox.Controls.Add(this.nroFilas);
            this.TableroBox.Controls.Add(this.nroColumnas);
            this.TableroBox.Controls.Add(this.label4);
            this.TableroBox.Controls.Add(this.label3);
            this.TableroBox.Controls.Add(this.label5);
            this.TableroBox.Location = new System.Drawing.Point(3, 3);
            this.TableroBox.Name = "TableroBox";
            this.TableroBox.Padding = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.TableroBox.Size = new System.Drawing.Size(177, 108);
            this.TableroBox.TabIndex = 25;
            this.TableroBox.TabStop = false;
            this.TableroBox.Text = "Tablero";
            this.TableroBox.Enter += new System.EventHandler(this.TableroBox_Enter);
            // 
            // nroMinas
            // 
            this.nroMinas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nroMinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nroMinas.ForeColor = System.Drawing.Color.Red;
            this.nroMinas.Location = new System.Drawing.Point(71, 66);
            this.nroMinas.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nroMinas.Name = "nroMinas";
            this.nroMinas.Size = new System.Drawing.Size(37, 23);
            this.nroMinas.TabIndex = 11;
            this.nroMinas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nroFilas
            // 
            this.nroFilas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nroFilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nroFilas.ForeColor = System.Drawing.Color.Red;
            this.nroFilas.Location = new System.Drawing.Point(88, 18);
            this.nroFilas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nroFilas.Name = "nroFilas";
            this.nroFilas.Size = new System.Drawing.Size(37, 23);
            this.nroFilas.TabIndex = 10;
            this.nroFilas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nroColumnas
            // 
            this.nroColumnas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nroColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nroColumnas.ForeColor = System.Drawing.Color.Red;
            this.nroColumnas.Location = new System.Drawing.Point(127, 43);
            this.nroColumnas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nroColumnas.Name = "nroColumnas";
            this.nroColumnas.Size = new System.Drawing.Size(37, 23);
            this.nroColumnas.TabIndex = 9;
            this.nroColumnas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // controlBox
            // 
            this.controlBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.controlBox.AutoSize = true;
            this.controlBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controlBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.controlBox.Controls.Add(this.button1);
            this.controlBox.Controls.Add(this.flagText);
            this.controlBox.Controls.Add(this.flag);
            this.controlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlBox.Location = new System.Drawing.Point(296, 4);
            this.controlBox.Name = "controlBox";
            this.controlBox.Padding = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.controlBox.Size = new System.Drawing.Size(101, 105);
            this.controlBox.TabIndex = 26;
            this.controlBox.TabStop = false;
            this.controlBox.Text = "Celda";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Help;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(19, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flagText
            // 
            this.flagText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flagText.ForeColor = System.Drawing.Color.Red;
            this.flagText.Location = new System.Drawing.Point(59, 33);
            this.flagText.Name = "flagText";
            this.flagText.Size = new System.Drawing.Size(29, 23);
            this.flagText.TabIndex = 10;
            // 
            // flag
            // 
            this.flag.AutoSize = true;
            this.flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flag.ForeColor = System.Drawing.Color.Red;
            this.flag.Location = new System.Drawing.Point(9, 34);
            this.flag.Name = "flag";
            this.flag.Size = new System.Drawing.Size(47, 17);
            this.flag.TabIndex = 9;
            this.flag.Text = "Flags";
            // 
            // fc
            // 
            this.fc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fc.Location = new System.Drawing.Point(6, 148);
            this.fc.Name = "fc";
            this.fc.Size = new System.Drawing.Size(29, 23);
            this.fc.TabIndex = 6;
            // 
            // vDi
            // 
            this.vDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vDi.Location = new System.Drawing.Point(6, 97);
            this.vDi.Name = "vDi";
            this.vDi.Size = new System.Drawing.Size(34, 23);
            this.vDi.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "v";
            // 
            // me
            // 
            this.me.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.me.Location = new System.Drawing.Point(6, 55);
            this.me.Name = "me";
            this.me.Size = new System.Drawing.Size(34, 23);
            this.me.TabIndex = 5;
            // 
            // panelTablero
            // 
            this.panelTablero.AutoSize = true;
            this.panelTablero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTablero.Location = new System.Drawing.Point(84, 51);
            this.panelTablero.Name = "panelTablero";
            this.panelTablero.Size = new System.Drawing.Size(0, 0);
            this.panelTablero.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(58, 151);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(50);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 32;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(316, 231);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // flowTablero
            // 
            this.flowTablero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowTablero.AutoSize = true;
            this.flowTablero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowTablero.Controls.Add(this.TableroBox);
            this.flowTablero.Controls.Add(this.btnIniciar);
            this.flowTablero.Controls.Add(this.controlBox);
            this.flowTablero.Location = new System.Drawing.Point(10, 10);
            this.flowTablero.Name = "flowTablero";
            this.flowTablero.Size = new System.Drawing.Size(400, 114);
            this.flowTablero.TabIndex = 30;
            this.flowTablero.WrapContents = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnIniciar.AutoSize = true;
            this.btnIniciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.BackgroundImage = global::tp_Proyecto_juego.Properties.Resources.btn;
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIniciar.CausesValidation = false;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderSize = 5;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Red;
            this.btnIniciar.Location = new System.Drawing.Point(186, 7);
            this.btnIniciar.MinimumSize = new System.Drawing.Size(100, 100);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(104, 100);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "IniciarJuego";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.label1);
            this.gbControl.Controls.Add(this.me);
            this.gbControl.Controls.Add(this.vDi);
            this.gbControl.Controls.Add(this.fc);
            this.gbControl.Controls.Add(this.label6);
            this.gbControl.Controls.Add(this.label2);
            this.gbControl.Location = new System.Drawing.Point(10, 151);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(46, 177);
            this.gbControl.TabIndex = 27;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            this.gbControl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(431, 408);
            this.Controls.Add(this.flowTablero);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.panelTablero);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.MinimumSize = new System.Drawing.Size(447, 447);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscabombas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TableroBox.ResumeLayout(false);
            this.TableroBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nroMinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nroFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nroColumnas)).EndInit();
            this.controlBox.ResumeLayout(false);
            this.controlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowTablero.ResumeLayout(false);
            this.flowTablero.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox TableroBox;
        private System.Windows.Forms.GroupBox controlBox;
        private System.Windows.Forms.Panel panelTablero;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowTablero;
        private System.Windows.Forms.TextBox fc;
        private System.Windows.Forms.NumericUpDown nroColumnas;
        private System.Windows.Forms.NumericUpDown nroFilas;
        private System.Windows.Forms.NumericUpDown nroMinas;
        private System.Windows.Forms.TextBox flagText;
        private System.Windows.Forms.Label flag;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.GroupBox gbControl;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox vDi;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox me;
    }
}

