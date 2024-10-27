
namespace Clave1_GrupoDeTrabajo1.Interfaz
{
    partial class veterinarioExpediente
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnIrCita = new System.Windows.Forms.Button();
            this.tabHistorialMedico = new System.Windows.Forms.TabPage();
            this.panelHM = new System.Windows.Forms.Panel();
            this.lblHistorialCitas = new System.Windows.Forms.Label();
            this.lblHistorialPaciente = new System.Windows.Forms.Label();
            this.dgvHVacunas = new System.Windows.Forms.DataGridView();
            this.Vacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProximaDosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHPaciente = new System.Windows.Forms.DataGridView();
            this.Cirugias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Examenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alergias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicamentosActuales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimaVacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaProximaVacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvHCitas = new System.Windows.Forms.DataGridView();
            this.IdCitaAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotivoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sintomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamenFisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHistorialVacunas = new System.Windows.Forms.Label();
            this.tabInformacionGeneral = new System.Windows.Forms.TabPage();
            this.gbxDatosDueno = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccionDueno = new System.Windows.Forms.TextBox();
            this.txtCorreoDueno = new System.Windows.Forms.TextBox();
            this.txtNomDueno = new System.Windows.Forms.TextBox();
            this.txtTelefonoDueno = new System.Windows.Forms.TextBox();
            this.txtIdDuenoExp = new System.Windows.Forms.TextBox();
            this.gbxDatosMascota = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.cbxIdMascota = new System.Windows.Forms.ComboBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtNomMascota = new System.Windows.Forms.TextBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblNomMascota = new System.Windows.Forms.Label();
            this.tapExpediente = new System.Windows.Forms.TabControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabHistorialMedico.SuspendLayout();
            this.panelHM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHVacunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHCitas)).BeginInit();
            this.tabInformacionGeneral.SuspendLayout();
            this.gbxDatosDueno.SuspendLayout();
            this.gbxDatosMascota.SuspendLayout();
            this.tapExpediente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(198, 560);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(125, 49);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnIrCita
            // 
            this.btnIrCita.Location = new System.Drawing.Point(576, 560);
            this.btnIrCita.Name = "btnIrCita";
            this.btnIrCita.Size = new System.Drawing.Size(125, 49);
            this.btnIrCita.TabIndex = 2;
            this.btnIrCita.Text = "Ir Cita";
            this.btnIrCita.UseVisualStyleBackColor = true;
            this.btnIrCita.Click += new System.EventHandler(this.btnIrCita_Click);
            // 
            // tabHistorialMedico
            // 
            this.tabHistorialMedico.Controls.Add(this.panelHM);
            this.tabHistorialMedico.Location = new System.Drawing.Point(4, 22);
            this.tabHistorialMedico.Name = "tabHistorialMedico";
            this.tabHistorialMedico.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorialMedico.Size = new System.Drawing.Size(912, 446);
            this.tabHistorialMedico.TabIndex = 2;
            this.tabHistorialMedico.Text = "Historial Medico";
            this.tabHistorialMedico.UseVisualStyleBackColor = true;
            // 
            // panelHM
            // 
            this.panelHM.AutoScroll = true;
            this.panelHM.Controls.Add(this.lblHistorialCitas);
            this.panelHM.Controls.Add(this.lblHistorialPaciente);
            this.panelHM.Controls.Add(this.dgvHVacunas);
            this.panelHM.Controls.Add(this.dgvHPaciente);
            this.panelHM.Controls.Add(this.dtpFecha);
            this.panelHM.Controls.Add(this.dgvHCitas);
            this.panelHM.Controls.Add(this.lblHistorialVacunas);
            this.panelHM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHM.Location = new System.Drawing.Point(3, 3);
            this.panelHM.Name = "panelHM";
            this.panelHM.Size = new System.Drawing.Size(906, 440);
            this.panelHM.TabIndex = 1;
            // 
            // lblHistorialCitas
            // 
            this.lblHistorialCitas.AutoSize = true;
            this.lblHistorialCitas.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialCitas.Location = new System.Drawing.Point(315, 134);
            this.lblHistorialCitas.Name = "lblHistorialCitas";
            this.lblHistorialCitas.Size = new System.Drawing.Size(178, 27);
            this.lblHistorialCitas.TabIndex = 8;
            this.lblHistorialCitas.Text = "Historial de Citas";
            // 
            // lblHistorialPaciente
            // 
            this.lblHistorialPaciente.AutoSize = true;
            this.lblHistorialPaciente.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialPaciente.Location = new System.Drawing.Point(332, 406);
            this.lblHistorialPaciente.Name = "lblHistorialPaciente";
            this.lblHistorialPaciente.Size = new System.Drawing.Size(220, 27);
            this.lblHistorialPaciente.TabIndex = 7;
            this.lblHistorialPaciente.Text = "Historial del Paciente";
            // 
            // dgvHVacunas
            // 
            this.dgvHVacunas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHVacunas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vacuna,
            this.FechaAplicacion,
            this.Motivo,
            this.ProximaDosis});
            this.dgvHVacunas.Location = new System.Drawing.Point(12, 728);
            this.dgvHVacunas.Name = "dgvHVacunas";
            this.dgvHVacunas.Size = new System.Drawing.Size(848, 150);
            this.dgvHVacunas.TabIndex = 6;
            // 
            // Vacuna
            // 
            this.Vacuna.HeaderText = "Vacuna";
            this.Vacuna.Name = "Vacuna";
            this.Vacuna.ReadOnly = true;
            // 
            // FechaAplicacion
            // 
            this.FechaAplicacion.HeaderText = "Fecha de Aplicacion";
            this.FechaAplicacion.Name = "FechaAplicacion";
            this.FechaAplicacion.ReadOnly = true;
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            // 
            // ProximaDosis
            // 
            this.ProximaDosis.HeaderText = "Proxima Dosis";
            this.ProximaDosis.Name = "ProximaDosis";
            this.ProximaDosis.ReadOnly = true;
            // 
            // dgvHPaciente
            // 
            this.dgvHPaciente.AllowUserToDeleteRows = false;
            this.dgvHPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cirugias,
            this.Examenes,
            this.Alergias,
            this.MedicamentosActuales,
            this.UltimaVacuna,
            this.Fecha,
            this.FechaProximaVacuna});
            this.dgvHPaciente.Location = new System.Drawing.Point(12, 453);
            this.dgvHPaciente.Name = "dgvHPaciente";
            this.dgvHPaciente.Size = new System.Drawing.Size(848, 150);
            this.dgvHPaciente.TabIndex = 5;
            // 
            // Cirugias
            // 
            this.Cirugias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cirugias.HeaderText = "Cirugias";
            this.Cirugias.Name = "Cirugias";
            // 
            // Examenes
            // 
            this.Examenes.HeaderText = "Examenes";
            this.Examenes.Name = "Examenes";
            // 
            // Alergias
            // 
            this.Alergias.HeaderText = "Alergias";
            this.Alergias.Name = "Alergias";
            // 
            // MedicamentosActuales
            // 
            this.MedicamentosActuales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicamentosActuales.HeaderText = "Medicamentos Actuales";
            this.MedicamentosActuales.Name = "MedicamentosActuales";
            // 
            // UltimaVacuna
            // 
            this.UltimaVacuna.HeaderText = "Ultima Vacuna";
            this.UltimaVacuna.Name = "UltimaVacuna";
            this.UltimaVacuna.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // FechaProximaVacuna
            // 
            this.FechaProximaVacuna.HeaderText = "Fecha Proxima Vacuna";
            this.FechaProximaVacuna.Name = "FechaProximaVacuna";
            this.FechaProximaVacuna.ReadOnly = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(680, 13);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // dgvHCitas
            // 
            this.dgvHCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCitaAnterior,
            this.MotivoConsulta,
            this.Sintomas,
            this.ExamenFisico,
            this.Diagnostico,
            this.Tratamiento,
            this.Medicamentos,
            this.Notas});
            this.dgvHCitas.Location = new System.Drawing.Point(12, 203);
            this.dgvHCitas.Name = "dgvHCitas";
            this.dgvHCitas.Size = new System.Drawing.Size(848, 161);
            this.dgvHCitas.TabIndex = 3;
            // 
            // IdCitaAnterior
            // 
            this.IdCitaAnterior.HeaderText = "ID Cita Anterior";
            this.IdCitaAnterior.Name = "IdCitaAnterior";
            // 
            // MotivoConsulta
            // 
            this.MotivoConsulta.HeaderText = "Motivo Consulta";
            this.MotivoConsulta.Name = "MotivoConsulta";
            // 
            // Sintomas
            // 
            this.Sintomas.HeaderText = "Sintomas";
            this.Sintomas.Name = "Sintomas";
            // 
            // ExamenFisico
            // 
            this.ExamenFisico.HeaderText = "Examen Fisico";
            this.ExamenFisico.Name = "ExamenFisico";
            // 
            // Diagnostico
            // 
            this.Diagnostico.HeaderText = "Diagnostico";
            this.Diagnostico.Name = "Diagnostico";
            // 
            // Tratamiento
            // 
            this.Tratamiento.HeaderText = "Traramiento";
            this.Tratamiento.Name = "Tratamiento";
            // 
            // Medicamentos
            // 
            this.Medicamentos.HeaderText = "Medicamentos";
            this.Medicamentos.Name = "Medicamentos";
            // 
            // Notas
            // 
            this.Notas.HeaderText = "Notas";
            this.Notas.Name = "Notas";
            // 
            // lblHistorialVacunas
            // 
            this.lblHistorialVacunas.AutoSize = true;
            this.lblHistorialVacunas.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialVacunas.Location = new System.Drawing.Point(332, 674);
            this.lblHistorialVacunas.Name = "lblHistorialVacunas";
            this.lblHistorialVacunas.Size = new System.Drawing.Size(212, 27);
            this.lblHistorialVacunas.TabIndex = 2;
            this.lblHistorialVacunas.Text = "Historial de Vacunas";
            // 
            // tabInformacionGeneral
            // 
            this.tabInformacionGeneral.Controls.Add(this.gbxDatosDueno);
            this.tabInformacionGeneral.Controls.Add(this.gbxDatosMascota);
            this.tabInformacionGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabInformacionGeneral.Name = "tabInformacionGeneral";
            this.tabInformacionGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabInformacionGeneral.Size = new System.Drawing.Size(912, 446);
            this.tabInformacionGeneral.TabIndex = 0;
            this.tabInformacionGeneral.Text = "Informacion General";
            this.tabInformacionGeneral.UseVisualStyleBackColor = true;
            // 
            // gbxDatosDueno
            // 
            this.gbxDatosDueno.Controls.Add(this.label4);
            this.gbxDatosDueno.Controls.Add(this.label5);
            this.gbxDatosDueno.Controls.Add(this.label6);
            this.gbxDatosDueno.Controls.Add(this.label7);
            this.gbxDatosDueno.Controls.Add(this.label8);
            this.gbxDatosDueno.Controls.Add(this.txtDireccionDueno);
            this.gbxDatosDueno.Controls.Add(this.txtCorreoDueno);
            this.gbxDatosDueno.Controls.Add(this.txtNomDueno);
            this.gbxDatosDueno.Controls.Add(this.txtTelefonoDueno);
            this.gbxDatosDueno.Controls.Add(this.txtIdDuenoExp);
            this.gbxDatosDueno.Location = new System.Drawing.Point(16, 200);
            this.gbxDatosDueno.Name = "gbxDatosDueno";
            this.gbxDatosDueno.Size = new System.Drawing.Size(880, 224);
            this.gbxDatosDueno.TabIndex = 24;
            this.gbxDatosDueno.TabStop = false;
            this.gbxDatosDueno.Text = "Datos Dueño";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nombre Dueño";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "ID Dueño";
            // 
            // txtDireccionDueno
            // 
            this.txtDireccionDueno.Location = new System.Drawing.Point(32, 176);
            this.txtDireccionDueno.Name = "txtDireccionDueno";
            this.txtDireccionDueno.ReadOnly = true;
            this.txtDireccionDueno.Size = new System.Drawing.Size(432, 20);
            this.txtDireccionDueno.TabIndex = 33;
            // 
            // txtCorreoDueno
            // 
            this.txtCorreoDueno.Location = new System.Drawing.Point(32, 112);
            this.txtCorreoDueno.Name = "txtCorreoDueno";
            this.txtCorreoDueno.ReadOnly = true;
            this.txtCorreoDueno.Size = new System.Drawing.Size(432, 20);
            this.txtCorreoDueno.TabIndex = 32;
            // 
            // txtNomDueno
            // 
            this.txtNomDueno.Location = new System.Drawing.Point(304, 48);
            this.txtNomDueno.Name = "txtNomDueno";
            this.txtNomDueno.ReadOnly = true;
            this.txtNomDueno.Size = new System.Drawing.Size(160, 20);
            this.txtNomDueno.TabIndex = 31;
            // 
            // txtTelefonoDueno
            // 
            this.txtTelefonoDueno.Location = new System.Drawing.Point(576, 48);
            this.txtTelefonoDueno.Name = "txtTelefonoDueno";
            this.txtTelefonoDueno.ReadOnly = true;
            this.txtTelefonoDueno.Size = new System.Drawing.Size(160, 20);
            this.txtTelefonoDueno.TabIndex = 30;
            // 
            // txtIdDuenoExp
            // 
            this.txtIdDuenoExp.Location = new System.Drawing.Point(32, 48);
            this.txtIdDuenoExp.Name = "txtIdDuenoExp";
            this.txtIdDuenoExp.ReadOnly = true;
            this.txtIdDuenoExp.Size = new System.Drawing.Size(160, 20);
            this.txtIdDuenoExp.TabIndex = 29;
            // 
            // gbxDatosMascota
            // 
            this.gbxDatosMascota.Controls.Add(this.label1);
            this.gbxDatosMascota.Controls.Add(this.txtSexo);
            this.gbxDatosMascota.Controls.Add(this.cbxIdMascota);
            this.gbxDatosMascota.Controls.Add(this.txtFechaNacimiento);
            this.gbxDatosMascota.Controls.Add(this.txtRaza);
            this.gbxDatosMascota.Controls.Add(this.lblRaza);
            this.gbxDatosMascota.Controls.Add(this.txtEspecie);
            this.gbxDatosMascota.Controls.Add(this.lblSexo);
            this.gbxDatosMascota.Controls.Add(this.lblFechaNacimiento);
            this.gbxDatosMascota.Controls.Add(this.txtNomMascota);
            this.gbxDatosMascota.Controls.Add(this.lblEspecie);
            this.gbxDatosMascota.Controls.Add(this.lblNomMascota);
            this.gbxDatosMascota.Location = new System.Drawing.Point(16, 8);
            this.gbxDatosMascota.Name = "gbxDatosMascota";
            this.gbxDatosMascota.Size = new System.Drawing.Size(880, 160);
            this.gbxDatosMascota.TabIndex = 23;
            this.gbxDatosMascota.TabStop = false;
            this.gbxDatosMascota.Text = "Datos Mascota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID Mascota";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(304, 112);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(160, 20);
            this.txtSexo.TabIndex = 20;
            // 
            // cbxIdMascota
            // 
            this.cbxIdMascota.FormattingEnabled = true;
            this.cbxIdMascota.Location = new System.Drawing.Point(32, 48);
            this.cbxIdMascota.Name = "cbxIdMascota";
            this.cbxIdMascota.Size = new System.Drawing.Size(160, 21);
            this.cbxIdMascota.TabIndex = 25;
            this.cbxIdMascota.SelectedIndexChanged += new System.EventHandler(this.cbxIdMascota_SelectedIndexChanged);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(576, 112);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.ReadOnly = true;
            this.txtFechaNacimiento.Size = new System.Drawing.Size(160, 20);
            this.txtFechaNacimiento.TabIndex = 22;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(32, 112);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.ReadOnly = true;
            this.txtRaza.Size = new System.Drawing.Size(160, 20);
            this.txtRaza.TabIndex = 19;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(32, 96);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(32, 13);
            this.lblRaza.TabIndex = 10;
            this.lblRaza.Text = "Raza";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(576, 48);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.ReadOnly = true;
            this.txtEspecie.Size = new System.Drawing.Size(160, 20);
            this.txtEspecie.TabIndex = 18;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(304, 96);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 11;
            this.lblSexo.Text = "Sexo";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(576, 96);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 12;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtNomMascota
            // 
            this.txtNomMascota.Location = new System.Drawing.Point(304, 48);
            this.txtNomMascota.Name = "txtNomMascota";
            this.txtNomMascota.ReadOnly = true;
            this.txtNomMascota.Size = new System.Drawing.Size(160, 20);
            this.txtNomMascota.TabIndex = 16;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(576, 32);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(89, 13);
            this.lblEspecie.TabIndex = 15;
            this.lblEspecie.Text = "Especie Mascota";
            // 
            // lblNomMascota
            // 
            this.lblNomMascota.AutoSize = true;
            this.lblNomMascota.Location = new System.Drawing.Point(304, 32);
            this.lblNomMascota.Name = "lblNomMascota";
            this.lblNomMascota.Size = new System.Drawing.Size(88, 13);
            this.lblNomMascota.TabIndex = 14;
            this.lblNomMascota.Text = "Nombre Mascota";
            // 
            // tapExpediente
            // 
            this.tapExpediente.Controls.Add(this.tabInformacionGeneral);
            this.tapExpediente.Controls.Add(this.tabHistorialMedico);
            this.tapExpediente.Location = new System.Drawing.Point(0, 72);
            this.tapExpediente.Name = "tapExpediente";
            this.tapExpediente.SelectedIndex = 0;
            this.tapExpediente.Size = new System.Drawing.Size(920, 472);
            this.tapExpediente.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Veterinaria Cat-Dog";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Veterinario - Expediente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(917, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // veterinarioExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 628);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIrCita);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tapExpediente);
            this.Name = "veterinarioExpediente";
            this.Text = "veterinarioExpediente";
            this.tabHistorialMedico.ResumeLayout(false);
            this.panelHM.ResumeLayout(false);
            this.panelHM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHVacunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHCitas)).EndInit();
            this.tabInformacionGeneral.ResumeLayout(false);
            this.gbxDatosDueno.ResumeLayout(false);
            this.gbxDatosDueno.PerformLayout();
            this.gbxDatosMascota.ResumeLayout(false);
            this.gbxDatosMascota.PerformLayout();
            this.tapExpediente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnIrCita;
        private System.Windows.Forms.TabPage tabHistorialMedico;
        private System.Windows.Forms.Panel panelHM;
        private System.Windows.Forms.Label lblHistorialCitas;
        private System.Windows.Forms.Label lblHistorialPaciente;
        private System.Windows.Forms.DataGridView dgvHVacunas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAplicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProximaDosis;
        private System.Windows.Forms.DataGridView dgvHPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cirugias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Examenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alergias;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicamentosActuales;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimaVacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaProximaVacuna;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvHCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCitaAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotivoConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sintomas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamenFisico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notas;
        private System.Windows.Forms.Label lblHistorialVacunas;
        private System.Windows.Forms.TabPage tabInformacionGeneral;
        private System.Windows.Forms.GroupBox gbxDatosDueno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccionDueno;
        private System.Windows.Forms.TextBox txtCorreoDueno;
        private System.Windows.Forms.TextBox txtNomDueno;
        private System.Windows.Forms.TextBox txtTelefonoDueno;
        private System.Windows.Forms.TextBox txtIdDuenoExp;
        private System.Windows.Forms.GroupBox gbxDatosMascota;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtNomMascota;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblNomMascota;
        private System.Windows.Forms.TabControl tapExpediente;
        private System.Windows.Forms.ComboBox cbxIdMascota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}