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
            this.nroFilas = new System.Windows.Forms.MaskedTextBox();
            this.nroColumnas = new System.Windows.Forms.MaskedTextBox();
            this.nroMinas = new System.Windows.Forms.MaskedTextBox();
            this.TableroBox = new System.Windows.Forms.GroupBox();
            this.controlBox = new System.Windows.Forms.GroupBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.panelTablero = new System.Windows.Forms.Panel();
            this.filCol = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowTablero = new System.Windows.Forms.FlowLayoutPanel();
            this.me = new System.Windows.Forms.TextBox();
            this.fc = new System.Windows.Forms.TextBox();
            this.TableroBox.SuspendLayout();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowTablero.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "me-mp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "f-c";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(32, 42);
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
            this.label4.Location = new System.Drawing.Point(32, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nro filas:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(33, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Minas";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nroFilas
            // 
            this.nroFilas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nroFilas.BackColor = System.Drawing.Color.White;
            this.nroFilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nroFilas.ForeColor = System.Drawing.Color.Crimson;
            this.nroFilas.Location = new System.Drawing.Point(112, 21);
            this.nroFilas.Name = "nroFilas";
            this.nroFilas.Size = new System.Drawing.Size(27, 23);
            this.nroFilas.TabIndex = 1;
            this.nroFilas.Text = "2";
            this.nroFilas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nroFilas.ValidatingType = typeof(int);
            this.nroFilas.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.nroFilas_MaskInputRejected);
            // 
            // nroColumnas
            // 
            this.nroColumnas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nroColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nroColumnas.ForeColor = System.Drawing.Color.Crimson;
            this.nroColumnas.Location = new System.Drawing.Point(141, 42);
            this.nroColumnas.Name = "nroColumnas";
            this.nroColumnas.Size = new System.Drawing.Size(27, 23);
            this.nroColumnas.TabIndex = 2;
            this.nroColumnas.Text = "2";
            this.nroColumnas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nroColumnas.ValidatingType = typeof(int);
            // 
            // nroMinas
            // 
            this.nroMinas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nroMinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nroMinas.ForeColor = System.Drawing.Color.Crimson;
            this.nroMinas.Location = new System.Drawing.Point(83, 60);
            this.nroMinas.Name = "nroMinas";
            this.nroMinas.Size = new System.Drawing.Size(26, 23);
            this.nroMinas.TabIndex = 3;
            this.nroMinas.Text = "1";
            this.nroMinas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nroMinas.ValidatingType = typeof(int);
            this.nroMinas.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.nroMinas_MaskInputRejected);
            // 
            // TableroBox
            // 
            this.TableroBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableroBox.AutoSize = true;
            this.TableroBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableroBox.BackColor = System.Drawing.Color.LightSalmon;
            this.TableroBox.Controls.Add(this.label4);
            this.TableroBox.Controls.Add(this.nroMinas);
            this.TableroBox.Controls.Add(this.label3);
            this.TableroBox.Controls.Add(this.nroColumnas);
            this.TableroBox.Controls.Add(this.nroFilas);
            this.TableroBox.Controls.Add(this.label5);
            this.TableroBox.Location = new System.Drawing.Point(3, 3);
            this.TableroBox.Name = "TableroBox";
            this.TableroBox.Size = new System.Drawing.Size(174, 102);
            this.TableroBox.TabIndex = 25;
            this.TableroBox.TabStop = false;
            this.TableroBox.Text = "Tablero";
            this.TableroBox.Enter += new System.EventHandler(this.TableroBox_Enter);
            // 
            // controlBox
            // 
            this.controlBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.controlBox.AutoSize = true;
            this.controlBox.BackColor = System.Drawing.Color.Cyan;
            this.controlBox.Controls.Add(this.fc);
            this.controlBox.Controls.Add(this.me);
            this.controlBox.Controls.Add(this.label1);
            this.controlBox.Controls.Add(this.label2);
            this.controlBox.Location = new System.Drawing.Point(302, 12);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(72, 84);
            this.controlBox.TabIndex = 26;
            this.controlBox.TabStop = false;
            this.controlBox.Text = "Control";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnIniciar.AutoSize = true;
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.BackgroundImage = global::tp_Proyecto_juego.Properties.Resources.btn;
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIniciar.CausesValidation = false;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderSize = 5;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Crimson;
            this.btnIniciar.Location = new System.Drawing.Point(183, 8);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(113, 92);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "IniciarJuego";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
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
            // filCol
            // 
            this.filCol.AllowUserToResizeColumns = false;
            this.filCol.AllowUserToResizeRows = false;
            this.filCol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.filCol.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.filCol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filCol.Location = new System.Drawing.Point(243, 207);
            this.filCol.Name = "filCol";
            this.filCol.ShowCellErrors = false;
            this.filCol.ShowRowErrors = false;
            this.filCol.Size = new System.Drawing.Size(182, 226);
            this.filCol.TabIndex = 20;
            this.filCol.Visible = false;
            this.filCol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filCol_CellContentClick);
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
            this.dataGridView1.Location = new System.Drawing.Point(27, 129);
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
            this.dataGridView1.Size = new System.Drawing.Size(528, 400);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // flowTablero
            // 
            this.flowTablero.AutoSize = true;
            this.flowTablero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowTablero.Controls.Add(this.TableroBox);
            this.flowTablero.Controls.Add(this.btnIniciar);
            this.flowTablero.Controls.Add(this.controlBox);
            this.flowTablero.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowTablero.Location = new System.Drawing.Point(10, 10);
            this.flowTablero.Name = "flowTablero";
            this.flowTablero.Size = new System.Drawing.Size(564, 108);
            this.flowTablero.TabIndex = 30;
            this.flowTablero.WrapContents = false;
            // 
            // me
            // 
            this.me.Location = new System.Drawing.Point(40, 22);
            this.me.Name = "me";
            this.me.Size = new System.Drawing.Size(26, 20);
            this.me.TabIndex = 5;
            // 
            // fc
            // 
            this.fc.Location = new System.Drawing.Point(31, 45);
            this.fc.Name = "fc";
            this.fc.Size = new System.Drawing.Size(26, 20);
            this.fc.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.flowTablero);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelTablero);
            this.Controls.Add(this.filCol);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscaminas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TableroBox.ResumeLayout(false);
            this.TableroBox.PerformLayout();
            this.controlBox.ResumeLayout(false);
            this.controlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowTablero.ResumeLayout(false);
            this.flowTablero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox nroFilas;
        private System.Windows.Forms.MaskedTextBox nroColumnas;
        private System.Windows.Forms.MaskedTextBox nroMinas;
        private System.Windows.Forms.GroupBox TableroBox;
        private System.Windows.Forms.GroupBox controlBox;
        private System.Windows.Forms.Panel panelTablero;
        private System.Windows.Forms.DataGridView filCol;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowTablero;
        private System.Windows.Forms.TextBox me;
        private System.Windows.Forms.TextBox fc;
    }
}

