namespace csharp_oop_ecommerce_basic
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listino = new System.Windows.Forms.ListView();
            this.buttonVisualizza = new System.Windows.Forms.Button();
            this.buttonCreaCarrello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listino
            // 
            this.listino.HideSelection = false;
            this.listino.Location = new System.Drawing.Point(12, 12);
            this.listino.MultiSelect = false;
            this.listino.Name = "listino";
            this.listino.Size = new System.Drawing.Size(1076, 629);
            this.listino.TabIndex = 0;
            this.listino.UseCompatibleStateImageBehavior = false;
            this.listino.View = System.Windows.Forms.View.Details;
            this.listino.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // buttonVisualizza
            // 
            this.buttonVisualizza.Location = new System.Drawing.Point(1112, 141);
            this.buttonVisualizza.Name = "buttonVisualizza";
            this.buttonVisualizza.Size = new System.Drawing.Size(214, 71);
            this.buttonVisualizza.TabIndex = 1;
            this.buttonVisualizza.Text = "Visualizza";
            this.buttonVisualizza.UseVisualStyleBackColor = true;
            this.buttonVisualizza.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCreaCarrello
            // 
            this.buttonCreaCarrello.Location = new System.Drawing.Point(1112, 47);
            this.buttonCreaCarrello.Name = "buttonCreaCarrello";
            this.buttonCreaCarrello.Size = new System.Drawing.Size(214, 71);
            this.buttonCreaCarrello.TabIndex = 2;
            this.buttonCreaCarrello.Text = "Crea carrello di prova";
            this.buttonCreaCarrello.UseVisualStyleBackColor = true;
            this.buttonCreaCarrello.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 653);
            this.Controls.Add(this.buttonCreaCarrello);
            this.Controls.Add(this.buttonVisualizza);
            this.Controls.Add(this.listino);
            this.Name = "Form1";
            this.Text = "Basic Ecommerce Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listino;
        private System.Windows.Forms.Button buttonVisualizza;
        private System.Windows.Forms.Button buttonCreaCarrello;
    }
}

