namespace Aplicación_Desafío
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
            button1 = new Button();
            LabelTitulo = new Label();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            txtNombre = new TextBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            txtIDTipo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            elimProd = new TextBox();
            button5 = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            campoID = new TextBox();
            label1 = new Label();
            label8 = new Label();
            txtCantidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(617, 205);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 0;
            button1.Text = "Cargar producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LabelTitulo
            // 
            LabelTitulo.Anchor = AnchorStyles.None;
            LabelTitulo.AutoSize = true;
            LabelTitulo.BackColor = Color.Azure;
            LabelTitulo.BorderStyle = BorderStyle.FixedSingle;
            LabelTitulo.Cursor = Cursors.IBeam;
            LabelTitulo.FlatStyle = FlatStyle.System;
            LabelTitulo.Font = new Font("Corbel", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelTitulo.Location = new Point(295, 9);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(392, 35);
            LabelTitulo.TabIndex = 1;
            LabelTitulo.Text = "BIENVENIDO A PRODUCTVIEWER";
            LabelTitulo.TextAlign = ContentAlignment.TopCenter;
            LabelTitulo.Click += label1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 29);
            button4.Name = "button4";
            button4.Size = new Size(121, 23);
            button4.TabIndex = 4;
            button4.Text = "Ver stock total";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(389, 329);
            dataGridView1.TabIndex = 5;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(575, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(134, 23);
            txtNombre.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(463, 70);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre producto:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(575, 96);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(134, 23);
            txtPrecio.TabIndex = 8;
            // 
            // txtIDTipo
            // 
            txtIDTipo.Location = new Point(575, 125);
            txtIDTipo.Name = "txtIDTipo";
            txtIDTipo.Size = new Size(134, 23);
            txtIDTipo.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(463, 96);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 10;
            label3.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(463, 128);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 11;
            label4.Text = "Id tipo producto:";
            label4.Click += label4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(447, 367);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 14;
            label7.Text = "ID producto:";
            // 
            // elimProd
            // 
            elimProd.Location = new Point(526, 364);
            elimProd.Name = "elimProd";
            elimProd.Size = new Size(134, 23);
            elimProd.TabIndex = 13;
            // 
            // button5
            // 
            button5.Location = new Point(526, 335);
            button5.Name = "button5";
            button5.Size = new Size(134, 23);
            button5.TabIndex = 12;
            button5.Text = "Eliminar producto";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(435, 205);
            button2.Name = "button2";
            button2.Size = new Size(134, 23);
            button2.TabIndex = 19;
            button2.Text = "Modificar producto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DarkOrchid;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(315, 428);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(186, 13);
            linkLabel1.TabIndex = 26;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "DELGADO UGARTE MATEO MIGUEL";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // campoID
            // 
            campoID.Location = new Point(575, 257);
            campoID.Name = "campoID";
            campoID.Size = new Size(41, 23);
            campoID.TabIndex = 27;
            campoID.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(575, 239);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 28;
            label1.Text = "ID:";
            label1.Click += label1_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(463, 157);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 30;
            label8.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(575, 154);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(134, 23);
            txtCantidad.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.MintCream;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(txtCantidad);
            Controls.Add(label1);
            Controls.Add(campoID);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(elimProd);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtIDTipo);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(LabelTitulo);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            Text = "Product Viewer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label LabelTitulo;
        private Button button4;
        private DataGridView dataGridView1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtPrecio;
        private TextBox txtIDTipo;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label7;
        private TextBox elimProd;
        private Button button5;
        private Button button2;
        private LinkLabel linkLabel1;
        private TextBox campoID;
        private Label label1;
        private Label label8;
        private TextBox txtCantidad;
    }
}
