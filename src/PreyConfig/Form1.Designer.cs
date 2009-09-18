namespace Prey
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
            this.gbActivacion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMonitoreo = new System.Windows.Forms.NumericUpDown();
            this.lbMonitoreo = new System.Windows.Forms.Label();
            this.cbActivarPrey = new System.Windows.Forms.CheckBox();
            this.tbURLActivacion = new System.Windows.Forms.TextBox();
            this.lbURL = new System.Windows.Forms.Label();
            this.gbEnvioInformacion = new System.Windows.Forms.GroupBox();
            this.cbSSL = new System.Windows.Forms.CheckBox();
            this.tbPuertoSMTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.lbClave = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.tbServSMTP = new System.Windows.Forms.TextBox();
            this.lbServSMTP = new System.Windows.Forms.Label();
            this.tbCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lbCorreoElectronico = new System.Windows.Forms.Label();
            this.btnActivar = new System.Windows.Forms.Button();
            this.gbActivacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonitoreo)).BeginInit();
            this.gbEnvioInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbActivacion
            // 
            resources.ApplyResources(this.gbActivacion, "gbActivacion");
            this.gbActivacion.Controls.Add(this.label1);
            this.gbActivacion.Controls.Add(this.nudMonitoreo);
            this.gbActivacion.Controls.Add(this.lbMonitoreo);
            this.gbActivacion.Controls.Add(this.cbActivarPrey);
            this.gbActivacion.Controls.Add(this.tbURLActivacion);
            this.gbActivacion.Controls.Add(this.lbURL);
            this.gbActivacion.Name = "gbActivacion";
            this.gbActivacion.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // nudMonitoreo
            // 
            resources.ApplyResources(this.nudMonitoreo, "nudMonitoreo");
            this.nudMonitoreo.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudMonitoreo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonitoreo.Name = "nudMonitoreo";
            this.nudMonitoreo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbMonitoreo
            // 
            resources.ApplyResources(this.lbMonitoreo, "lbMonitoreo");
            this.lbMonitoreo.Name = "lbMonitoreo";
            // 
            // cbActivarPrey
            // 
            resources.ApplyResources(this.cbActivarPrey, "cbActivarPrey");
            this.cbActivarPrey.Name = "cbActivarPrey";
            this.cbActivarPrey.UseVisualStyleBackColor = true;
            this.cbActivarPrey.CheckedChanged += new System.EventHandler(this.cbActivarPrey_CheckedChanged_1);
            // 
            // tbURLActivacion
            // 
            resources.ApplyResources(this.tbURLActivacion, "tbURLActivacion");
            this.tbURLActivacion.Name = "tbURLActivacion";
            // 
            // lbURL
            // 
            resources.ApplyResources(this.lbURL, "lbURL");
            this.lbURL.Name = "lbURL";
            // 
            // gbEnvioInformacion
            // 
            resources.ApplyResources(this.gbEnvioInformacion, "gbEnvioInformacion");
            this.gbEnvioInformacion.Controls.Add(this.cbSSL);
            this.gbEnvioInformacion.Controls.Add(this.tbPuertoSMTP);
            this.gbEnvioInformacion.Controls.Add(this.label2);
            this.gbEnvioInformacion.Controls.Add(this.tbClave);
            this.gbEnvioInformacion.Controls.Add(this.lbClave);
            this.gbEnvioInformacion.Controls.Add(this.tbUsuario);
            this.gbEnvioInformacion.Controls.Add(this.lbUsuario);
            this.gbEnvioInformacion.Controls.Add(this.tbServSMTP);
            this.gbEnvioInformacion.Controls.Add(this.lbServSMTP);
            this.gbEnvioInformacion.Controls.Add(this.tbCorreoElectronico);
            this.gbEnvioInformacion.Controls.Add(this.lbCorreoElectronico);
            this.gbEnvioInformacion.Name = "gbEnvioInformacion";
            this.gbEnvioInformacion.TabStop = false;
            this.gbEnvioInformacion.Enter += new System.EventHandler(this.gbEnvioInformacion_Enter);
            // 
            // cbSSL
            // 
            resources.ApplyResources(this.cbSSL, "cbSSL");
            this.cbSSL.Name = "cbSSL";
            this.cbSSL.UseVisualStyleBackColor = true;
            // 
            // tbPuertoSMTP
            // 
            resources.ApplyResources(this.tbPuertoSMTP, "tbPuertoSMTP");
            this.tbPuertoSMTP.Name = "tbPuertoSMTP";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbClave
            // 
            resources.ApplyResources(this.tbClave, "tbClave");
            this.tbClave.Name = "tbClave";
            // 
            // lbClave
            // 
            resources.ApplyResources(this.lbClave, "lbClave");
            this.lbClave.Name = "lbClave";
            // 
            // tbUsuario
            // 
            resources.ApplyResources(this.tbUsuario, "tbUsuario");
            this.tbUsuario.Name = "tbUsuario";
            // 
            // lbUsuario
            // 
            resources.ApplyResources(this.lbUsuario, "lbUsuario");
            this.lbUsuario.Name = "lbUsuario";
            // 
            // tbServSMTP
            // 
            resources.ApplyResources(this.tbServSMTP, "tbServSMTP");
            this.tbServSMTP.Name = "tbServSMTP";
            // 
            // lbServSMTP
            // 
            resources.ApplyResources(this.lbServSMTP, "lbServSMTP");
            this.lbServSMTP.Name = "lbServSMTP";
            // 
            // tbCorreoElectronico
            // 
            resources.ApplyResources(this.tbCorreoElectronico, "tbCorreoElectronico");
            this.tbCorreoElectronico.Name = "tbCorreoElectronico";
            // 
            // lbCorreoElectronico
            // 
            resources.ApplyResources(this.lbCorreoElectronico, "lbCorreoElectronico");
            this.lbCorreoElectronico.Name = "lbCorreoElectronico";
            // 
            // btnActivar
            // 
            resources.ApplyResources(this.btnActivar, "btnActivar");
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click_1);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.gbEnvioInformacion);
            this.Controls.Add(this.gbActivacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.gbActivacion.ResumeLayout(false);
            this.gbActivacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonitoreo)).EndInit();
            this.gbEnvioInformacion.ResumeLayout(false);
            this.gbEnvioInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbActivacion;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.TextBox tbURLActivacion;
        private System.Windows.Forms.CheckBox cbActivarPrey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMonitoreo;
        private System.Windows.Forms.Label lbMonitoreo;
        private System.Windows.Forms.GroupBox gbEnvioInformacion;
        private System.Windows.Forms.TextBox tbCorreoElectronico;
        private System.Windows.Forms.Label lbCorreoElectronico;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox tbServSMTP;
        private System.Windows.Forms.Label lbServSMTP;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.CheckBox cbSSL;
        private System.Windows.Forms.TextBox tbPuertoSMTP;
        private System.Windows.Forms.Label label2;
    }
}

