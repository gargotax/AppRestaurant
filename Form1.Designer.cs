namespace MioProgetto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_chiudi = new System.Windows.Forms.Button();
            this.btn_calcola = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sceltaMenu = new System.Windows.Forms.ComboBox();
            this.ct_turistico = new System.Windows.Forms.NumericUpDown();
            this.ct_lavoratore = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_turistico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_lavoratore)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_chiudi
            // 
            this.btn_chiudi.Location = new System.Drawing.Point(760, 445);
            this.btn_chiudi.Name = "btn_chiudi";
            this.btn_chiudi.Size = new System.Drawing.Size(94, 29);
            this.btn_chiudi.TabIndex = 0;
            this.btn_chiudi.Text = "chiudi";
            this.btn_chiudi.UseVisualStyleBackColor = true;
            this.btn_chiudi.Click += new System.EventHandler(this.btn_chiudi_Click);
            // 
            // btn_calcola
            // 
            this.btn_calcola.Location = new System.Drawing.Point(571, 445);
            this.btn_calcola.Name = "btn_calcola";
            this.btn_calcola.Size = new System.Drawing.Size(94, 29);
            this.btn_calcola.TabIndex = 1;
            this.btn_calcola.Text = "calcola";
            this.btn_calcola.UseVisualStyleBackColor = true;
            this.btn_calcola.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.totale});
            this.dataGridView1.Location = new System.Drawing.Point(551, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(324, 222);
            this.dataGridView1.TabIndex = 2;
            // 
            // data
            // 
            this.data.HeaderText = "data";
            this.data.MinimumWidth = 6;
            this.data.Name = "data";
            this.data.Width = 125;
            // 
            // totale
            // 
            this.totale.HeaderText = "totale";
            this.totale.MinimumWidth = 6;
            this.totale.Name = "totale";
            this.totale.Width = 125;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Primi (a scelta): ",
            "Trofie al pesto",
            "Minestrone alla ligure ",
            "Lasagne al ragù",
            "",
            "Secondi (a scelta):",
            "Trippa in umido",
            "Coniglio alla ligure",
            "Buridda",
            "",
            "caffè"});
            this.listBox1.Location = new System.Drawing.Point(12, 192);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 224);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "Antipasti misti",
            "",
            "Primi (a scelta): ",
            "Trofie al pesto",
            "Minestrone alla ligure ",
            "Lasagne al ragù",
            "",
            "Secondi (a scelta):",
            "Trippa in umido",
            "Coniglio alla ligure",
            "Buridda",
            "",
            "Dolci:",
            "Gelato",
            "Tiramisù",
            "",
            "Caffè",
            "\t",
            "\t"});
            this.listBox2.Location = new System.Drawing.Point(211, 192);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(150, 224);
            this.listBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "menu lavoratori (7e)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(220, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "menu turistico (10e)";
            // 
            // sceltaMenu
            // 
            this.sceltaMenu.FormattingEnabled = true;
            this.sceltaMenu.Items.AddRange(new object[] {
            "menu lavoratori",
            "menu turistico"});
            this.sceltaMenu.Location = new System.Drawing.Point(115, 99);
            this.sceltaMenu.Name = "sceltaMenu";
            this.sceltaMenu.Size = new System.Drawing.Size(151, 28);
            this.sceltaMenu.TabIndex = 7;
            // 
            // ct_turistico
            // 
            this.ct_turistico.Location = new System.Drawing.Point(211, 445);
            this.ct_turistico.Name = "ct_turistico";
            this.ct_turistico.Size = new System.Drawing.Size(150, 27);
            this.ct_turistico.TabIndex = 8;
            // 
            // ct_lavoratore
            // 
            this.ct_lavoratore.Location = new System.Drawing.Point(12, 445);
            this.ct_lavoratore.Name = "ct_lavoratore";
            this.ct_lavoratore.Size = new System.Drawing.Size(150, 27);
            this.ct_lavoratore.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 514);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(319, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 40);
            this.label3.TabIndex = 11;
            this.label3.Text = "Buon Appetito!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "test db";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MioProgetto.Properties.Resources.platter_g692b6c3fd_1920;
            this.ClientSize = new System.Drawing.Size(903, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ct_lavoratore);
            this.Controls.Add(this.ct_turistico);
            this.Controls.Add(this.sceltaMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_calcola);
            this.Controls.Add(this.btn_chiudi);
            this.Name = "Form1";
            this.Text = "MyRestaurant";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_turistico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_lavoratore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_chiudi;
        private Button btn_calcola;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn totale;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private ComboBox sceltaMenu;
        private NumericUpDown ct_turistico;
        private NumericUpDown ct_lavoratore;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
    }
}