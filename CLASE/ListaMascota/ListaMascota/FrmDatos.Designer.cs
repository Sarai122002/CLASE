
namespace ListaMascota
{
    partial class FrmDatos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.tsmMenu = new System.Windows.Forms.ToolStrip();
            this.tslRegistrar = new System.Windows.Forms.ToolStripLabel();
            this.tslConsultar = new System.Windows.Forms.ToolStripLabel();
            this.tslEliminar = new System.Windows.Forms.ToolStripLabel();
            this.tslSalir = new System.Windows.Forms.ToolStripLabel();
            this.tslAcercade = new System.Windows.Forms.ToolStripLabel();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tsmMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(482, 50);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 25);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(482, 246);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(180, 25);
            this.txtEdad.TabIndex = 5;
            // 
            // cmbRaza
            // 
            this.cmbRaza.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Items.AddRange(new object[] {
            "",
            "1. Border collie",
            "2. Caniche",
            "3. Pastor alemán",
            "4. Golden retriever",
            "5. Dóberman pinscher",
            "6. Perro ovejero de las Shetland",
            "7. Labrador",
            "8. Papillón",
            "9. Rottweiler",
            "10. Pastor ganadero australiano",
            "11. Corgi Galés de Pembroke",
            "12. Schnauzer mini",
            "13. Springer spaniel inglés",
            "14. Tervuren belga",
            "15. Schipperke",
            "15.bis. Pastor belga",
            "17. Collie",
            "17.bis. Keeshond",
            "19. Pointer alemán de pelo corto",
            "T20. Retriever de pelo liso",
            "20.bis.  Cocker spaniel inglés",
            "20.bis. Schnauzer",
            "23. Spaniel bretón",
            "24.bis. Cocker spaniel",
            "24.bis. Retriever de Nueva Escocia",
            "26. Braco de Weimar",
            "27. Pastor belga malinois",
            "27.bis. Bernés de la montaña",
            "29. Pomerano",
            "30. Perro de agua irlandés",
            "31. Vizsla",
            "32. Corgi galés",
            "33. Retriever de Chasepeake",
            "33.bis. Puli",
            "33.bis. Yorkshire terrier",
            "36.bis. Schnauzer gigante",
            "36.bis. Perro de aguas portugués",
            "36.bis. Airedale",
            "36.bis. Boyero de Flandes",
            "40. Border terrier",
            "40.bis. Pastor de Brie",
            "42. Springer spaniel galés",
            "43. Manchester terrier",
            "44. Samoyedo",
            "45. Field spaniel",
            "45.bis. Terranova",
            "45.bis. Terrier australiano",
            "45.bis. American Staffordshire terrier",
            "45.bis. Setter escocés",
            "45.bis. Collie barbudo",
            "51.bis. Perro esquimal americano",
            "51.bis. Cairn terrier",
            "51.bis. Kerry blue terrier",
            "51.bis. Setter irlandés",
            "55. Cazador de alces noruego",
            "56. Affenpinscher",
            "56.bis. Silky terrier",
            "56.bis. Pinscher miniatura",
            "56.bis. Setter inglés",
            "56.bis. Podenco faraónico",
            "56.bis. Clumber spaniel",
            "62. Terrier de Norwich",
            "63. Dálmata",
            "64. Soft coated wheaten terrier",
            "64.bis. Bedlington terrier",
            "T64.bis. Terrier de pelo duro",
            "67. Retriever de pelo rizado",
            "67.bis. Lobero irlandés",
            "69.bis. Kuvasz",
            "69.bis. Pastor australiano",
            "71.bis. Saluki",
            "71.bis. Spitz finlandés",
            "71.bis. Pointer",
            "74.bis. Cavalier King Charles spaniel",
            "74.bis. Pointer alemán de pelo corto",
            "74.bis. Perro negro y fuego para la caza del mapache",
            "74.bis. Perro de agua americano",
            "78.bis. Husky siberiano",
            "78.bis. Bichón Frisé",
            "78.bis. Toy spaniel inglés",
            "81. Spaniel tibetano",
            "81.bis. Foxhound inglés",
            "81.bis. Perro nutria",
            "81.bis. Perro nutria americano",
            "81.bis. Galgo",
            "81.bis. Harrier",
            "81.bis. Parson Russel terrier",
            "81.bis. Griffon de pelo duro",
            "89.bis. Terrier blanco West Highland",
            "89.bis. Bichón habanero",
            "89.bis. Lebrel escocés",
            "92. Bóxer",
            "92.bis. Gran danés",
            "94. Teckel",
            "94.bis. Staffordshire bull terrier",
            "94.bis. Shiba Inu",
            "97. Malamute de Alaska",
            "98. Whippet",
            "98.bis. Shar pei",
            "98.bis. Fox terrier de pelo duro",
            "101. Perro crestado rodesiano",
            "102. Podenco ibicenco",
            "102.bis. Terrier de Gales",
            "102.bis. Terrier irlandés",
            "105. Terrier de Bostón",
            "105.bis. Akita",
            "107. Skye terrier",
            "T108. Terrier de Norfolk",
            "T108. Sealyham terrier",
            "110. Carlino",
            "111. Bulldog francés",
            "T112. Griffon de Bruselas",
            "T112. Terrier de Malta",
            "114. Galgo italiano",
            "115. Chinese crested",
            "T116. Dandie Dinmont terrier",
            "T116. Vendeano",
            "T116. Terrier tibetano",
            "T116. Spaniel japonés",
            "T116. Lakeland terrier",
            "121. Pastor inglés antiguo",
            "122. Perro de montaña de los Pirineos",
            "T123. Terrier escocés",
            "T123. San Bernardo",
            "T125. Bull terrier",
            "T125. Petit Basset Griffon",
            "T125. Basset Grifón Vendeano",
            "128. Chihuahua",
            "129. Lhasa apso",
            "130. Mastín toro",
            "131. Shih Tzu",
            "132. Sabueso Basset",
            "T133. Mastín",
            "T133. Beagle",
            "135. Pekinés",
            "136. Sabueso",
            "137. Borzoi",
            "138. Chow chow",
            "139. Bulldog",
            "140. Basenji",
            "141. Sabueso afgano"});
            this.cmbRaza.Location = new System.Drawing.Point(482, 145);
            this.cmbRaza.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(180, 26);
            this.cmbRaza.TabIndex = 6;
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.GridColor = System.Drawing.Color.MistyRose;
            this.dgvDatos.Location = new System.Drawing.Point(336, 302);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(650, 229);
            this.dgvDatos.TabIndex = 7;
            // 
            // tsmMenu
            // 
            this.tsmMenu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tsmMenu.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslRegistrar,
            this.tslConsultar,
            this.tslEliminar,
            this.tslSalir,
            this.tslAcercade});
            this.tsmMenu.Location = new System.Drawing.Point(0, 0);
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsmMenu.Size = new System.Drawing.Size(1142, 25);
            this.tsmMenu.TabIndex = 8;
            this.tsmMenu.Text = "toolStrip1";
            // 
            // tslRegistrar
            // 
            this.tslRegistrar.Name = "tslRegistrar";
            this.tslRegistrar.Size = new System.Drawing.Size(69, 22);
            this.tslRegistrar.Text = "Registrar";
            this.tslRegistrar.Click += new System.EventHandler(this.tslRegistrar_Click);
            // 
            // tslConsultar
            // 
            this.tslConsultar.Name = "tslConsultar";
            this.tslConsultar.Size = new System.Drawing.Size(71, 22);
            this.tslConsultar.Text = "Consultar";
            this.tslConsultar.Click += new System.EventHandler(this.tslConsultar_Click);
            // 
            // tslEliminar
            // 
            this.tslEliminar.Name = "tslEliminar";
            this.tslEliminar.Size = new System.Drawing.Size(66, 22);
            this.tslEliminar.Text = "Eliminar";
            this.tslEliminar.Click += new System.EventHandler(this.tslEliminar_Click);
            // 
            // tslSalir
            // 
            this.tslSalir.Name = "tslSalir";
            this.tslSalir.Size = new System.Drawing.Size(39, 22);
            this.tslSalir.Text = "Salir";
            this.tslSalir.Click += new System.EventHandler(this.tslSalir_Click);
            // 
            // tslAcercade
            // 
            this.tslAcercade.Name = "tslAcercade";
            this.tslAcercade.Size = new System.Drawing.Size(87, 22);
            this.tslAcercade.Text = "Acerca de...";
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // FrmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ListaMascota.Properties.Resources.Animals;
            this.ClientSize = new System.Drawing.Size(1142, 564);
            this.Controls.Add(this.tsmMenu);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.cmbRaza);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDatos";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tsmMenu.ResumeLayout(false);
            this.tsmMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ToolStrip tsmMenu;
        private System.Windows.Forms.ToolStripLabel tslRegistrar;
        private System.Windows.Forms.ToolStripLabel tslConsultar;
        private System.Windows.Forms.ToolStripLabel tslEliminar;
        private System.Windows.Forms.ToolStripLabel tslSalir;
        private System.Windows.Forms.ToolStripLabel tslAcercade;
        private System.Windows.Forms.ErrorProvider erpError;
    }
}

