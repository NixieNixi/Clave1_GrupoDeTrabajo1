
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
            this.lblHistorialVacunas = new System.Windows.Forms.Label();
            this.dgvHCitas = new System.Windows.Forms.DataGridView();
            this.Notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamenFisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sintomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotivoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCitaAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvHPaciente = new System.Windows.Forms.DataGridView();
            this.FechaProximaVacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimaVacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicamentosActuales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alergias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Examenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cirugias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHVacunas = new System.Windows.Forms.DataGridView();
            this.ProximaDosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHistorialPaciente = new System.Windows.Forms.Label();
            this.lblHistorialCitas = new System.Windows.Forms.Label();
            this.tabInformacionGeneral = new System.Windows.Forms.TabPage();
            this.gbxDatosMascota = new System.Windows.Forms.GroupBox();
            this.lblNomMascota = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblIdExpediente = new System.Windows.Forms.Label();
            this.txtNomMascota = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtIdMascota = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblIdMascota = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtIdExpediente = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.cbxIdExpedienteMascota = new System.Windows.Forms.ComboBox();
            this.gbxDatosDueno = new System.Windows.Forms.GroupBox();
            this.txtIdDuenoExp = new System.Windows.Forms.TextBox();
            this.txtTelefonoDueno = new System.Windows.Forms.TextBox();
            this.txtNomDueno = new System.Windows.Forms.TextBox();
            this.txtCorreoDueno = new System.Windows.Forms.TextBox();
            this.txtDireccionDueno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tapExpediente = new System.Windows.Forms.TabControl();
            this.cbxIdMascota = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabHistorialMedico.SuspendLayout();
            this.panelHM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHVacunas)).BeginInit();
            this.tabInformacionGeneral.SuspendLayout();
            this.gbxDatosMascota.SuspendLayout();
            this.gbxDatosDueno.SuspendLayout();
            this.tapExpediente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(126, 659);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(125, 49);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnIrCita
            // 
            this.btnIrCita.Location = new System.Drawing.Point(560, 659);
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
            this.tabHistorialMedico.Size = new System.Drawing.Size(912, 630);
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
            this.panelHM.Location = new System.Drawing.Point(0, 0);
            this.panelHM.Name = "panelHM";
            this.panelHM.Size = new System.Drawing.Size(912, 616);
            this.panelHM.TabIndex = 1;
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
            // Notas
            // 
            this.Notas.HeaderText = "Notas";
            this.Notas.Name = "Notas";
            // 
            // Medicamentos
            // 
            this.Medicamentos.HeaderText = "Medicamentos";
            this.Medicamentos.Name = "Medicamentos";
            // 
            // Tratamiento
            // 
            this.Tratamiento.HeaderText = "Traramiento";
            this.Tratamiento.Name = "Tratamiento";
            // 
            // Diagnostico
            // 
            this.Diagnostico.HeaderText = "Diagnostico";
            this.Diagnostico.Name = "Diagnostico";
            // 
            // ExamenFisico
            // 
            this.ExamenFisico.HeaderText = "Examen Fisico";
            this.ExamenFisico.Name = "ExamenFisico";
            // 
            // Sintomas
            // 
            this.Sintomas.HeaderText = "Sintomas";
            this.Sintomas.Name = "Sintomas";
            // 
            // MotivoConsulta
            // 
            this.MotivoConsulta.HeaderText = "Motivo Consulta";
            this.MotivoConsulta.Name = "MotivoConsulta";
            // 
            // IdCitaAnterior
            // 
            this.IdCitaAnterior.HeaderText = "ID Cita Anterior";
            this.IdCitaAnterior.Name = "IdCitaAnterior";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(680, 13);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 4;
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
            // FechaProximaVacuna
            // 
            this.FechaProximaVacuna.HeaderText = "Fecha Proxima Vacuna";
            this.FechaProximaVacuna.Name = "FechaProximaVacuna";
            this.FechaProximaVacuna.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // UltimaVacuna
            // 
            this.UltimaVacuna.HeaderText = "Ultima Vacuna";
            this.UltimaVacuna.Name = "UltimaVacuna";
            this.UltimaVacuna.ReadOnly = true;
            // 
            // MedicamentosActuales
            // 
            this.MedicamentosActuales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicamentosActuales.HeaderText = "Medicamentos Actuales";
            this.MedicamentosActuales.Name = "MedicamentosActuales";
            // 
            // Alergias
            // 
            this.Alergias.HeaderText = "Alergias";
            this.Alergias.Name = "Alergias";
            // 
            // Examenes
            // 
            this.Examenes.HeaderText = "Examenes";
            this.Examenes.Name = "Examenes";
            // 
            // Cirugias
            // 
            this.Cirugias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cirugias.HeaderText = "Cirugias";
            this.Cirugias.Name = "Cirugias";
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
            // ProximaDosis
            // 
            this.ProximaDosis.HeaderText = "Proxima Dosis";
            this.ProximaDosis.Name = "ProximaDosis";
            this.ProximaDosis.ReadOnly = true;
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            // 
            // FechaAplicacion
            // 
            this.FechaAplicacion.HeaderText = "Fecha de Aplicacion";
            this.FechaAplicacion.Name = "FechaAplicacion";
            this.FechaAplicacion.ReadOnly = true;
            // 
            // Vacuna
            // 
            this.Vacuna.HeaderText = "Vacuna";
            this.Vacuna.Name = "Vacuna";
            this.Vacuna.ReadOnly = true;
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
            // tabInformacionGeneral
            // 
            this.tabInformacionGeneral.Controls.Add(this.label1);
            this.tabInformacionGeneral.Controls.Add(this.cbxIdMascota);
            this.tabInformacionGeneral.Controls.Add(this.gbxDatosDueno);
            this.tabInformacionGeneral.Controls.Add(this.gbxDatosMascota);
            this.tabInformacionGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabInformacionGeneral.Name = "tabInformacionGeneral";
            this.tabInformacionGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabInformacionGeneral.Size = new System.Drawing.Size(912, 630);
            this.tabInformacionGeneral.TabIndex = 0;
            this.tabInformacionGeneral.Text = "Informacion General";
            this.tabInformacionGeneral.UseVisualStyleBackColor = true;
            // 
            // gbxDatosMascota
            // 
            this.gbxDatosMascota.Controls.Add(this.cbxIdExpedienteMascota);
            this.gbxDatosMascota.Controls.Add(this.txtSexo);
            this.gbxDatosMascota.Controls.Add(this.txtFechaNacimiento);
            this.gbxDatosMascota.Controls.Add(this.txtIdExpediente);
            this.gbxDatosMascota.Controls.Add(this.txtPeso);
            this.gbxDatosMascota.Controls.Add(this.lblIdMascota);
            this.gbxDatosMascota.Controls.Add(this.lblPeso);
            this.gbxDatosMascota.Controls.Add(this.txtRaza);
            this.gbxDatosMascota.Controls.Add(this.lblRaza);
            this.gbxDatosMascota.Controls.Add(this.txtEspecie);
            this.gbxDatosMascota.Controls.Add(this.lblSexo);
            this.gbxDatosMascota.Controls.Add(this.txtIdMascota);
            this.gbxDatosMascota.Controls.Add(this.lblFechaNacimiento);
            this.gbxDatosMascota.Controls.Add(this.txtNomMascota);
            this.gbxDatosMascota.Controls.Add(this.lblIdExpediente);
            this.gbxDatosMascota.Controls.Add(this.lblEspecie);
            this.gbxDatosMascota.Controls.Add(this.lblNomMascota);
            this.gbxDatosMascota.Location = new System.Drawing.Point(16, 288);
            this.gbxDatosMascota.Name = "gbxDatosMascota";
            this.gbxDatosMascota.Size = new System.Drawing.Size(880, 300);
            this.gbxDatosMascota.TabIndex = 23;
            this.gbxDatosMascota.TabStop = false;
            this.gbxDatosMascota.Text = "Datos Mascota";
            // 
            // lblNomMascota
            // 
            this.lblNomMascota.AutoSize = true;
            this.lblNomMascota.Location = new System.Drawing.Point(421, 40);
            this.lblNomMascota.Name = "lblNomMascota";
            this.lblNomMascota.Size = new System.Drawing.Size(88, 13);
            this.lblNomMascota.TabIndex = 14;
            this.lblNomMascota.Text = "Nombre Mascota";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(596, 40);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(89, 13);
            this.lblEspecie.TabIndex = 15;
            this.lblEspecie.Text = "Especie Mascota";
            // 
            // lblIdExpediente
            // 
            this.lblIdExpediente.AutoSize = true;
            this.lblIdExpediente.Location = new System.Drawing.Point(101, 39);
            this.lblIdExpediente.Name = "lblIdExpediente";
            this.lblIdExpediente.Size = new System.Drawing.Size(74, 13);
            this.lblIdExpediente.TabIndex = 13;
            this.lblIdExpediente.Text = "ID Expediente";
            // 
            // txtNomMascota
            // 
            this.txtNomMascota.Location = new System.Drawing.Point(424, 78);
            this.txtNomMascota.Name = "txtNomMascota";
            this.txtNomMascota.ReadOnly = true;
            this.txtNomMascota.Size = new System.Drawing.Size(100, 20);
            this.txtNomMascota.TabIndex = 16;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(596, 192);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 12;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtIdMascota
            // 
            this.txtIdMascota.Location = new System.Drawing.Point(265, 78);
            this.txtIdMascota.Name = "txtIdMascota";
            this.txtIdMascota.ReadOnly = true;
            this.txtIdMascota.Size = new System.Drawing.Size(100, 20);
            this.txtIdMascota.TabIndex = 17;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(263, 192);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 11;
            this.lblSexo.Text = "Sexo";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(599, 78);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.ReadOnly = true;
            this.txtEspecie.Size = new System.Drawing.Size(100, 20);
            this.txtEspecie.TabIndex = 18;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(102, 192);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(32, 13);
            this.lblRaza.TabIndex = 10;
            this.lblRaza.Text = "Raza";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(102, 231);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.ReadOnly = true;
            this.txtRaza.Size = new System.Drawing.Size(100, 20);
            this.txtRaza.TabIndex = 19;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(441, 192);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 9;
            this.lblPeso.Text = "Peso";
            // 
            // lblIdMascota
            // 
            this.lblIdMascota.AutoSize = true;
            this.lblIdMascota.Location = new System.Drawing.Point(262, 39);
            this.lblIdMascota.Name = "lblIdMascota";
            this.lblIdMascota.Size = new System.Drawing.Size(62, 13);
            this.lblIdMascota.TabIndex = 8;
            this.lblIdMascota.Text = "ID Mascota";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(444, 231);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 21;
            // 
            // txtIdExpediente
            // 
            this.txtIdExpediente.Location = new System.Drawing.Point(382, 142);
            this.txtIdExpediente.Name = "txtIdExpediente";
            this.txtIdExpediente.ReadOnly = true;
            this.txtIdExpediente.Size = new System.Drawing.Size(100, 20);
            this.txtIdExpediente.TabIndex = 0;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(599, 231);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.ReadOnly = true;
            this.txtFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNacimiento.TabIndex = 22;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(266, 231);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 20;
            // 
            // cbxIdExpedienteMascota
            // 
            this.cbxIdExpedienteMascota.FormattingEnabled = true;
            this.cbxIdExpedienteMascota.Location = new System.Drawing.Point(91, 78);
            this.cbxIdExpedienteMascota.Name = "cbxIdExpedienteMascota";
            this.cbxIdExpedienteMascota.Size = new System.Drawing.Size(121, 21);
            this.cbxIdExpedienteMascota.TabIndex = 23;
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
            this.gbxDatosDueno.Location = new System.Drawing.Point(16, 112);
            this.gbxDatosDueno.Name = "gbxDatosDueno";
            this.gbxDatosDueno.Size = new System.Drawing.Size(880, 161);
            this.gbxDatosDueno.TabIndex = 24;
            this.gbxDatosDueno.TabStop = false;
            this.gbxDatosDueno.Text = "Datos Dueño";
            // 
            // txtIdDuenoExp
            // 
            this.txtIdDuenoExp.Location = new System.Drawing.Point(69, 91);
            this.txtIdDuenoExp.Name = "txtIdDuenoExp";
            this.txtIdDuenoExp.ReadOnly = true;
            this.txtIdDuenoExp.Size = new System.Drawing.Size(100, 20);
            this.txtIdDuenoExp.TabIndex = 29;
            // 
            // txtTelefonoDueno
            // 
            this.txtTelefonoDueno.Location = new System.Drawing.Point(391, 91);
            this.txtTelefonoDueno.Name = "txtTelefonoDueno";
            this.txtTelefonoDueno.ReadOnly = true;
            this.txtTelefonoDueno.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoDueno.TabIndex = 30;
            // 
            // txtNomDueno
            // 
            this.txtNomDueno.Location = new System.Drawing.Point(232, 91);
            this.txtNomDueno.Name = "txtNomDueno";
            this.txtNomDueno.ReadOnly = true;
            this.txtNomDueno.Size = new System.Drawing.Size(100, 20);
            this.txtNomDueno.TabIndex = 31;
            // 
            // txtCorreoDueno
            // 
            this.txtCorreoDueno.Location = new System.Drawing.Point(554, 91);
            this.txtCorreoDueno.Name = "txtCorreoDueno";
            this.txtCorreoDueno.ReadOnly = true;
            this.txtCorreoDueno.Size = new System.Drawing.Size(100, 20);
            this.txtCorreoDueno.TabIndex = 32;
            // 
            // txtDireccionDueno
            // 
            this.txtDireccionDueno.Location = new System.Drawing.Point(714, 91);
            this.txtDireccionDueno.Name = "txtDireccionDueno";
            this.txtDireccionDueno.ReadOnly = true;
            this.txtDireccionDueno.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionDueno.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "ID Dueño";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(711, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nombre Dueño";
            // 
            // tapExpediente
            // 
            this.tapExpediente.Controls.Add(this.tabInformacionGeneral);
            this.tapExpediente.Controls.Add(this.tabHistorialMedico);
            this.tapExpediente.Location = new System.Drawing.Point(0, 0);
            this.tapExpediente.Name = "tapExpediente";
            this.tapExpediente.SelectedIndex = 0;
            this.tapExpediente.Size = new System.Drawing.Size(920, 656);
            this.tapExpediente.TabIndex = 0;
            // 
            // cbxIdMascota
            // 
            this.cbxIdMascota.FormattingEnabled = true;
            this.cbxIdMascota.Location = new System.Drawing.Point(32, 56);
            this.cbxIdMascota.Name = "cbxIdMascota";
            this.cbxIdMascota.Size = new System.Drawing.Size(121, 21);
            this.cbxIdMascota.TabIndex = 25;
            this.cbxIdMascota.SelectedIndexChanged += new System.EventHandler(this.cbxIdMascota_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID Mascota";
            // 
            // veterinarioExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 724);
            this.Controls.Add(this.btnIrCita);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tapExpediente);
            this.Name = "veterinarioExpediente";
            this.Text = "veterinarioExpediente";
            this.tabHistorialMedico.ResumeLayout(false);
            this.panelHM.ResumeLayout(false);
            this.panelHM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHVacunas)).EndInit();
            this.tabInformacionGeneral.ResumeLayout(false);
            this.tabInformacionGeneral.PerformLayout();
            this.gbxDatosMascota.ResumeLayout(false);
            this.gbxDatosMascota.PerformLayout();
            this.gbxDatosDueno.ResumeLayout(false);
            this.gbxDatosDueno.PerformLayout();
            this.tapExpediente.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox cbxIdExpedienteMascota;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtIdExpediente;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblIdMascota;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtIdMascota;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtNomMascota;
        private System.Windows.Forms.Label lblIdExpediente;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblNomMascota;
        private System.Windows.Forms.TabControl tapExpediente;
        private System.Windows.Forms.ComboBox cbxIdMascota;
        private System.Windows.Forms.Label label1;
    }
}