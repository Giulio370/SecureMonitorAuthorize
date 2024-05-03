
namespace App_FileAutorizzazione
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Crea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Importa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_IdGpu = new System.Windows.Forms.Label();
            this.label_nomeMon = new System.Windows.Forms.Label();
            this.label_IdMon = new System.Windows.Forms.Label();
            this.panel_MonitorIcon = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Crea);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Importa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 100);
            this.panel1.TabIndex = 1;
            // 
            // btn_Crea
            // 
            this.btn_Crea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Crea.BackgroundImage = global::App_FileAutorizzazione.Properties.Resources.Conferma_BiancoNero;
            this.btn_Crea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Crea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Crea.Location = new System.Drawing.Point(772, 12);
            this.btn_Crea.Name = "btn_Crea";
            this.btn_Crea.Size = new System.Drawing.Size(75, 75);
            this.btn_Crea.TabIndex = 2;
            this.btn_Crea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Crea.UseVisualStyleBackColor = true;
            this.btn_Crea.Click += new System.EventHandler(this.btn_Crea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creating permissions";
            // 
            // btn_Importa
            // 
            this.btn_Importa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Importa.BackgroundImage = global::App_FileAutorizzazione.Properties.Resources.Importa;
            this.btn_Importa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Importa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Importa.Location = new System.Drawing.Point(691, 12);
            this.btn_Importa.Name = "btn_Importa";
            this.btn_Importa.Size = new System.Drawing.Size(75, 75);
            this.btn_Importa.TabIndex = 0;
            this.btn_Importa.Text = "Import file";
            this.btn_Importa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Importa.UseVisualStyleBackColor = true;
            this.btn_Importa.Click += new System.EventHandler(this.btn_Importa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Monitor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome Monitor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID GPU:";
            // 
            // label_IdGpu
            // 
            this.label_IdGpu.AutoSize = true;
            this.label_IdGpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IdGpu.Location = new System.Drawing.Point(197, 291);
            this.label_IdGpu.Name = "label_IdGpu";
            this.label_IdGpu.Size = new System.Drawing.Size(57, 24);
            this.label_IdGpu.TabIndex = 7;
            this.label_IdGpu.Text = "None";
            // 
            // label_nomeMon
            // 
            this.label_nomeMon.AutoSize = true;
            this.label_nomeMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomeMon.Location = new System.Drawing.Point(197, 241);
            this.label_nomeMon.Name = "label_nomeMon";
            this.label_nomeMon.Size = new System.Drawing.Size(57, 24);
            this.label_nomeMon.TabIndex = 6;
            this.label_nomeMon.Text = "None";
            // 
            // label_IdMon
            // 
            this.label_IdMon.AutoSize = true;
            this.label_IdMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IdMon.Location = new System.Drawing.Point(197, 188);
            this.label_IdMon.Name = "label_IdMon";
            this.label_IdMon.Size = new System.Drawing.Size(57, 24);
            this.label_IdMon.TabIndex = 5;
            this.label_IdMon.Text = "None";
            // 
            // panel_MonitorIcon
            // 
            this.panel_MonitorIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_MonitorIcon.BackgroundImage = global::App_FileAutorizzazione.Properties.Resources.Monitor;
            this.panel_MonitorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_MonitorIcon.Location = new System.Drawing.Point(593, 149);
            this.panel_MonitorIcon.Name = "panel_MonitorIcon";
            this.panel_MonitorIcon.Size = new System.Drawing.Size(225, 219);
            this.panel_MonitorIcon.TabIndex = 8;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 504);
            this.Controls.Add(this.panel_MonitorIcon);
            this.Controls.Add(this.label_IdGpu);
            this.Controls.Add(this.label_nomeMon);
            this.Controls.Add(this.label_IdMon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Autorizza Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Importa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Crea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_IdGpu;
        private System.Windows.Forms.Label label_nomeMon;
        private System.Windows.Forms.Label label_IdMon;
        private System.Windows.Forms.Panel panel_MonitorIcon;
    }
}

