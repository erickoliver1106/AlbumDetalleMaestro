namespace AlbumDetalleMaestro.WinForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            grdSongs = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Minutos = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtReleaseDate = new DateTimePicker();
            txtAuthor = new TextBox();
            txtAlbumName = new TextBox();
            groupBox2 = new GroupBox();
            btnSongAdd = new Button();
            txtMinutes = new TextBox();
            txtSongName = new TextBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)grdSongs).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 34);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 82);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 36);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 84);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Minutos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(688, 34);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Lanzamiento";
            // 
            // grdSongs
            // 
            grdSongs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSongs.Columns.AddRange(new DataGridViewColumn[] { Nombre, Minutos });
            grdSongs.Location = new Point(56, 304);
            grdSongs.Name = "grdSongs";
            grdSongs.Size = new Size(1177, 304);
            grdSongs.TabIndex = 5;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Minutos
            // 
            Minutos.DataPropertyName = "Minutos";
            Minutos.HeaderText = "Minutos";
            Minutos.Name = "Minutos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtReleaseDate);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(txtAlbumName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(56, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1177, 126);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Album";
            // 
            // txtReleaseDate
            // 
            txtReleaseDate.Location = new Point(869, 28);
            txtReleaseDate.Name = "txtReleaseDate";
            txtReleaseDate.Size = new Size(200, 23);
            txtReleaseDate.TabIndex = 7;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(127, 74);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(230, 23);
            txtAuthor.TabIndex = 6;
            // 
            // txtAlbumName
            // 
            txtAlbumName.Location = new Point(127, 26);
            txtAlbumName.Name = "txtAlbumName";
            txtAlbumName.Size = new Size(230, 23);
            txtAlbumName.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSongAdd);
            groupBox2.Controls.Add(txtMinutes);
            groupBox2.Controls.Add(txtSongName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(56, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1177, 136);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cancion";
            // 
            // btnSongAdd
            // 
            btnSongAdd.Location = new Point(511, 47);
            btnSongAdd.Name = "btnSongAdd";
            btnSongAdd.Size = new Size(146, 36);
            btnSongAdd.TabIndex = 10;
            btnSongAdd.Text = "Añadir";
            btnSongAdd.UseVisualStyleBackColor = true;
            btnSongAdd.Click += btnSongAdd_Click_1;
            // 
            // txtMinutes
            // 
            txtMinutes.Location = new Point(127, 76);
            txtMinutes.Name = "txtMinutes";
            txtMinutes.Size = new Size(230, 23);
            txtMinutes.TabIndex = 9;
            // 
            // txtSongName
            // 
            txtSongName.Location = new Point(127, 28);
            txtSongName.Name = "txtSongName";
            txtSongName.Size = new Size(230, 23);
            txtSongName.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1061, 628);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(172, 41);
            btnSave.TabIndex = 11;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnSave);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grdSongs);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grdSongs).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView grdSongs;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker txtReleaseDate;
        private TextBox txtAuthor;
        private TextBox txtAlbumName;
        private Button btnSongAdd;
        private TextBox txtMinutes;
        private TextBox txtSongName;
        private Button btnSave;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Minutos;
    }
}
