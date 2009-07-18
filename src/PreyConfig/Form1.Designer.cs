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
            this.gbActivacion.AccessibleDescription = null;
            this.gbActivacion.AccessibleName = null;
            resources.ApplyResources(this.gbActivacion, "gbActivacion");
            this.gbActivacion.BackgroundImage = null;
            this.gbActivacion.Controls.Add(this.label1);
            this.gbActivacion.Controls.Add(this.nudMonitoreo);
            this.gbActivacion.Controls.Add(this.lbMonitoreo);
            this.gbActivacion.Controls.Add(this.cbActivarPrey);
            this.gbActivacion.Controls.Add(this.tbURLActivacion);
            this.gbActivacion.Controls.Add(this.lbURL);
            this.gbActivacion.Font = null;
            this.gbActivacion.Name = "gbActivacion";
            this.gbActivacion.TabStop = false;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // nudMonitoreo
            // 
            this.nudMonitoreo.AccessibleDescription = null;
            this.nudMonitoreo.AccessibleName = null;
            resources.ApplyResources(this.nudMonitoreo, "nudMonitoreo");
            this.nudMonitoreo.Font = null;
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
            this.lbMonitoreo.AccessibleDescription = null;
            this.lbMonitoreo.AccessibleName = null;
            resources.ApplyResources(this.lbMonitoreo, "lbMonitoreo");
            this.lbMonitoreo.Font = null;
            this.lbMonitoreo.Name = "lbMonitoreo";
            // 
            // cbActivarPrey
            // 
            this.cbActivarPrey.AccessibleDescription = null;
            this.cbActivarPrey.AccessibleName = null;
            resources.ApplyResources(this.cbActivarPrey, "cbActivarPrey");
            this.cbActivarPrey.BackgroundImage = null;
            this.cbActivarPrey.Font = null;
            this.cbActivarPrey.Name = "cbActivarPrey";
            this.cbActivarPrey.UseVisualStyleBackColor = true;
            // 
            // tbURLActivacion
            // 
            this.tbURLActivacion.AccessibleDescription = null;
            this.tbURLActivacion.AccessibleName = null;
            resources.ApplyResources(this.tbURLActivacion, "tbURLActivacion");
            this.tbURLActivacion.BackgroundImage = null;
            this.tbURLActivacion.Font = null;
            this.tbURLActivacion.Name = "tbURLActivacion";
            // 
            // lbURL
            // 
            this.lbURL.AccessibleDescription = null;
            this.lbURL.AccessibleName = null;
            resources.ApplyResources(this.lbURL, "lbURL");
            this.lbURL.Font = null;
            this.lbURL.Name = "lbURL";
            // 
            // gbEnvioInformacion
            // 
            this.gbEnvioInformacion.AccessibleDescription = null;
            this.gbEnvioInformacion.AccessibleName = null;
            resources.ApplyResources(this.gbEnvioInformacion, "gbEnvioInformacion");
            this.gbEnvioInformacion.BackgroundImage = null;
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
            this.gbEnvioInformacion.Font = null;
            this.gbEnvioInformacion.Name = "gbEnvioInformacion";
            this.gbEnvioInformacion.TabStop = false;
            this.gbEnvioInformacion.Enter += new System.EventHandler(this.gbEnvioInformacion_Enter);
            // 
            // cbSSL
            // 
            this.cbSSL.AccessibleDescription = null;
            this.cbSSL.AccessibleName = null;
            resources.ApplyResources(this.cbSSL, "cbSSL");
            this.cbSSL.BackgroundImage = null;
            this.cbSSL.Font = null;
            this.cbSSL.Name = "cbSSL";
            this.cbSSL.UseVisualStyleBackColor = true;
            // 
            // tbPuertoSMTP
            // 
            this.tbPuertoSMTP.AccessibleDescription = null;
            this.tbPuertoSMTP.AccessibleName = null;
            resources.ApplyResources(this.tbPuertoSMTP, "tbPuertoSMTP");
            this.tbPuertoSMTP.BackgroundImage = null;
            this.tbPuertoSMTP.Font = null;
            this.tbPuertoSMTP.Name = "tbPuertoSMTP";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
            // 
            // tbClave
            // 
            this.tbClave.AccessibleDescription = null;
            this.tbClave.AccessibleName = null;
            resources.ApplyResources(this.tbClave, "tbClave");
            this.tbClave.BackgroundImage = null;
            this.tbClave.Font = null;
            this.tbClave.Name = "tbClave";
            // 
            // lbClave
            // 
            this.lbClave.AccessibleDescription = null;
            this.lbClave.AccessibleName = null;
            resources.ApplyResources(this.lbClave, "lbClave");
            this.lbClave.Font = null;
            this.lbClave.Name = "lbClave";
            // 
            // tbUsuario
            // 
            this.tbUsuario.AccessibleDescription = null;
            this.tbUsuario.AccessibleName = null;
            resources.ApplyResources(this.tbUsuario, "tbUsuario");
            this.tbUsuario.BackgroundImage = null;
            this.tbUsuario.Font = null;
            this.tbUsuario.Name = "tbUsuario";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AccessibleDescription = null;
            this.lbUsuario.AccessibleName = null;
            resources.ApplyResources(this.lbUsuario, "lbUsuario");
            this.lbUsuario.Font = null;
            this.lbUsuario.Name = "lbUsuario";
            // 
            // tbServSMTP
            // 
            this.tbServSMTP.AccessibleDescription = null;
            this.tbServSMTP.AccessibleName = null;
            resources.ApplyResources(this.tbServSMTP, "tbServSMTP");
            this.tbServSMTP.BackgroundImage = null;
            this.tbServSMTP.Font = null;
            this.tbServSMTP.Name = "tbServSMTP";
            // 
            // lbServSMTP
            // 
            this.lbServSMTP.AccessibleDescription = null;
            this.lbServSMTP.AccessibleName = null;
            resources.ApplyResources(this.lbServSMTP, "lbServSMTP");
            this.lbServSMTP.Font = null;
            this.lbServSMTP.Name = "lbServSMTP";
            // 
            // tbCorreoElectronico
            // 
            this.tbCorreoElectronico.AccessibleDescription = null;
            this.tbCorreoElectronico.AccessibleName = null;
            resources.ApplyResources(this.tbCorreoElectronico, "tbCorreoElectronico");
            this.tbCorreoElectronico.BackgroundImage = null;
            this.tbCorreoElectronico.Font = null;
            this.tbCorreoElectronico.Name = "tbCorreoElectronico";
            // 
            // lbCorreoElectronico
            // 
            this.lbCorreoElectronico.AccessibleDescription = null;
            this.lbCorreoElectronico.AccessibleName = null;
            resources.ApplyResources(this.lbCorreoElectronico, "lbCorreoElectronico");
            this.lbCorreoElectronico.Font = null;
            this.lbCorreoElectronico.Name = "lbCorreoElectronico";
            // 
            // btnActivar
            // 
            this.btnActivar.AccessibleDescription = null;
            this.btnActivar.AccessibleName = null;
            resources.ApplyResources(this.btnActivar, "btnActivar");
            this.btnActivar.BackgroundImage = null;
            this.btnActivar.Font = null;
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = null;
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

