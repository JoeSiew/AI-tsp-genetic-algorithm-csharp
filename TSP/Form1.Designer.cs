namespace TSP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MapPanel = new System.Windows.Forms.Panel();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTerminate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblChromosome = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblBestFit = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InitalizeBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.MapPanel.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MapPanel
            // 
            this.MapPanel.BackColor = System.Drawing.Color.White;
            this.MapPanel.BackgroundImage = global::TSP.Properties.Resources.MalaysiaMap;
            this.MapPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MapPanel.Controls.Add(this.GroupBox2);
            this.MapPanel.Controls.Add(this.InitalizeBtn);
            this.MapPanel.Controls.Add(this.StartBtn);
            this.MapPanel.Location = new System.Drawing.Point(0, 0);
            this.MapPanel.Name = "MapPanel";
            this.MapPanel.Size = new System.Drawing.Size(784, 561);
            this.MapPanel.TabIndex = 0;
            this.MapPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MapPanel_Paint);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.lblTerminate);
            this.GroupBox2.Controls.Add(this.label6);
            this.GroupBox2.Controls.Add(this.lblStatus);
            this.GroupBox2.Controls.Add(this.label5);
            this.GroupBox2.Controls.Add(this.lblChromosome);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.lblBestFit);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.lblGen);
            this.GroupBox2.Controls.Add(this.label1);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(559, 40);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(213, 113);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Data";
            // 
            // lblTerminate
            // 
            this.lblTerminate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminate.Location = new System.Drawing.Point(126, 72);
            this.lblTerminate.Name = "lblTerminate";
            this.lblTerminate.Size = new System.Drawing.Size(64, 13);
            this.lblTerminate.TabIndex = 14;
            this.lblTerminate.Text = "0";
            this.lblTerminate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Termination (20th)";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(123, 91);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Not started";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status";
            // 
            // lblChromosome
            // 
            this.lblChromosome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChromosome.Location = new System.Drawing.Point(104, 53);
            this.lblChromosome.Name = "lblChromosome";
            this.lblChromosome.Size = new System.Drawing.Size(86, 13);
            this.lblChromosome.TabIndex = 10;
            this.lblChromosome.Text = "0";
            this.lblChromosome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(5, 53);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(68, 13);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Chromosome";
            // 
            // lblBestFit
            // 
            this.lblBestFit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestFit.Location = new System.Drawing.Point(132, 34);
            this.lblBestFit.Name = "lblBestFit";
            this.lblBestFit.Size = new System.Drawing.Size(58, 13);
            this.lblBestFit.TabIndex = 7;
            this.lblBestFit.Text = "0";
            this.lblBestFit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(5, 34);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(97, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Current best fitness";
            // 
            // lblGen
            // 
            this.lblGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen.Location = new System.Drawing.Point(88, 16);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(102, 13);
            this.lblGen.TabIndex = 5;
            this.lblGen.Text = "0";
            this.lblGen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generation";
            // 
            // InitalizeBtn
            // 
            this.InitalizeBtn.Location = new System.Drawing.Point(579, 186);
            this.InitalizeBtn.Name = "InitalizeBtn";
            this.InitalizeBtn.Size = new System.Drawing.Size(80, 25);
            this.InitalizeBtn.TabIndex = 2;
            this.InitalizeBtn.Text = "Reinitalize";
            this.InitalizeBtn.UseVisualStyleBackColor = true;
            this.InitalizeBtn.Click += new System.EventHandler(this.InitializeBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(669, 186);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(80, 25);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MapPanel);
            this.Name = "Form1";
            this.Text = "Utsco";
            this.MapPanel.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MapPanel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button InitalizeBtn;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label lblChromosome;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblBestFit;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblGen;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblStatus;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label lblTerminate;
        internal System.Windows.Forms.Label label6;
    }
}

