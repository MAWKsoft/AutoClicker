namespace AutoClicker
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCoordX = new System.Windows.Forms.Label();
            this.labelCoordY = new System.Windows.Forms.Label();
            this.timerCoord = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CoordX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoordY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SleepTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonDodajClick = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timerProgram = new System.Windows.Forms.Timer(this.components);
            this.buttonStopProgram = new System.Windows.Forms.Button();
            this.textBoxRepeat = new System.Windows.Forms.TextBox();
            this.listBoxTEST = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCoordX
            // 
            this.labelCoordX.AutoSize = true;
            this.labelCoordX.Location = new System.Drawing.Point(6, 16);
            this.labelCoordX.Name = "labelCoordX";
            this.labelCoordX.Size = new System.Drawing.Size(64, 13);
            this.labelCoordX.TabIndex = 0;
            this.labelCoordX.Text = "labelCoordX";
            // 
            // labelCoordY
            // 
            this.labelCoordY.AutoSize = true;
            this.labelCoordY.Location = new System.Drawing.Point(6, 29);
            this.labelCoordY.Name = "labelCoordY";
            this.labelCoordY.Size = new System.Drawing.Size(64, 13);
            this.labelCoordY.TabIndex = 1;
            this.labelCoordY.Text = "labelCoordY";
            // 
            // timerCoord
            // 
            this.timerCoord.Enabled = true;
            this.timerCoord.Tick += new System.EventHandler(this.TimerCoord_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(3, 114);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(157, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Uruchom program [F1]";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoordX,
            this.CoordY,
            this.Event,
            this.SleepTime,
            this.Key,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(166, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(583, 164);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // CoordX
            // 
            this.CoordX.HeaderText = "Pozycja X";
            this.CoordX.Name = "CoordX";
            this.CoordX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CoordX.Width = 70;
            // 
            // CoordY
            // 
            this.CoordY.HeaderText = "Pozycja Y";
            this.CoordY.Name = "CoordY";
            this.CoordY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CoordY.Width = 70;
            // 
            // Event
            // 
            this.Event.HeaderText = "Wydarzenie";
            this.Event.Items.AddRange(new object[] {
            "Prawy przycisk myszki",
            "Lewy przycisk myszki",
            "Środkowy przycisk myszki",
            "Dowolny klawisz",
            "Ciąg znaków"});
            this.Event.Name = "Event";
            this.Event.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Event.Width = 150;
            // 
            // SleepTime
            // 
            this.SleepTime.HeaderText = "Czas [ms]";
            this.SleepTime.Name = "SleepTime";
            this.SleepTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SleepTime.Width = 70;
            // 
            // Key
            // 
            this.Key.HeaderText = "Klawisz / Ciąg znaków";
            this.Key.Name = "Key";
            this.Key.Width = 150;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Usuń";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Text = "X";
            this.Delete.Width = 50;
            // 
            // buttonDodajClick
            // 
            this.buttonDodajClick.Location = new System.Drawing.Point(3, 85);
            this.buttonDodajClick.Name = "buttonDodajClick";
            this.buttonDodajClick.Size = new System.Drawing.Size(157, 23);
            this.buttonDodajClick.TabIndex = 5;
            this.buttonDodajClick.Text = "Dodaj wydarzenie [F5]";
            this.buttonDodajClick.UseVisualStyleBackColor = true;
            this.buttonDodajClick.Click += new System.EventHandler(this.ButtonAddEvent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCoordX);
            this.groupBox1.Controls.Add(this.labelCoordY);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 53);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pozycja myszki:";
            // 
            // buttonStopProgram
            // 
            this.buttonStopProgram.Location = new System.Drawing.Point(3, 143);
            this.buttonStopProgram.Name = "buttonStopProgram";
            this.buttonStopProgram.Size = new System.Drawing.Size(157, 23);
            this.buttonStopProgram.TabIndex = 9;
            this.buttonStopProgram.Text = "Zatrzymaj program [F2]";
            this.buttonStopProgram.UseVisualStyleBackColor = true;
            this.buttonStopProgram.Click += new System.EventHandler(this.ButtonStopProgram_Click);
            // 
            // textBoxRepeat
            // 
            this.textBoxRepeat.Location = new System.Drawing.Point(102, 61);
            this.textBoxRepeat.Name = "textBoxRepeat";
            this.textBoxRepeat.Size = new System.Drawing.Size(58, 20);
            this.textBoxRepeat.TabIndex = 10;
            this.textBoxRepeat.Text = "1";
            this.textBoxRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBoxTEST
            // 
            this.listBoxTEST.FormattingEnabled = true;
            this.listBoxTEST.Location = new System.Drawing.Point(3, 187);
            this.listBoxTEST.Name = "listBoxTEST";
            this.listBoxTEST.Size = new System.Drawing.Size(216, 264);
            this.listBoxTEST.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ilość powtórzeń: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 174);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTEST);
            this.Controls.Add(this.textBoxRepeat);
            this.Controls.Add(this.buttonStopProgram);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDodajClick);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonStart);
            this.Name = "MainForm";
            this.Text = "Archimede AutoClicker MK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCoordX;
        private System.Windows.Forms.Label labelCoordY;
        private System.Windows.Forms.Timer timerCoord;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodajClick;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoordX;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoordY;
        private System.Windows.Forms.DataGridViewComboBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn SleepTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button buttonStopProgram;
        private System.Windows.Forms.TextBox textBoxRepeat;
        private System.Windows.Forms.ListBox listBoxTEST;
        private System.Windows.Forms.Label label1;
    }
}

