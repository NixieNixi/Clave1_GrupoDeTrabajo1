
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
            this.dgvHExamenes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotivoExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHistorialExamenes = new System.Windows.Forms.Label();
            this.lblHistorialCitas = new System.Windows.Forms.Label();
            this.lblHistorialCirugias = new System.Windows.Forms.Label();
            this.dgvHVacunas = new System.Windows.Forms.DataGridView();
            this.Vacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotivoVacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHCirugia = new System.Windows.Forms.DataGridView();
            this.IdCirugia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraCirugia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCirugia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCirugia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotivoCirugia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvHCitas = new System.Windows.Forms.DataGridView();
            this.idCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sintomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamenFisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHistorialVacunas = new System.Windows.Forms.Label();
            this.tabInformacionGeneral = new System.Windows.Forms.TabPage();
            this.gbxDatosDueno = new System.Windows.Forms.GroupBox();
            this.lblNomDueno = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblIdDueno = new System.Windows.Forms.Label();
            this.txtDireccionDueno = new System.Windows.Forms.TextBox();
            this.txtCorreoDueno = new System.Windows.Forms.TextBox();
            this.txtNomDueno = new System.Windows.Forms.TextBox();
            this.txtTelefonoDueno = new System.Windows.Forms.TextBox();
            this.txtIdDuenoExp = new System.Windows.Forms.TextBox();
            this.gbxDatosMascota = new System.Windows.Forms.GroupBox();
            this.lblIdMascota = new System.Windows.Forms.Label();
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
            this.panelBotonesExp = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVeterinarioPerfil = new System.Windows.Forms.Label();
            this.tabHistorialMedico.SuspendLayout();
            this.panelHM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHExamenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHVacunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHCirugia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHCitas)).BeginInit();
            this.tabInformacionGeneral.SuspendLayout();
            this.gbxDatosDueno.SuspendLayout();
            this.gbxDatosMascota.SuspendLayout();
            this.tapExpediente.SuspendLayout();
            this.panelBotonesExp.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(34, 11);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(327, 79);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnIrCita
            // 
            this.btnIrCita.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIrCita.ForeColor = System.Drawing.Color.White;
            this.btnIrCita.Location = new System.Drawing.Point(544, 11);
            this.btnIrCita.Name = "btnIrCita";
            this.btnIrCita.Size = new System.Drawing.Size(327, 79);
            this.btnIrCita.TabIndex = 2;
            this.btnIrCita.Text = "Ir Cita";
            this.btnIrCita.UseVisualStyleBackColor = false;
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
            this.panelHM.Controls.Add(this.dgvHExamenes);
            this.panelHM.Controls.Add(this.lblHistorialExamenes);
            this.panelHM.Controls.Add(this.lblHistorialCitas);
            this.panelHM.Controls.Add(this.lblHistorialCirugias);
            this.panelHM.Controls.Add(this.dgvHVacunas);
            this.panelHM.Controls.Add(this.dgvHCirugia);
            this.panelHM.Controls.Add(this.dtpFecha);
            this.panelHM.Controls.Add(this.dgvHCitas);
            this.panelHM.Controls.Add(this.lblHistorialVacunas);
            this.panelHM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHM.Location = new System.Drawing.Point(3, 3);
            this.panelHM.Name = "panelHM";
            this.panelHM.Size = new System.Drawing.Size(906, 440);
            this.panelHM.TabIndex = 1;
            // 
            // dgvHExamenes
            // 
            this.dgvHExamenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHExamenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.TipoExamen,
            this.MotivoExamen});
            this.dgvHExamenes.Location = new System.Drawing.Point(12, 1005);
            this.dgvHExamenes.Name = "dgvHExamenes";
            this.dgvHExamenes.Size = new System.Drawing.Size(848, 150);
            this.dgvHExamenes.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Vacuna";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha de Aplicacion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // TipoExamen
            // 
            this.TipoExamen.HeaderText = "Tipo Examen";
            this.TipoExamen.Name = "TipoExamen";
            this.TipoExamen.ReadOnly = true;
            // 
            // MotivoExamen
            // 
            this.MotivoExamen.HeaderText = "Motivo Examen";
            this.MotivoExamen.Name = "MotivoExamen";
            this.MotivoExamen.ReadOnly = true;
            // 
            // lblHistorialExamenes
            // 
            this.lblHistorialExamenes.AutoSize = true;
            this.lblHistorialExamenes.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialExamenes.Location = new System.Drawing.Point(332, 951);
            this.lblHistorialExamenes.Name = "lblHistorialExamenes";
            this.lblHistorialExamenes.Size = new System.Drawing.Size(228, 27);
            this.lblHistorialExamenes.TabIndex = 9;
            this.lblHistorialExamenes.Text = "Historial de Examenes";
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
            // lblHistorialCirugias
            // 
            this.lblHistorialCirugias.AutoSize = true;
            this.lblHistorialCirugias.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialCirugias.Location = new System.Drawing.Point(332, 406);
            this.lblHistorialCirugias.Name = "lblHistorialCirugias";
            this.lblHistorialCirugias.Size = new System.Drawing.Size(210, 27);
            this.lblHistorialCirugias.TabIndex = 7;
            this.lblHistorialCirugias.Text = "Historial de Cirugias";
            // 
            // dgvHVacunas
            // 
            this.dgvHVacunas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHVacunas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vacuna,
            this.FechaAplicacion,
            this.TipoVacuna,
            this.MotivoVacuna});
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
            // TipoVacuna
            // 
            this.TipoVacuna.HeaderText = "Tipo Vacuna";
            this.TipoVacuna.Name = "TipoVacuna";
            this.TipoVacuna.ReadOnly = true;
            // 
            // MotivoVacuna
            // 
            this.MotivoVacuna.HeaderText = "Motivo Vacuna";
            this.MotivoVacuna.Name = "MotivoVacuna";
            this.MotivoVacuna.ReadOnly = true;
            // 
            // dgvHCirugia
            // 
            this.dgvHCirugia.AllowUserToDeleteRows = false;
            this.dgvHCirugia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHCirugia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHCirugia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCirugia,
            this.FechaHoraCirugia,
            this.TipoCirugia,
            this.DescripcionCirugia,
            this.MotivoCirugia});
            this.dgvHCirugia.Location = new System.Drawing.Point(12, 453);
            this.dgvHCirugia.Name = "dgvHCirugia";
            this.dgvHCirugia.Size = new System.Drawing.Size(848, 150);
            this.dgvHCirugia.TabIndex = 5;
            // 
            // IdCirugia
            // 
            this.IdCirugia.HeaderText = "ID Cirugia";
            this.IdCirugia.Name = "IdCirugia";
            this.IdCirugia.ReadOnly = true;
            // 
            // FechaHoraCirugia
            // 
            this.FechaHoraCirugia.HeaderText = "Fecha y Hora";
            this.FechaHoraCirugia.Name = "FechaHoraCirugia";
            this.FechaHoraCirugia.ReadOnly = true;
            // 
            // TipoCirugia
            // 
            this.TipoCirugia.HeaderText = "Tipo de Cirugia";
            this.TipoCirugia.Name = "TipoCirugia";
            this.TipoCirugia.ReadOnly = true;
            // 
            // DescripcionCirugia
            // 
            this.DescripcionCirugia.HeaderText = "Descripcion de Cirugia";
            this.DescripcionCirugia.Name = "DescripcionCirugia";
            this.DescripcionCirugia.ReadOnly = true;
            // 
            // MotivoCirugia
            // 
            this.MotivoCirugia.HeaderText = "Motivo de Cirugia";
            this.MotivoCirugia.Name = "MotivoCirugia";
            this.MotivoCirugia.ReadOnly = true;
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
            this.idCita,
            this.FechaHora,
            this.Motivo,
            this.Sintomas,
            this.ExamenFisico,
            this.Diagnostico,
            this.Tratamiento,
            this.Medicamentos,
            this.Notas});
            this.dgvHCitas.Location = new System.Drawing.Point(3, 203);
            this.dgvHCitas.Name = "dgvHCitas";
            this.dgvHCitas.ReadOnly = true;
            this.dgvHCitas.Size = new System.Drawing.Size(877, 161);
            this.dgvHCitas.TabIndex = 3;
            // 
            // idCita
            // 
            this.idCita.HeaderText = "ID Cita Anterior";
            this.idCita.Name = "idCita";
            this.idCita.ReadOnly = true;
            // 
            // FechaHora
            // 
            this.FechaHora.HeaderText = "Fecha y Hora";
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.ReadOnly = true;
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo Consulta";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            // 
            // Sintomas
            // 
            this.Sintomas.HeaderText = "Sintomas";
            this.Sintomas.Name = "Sintomas";
            this.Sintomas.ReadOnly = true;
            // 
            // ExamenFisico
            // 
            this.ExamenFisico.HeaderText = "Examen Fisico";
            this.ExamenFisico.Name = "ExamenFisico";
            this.ExamenFisico.ReadOnly = true;
            // 
            // Diagnostico
            // 
            this.Diagnostico.HeaderText = "Diagnostico";
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.ReadOnly = true;
            // 
            // Tratamiento
            // 
            this.Tratamiento.HeaderText = "Tratamiento";
            this.Tratamiento.Name = "Tratamiento";
            this.Tratamiento.ReadOnly = true;
            // 
            // Medicamentos
            // 
            this.Medicamentos.HeaderText = "Medicamentos";
            this.Medicamentos.Name = "Medicamentos";
            this.Medicamentos.ReadOnly = true;
            // 
            // Notas
            // 
            this.Notas.HeaderText = "Notas";
            this.Notas.Name = "Notas";
            this.Notas.ReadOnly = true;
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
            this.gbxDatosDueno.Controls.Add(this.lblNomDueno);
            this.gbxDatosDueno.Controls.Add(this.lblTelefono);
            this.gbxDatosDueno.Controls.Add(this.lblCorreo);
            this.gbxDatosDueno.Controls.Add(this.lblDireccion);
            this.gbxDatosDueno.Controls.Add(this.lblIdDueno);
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
            // lblNomDueno
            // 
            this.lblNomDueno.AutoSize = true;
            this.lblNomDueno.Location = new System.Drawing.Point(304, 32);
            this.lblNomDueno.Name = "lblNomDueno";
            this.lblNomDueno.Size = new System.Drawing.Size(79, 13);
            this.lblNomDueno.TabIndex = 38;
            this.lblNomDueno.Text = "Nombre Dueño";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(576, 32);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 37;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(32, 96);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 36;
            this.lblCorreo.Text = "Correo";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(32, 160);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 35;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblIdDueno
            // 
            this.lblIdDueno.AutoSize = true;
            this.lblIdDueno.Location = new System.Drawing.Point(32, 32);
            this.lblIdDueno.Name = "lblIdDueno";
            this.lblIdDueno.Size = new System.Drawing.Size(53, 13);
            this.lblIdDueno.TabIndex = 34;
            this.lblIdDueno.Text = "ID Dueño";
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
            this.gbxDatosMascota.Controls.Add(this.lblIdMascota);
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
            // lblIdMascota
            // 
            this.lblIdMascota.AutoSize = true;
            this.lblIdMascota.Location = new System.Drawing.Point(32, 32);
            this.lblIdMascota.Name = "lblIdMascota";
            this.lblIdMascota.Size = new System.Drawing.Size(62, 13);
            this.lblIdMascota.TabIndex = 38;
            this.lblIdMascota.Text = "ID Mascota";
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
            this.tapExpediente.Location = new System.Drawing.Point(0, 80);
            this.tapExpediente.Name = "tapExpediente";
            this.tapExpediente.SelectedIndex = 0;
            this.tapExpediente.Size = new System.Drawing.Size(920, 472);
            this.tapExpediente.TabIndex = 0;
            // 
            // panelBotonesExp
            // 
            this.panelBotonesExp.BackColor = System.Drawing.Color.LightBlue;
            this.panelBotonesExp.Controls.Add(this.btnVolver);
            this.panelBotonesExp.Controls.Add(this.btnIrCita);
            this.panelBotonesExp.Location = new System.Drawing.Point(0, 543);
            this.panelBotonesExp.Name = "panelBotonesExp";
            this.panelBotonesExp.Size = new System.Drawing.Size(906, 118);
            this.panelBotonesExp.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblVeterinarioPerfil);
            this.panel2.Location = new System.Drawing.Point(-21, -17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 91);
            this.panel2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(34, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "> Expediente Veterinario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Veterinaria Cat-Dog";
            // 
            // lblVeterinarioPerfil
            // 
            this.lblVeterinarioPerfil.AutoSize = true;
            this.lblVeterinarioPerfil.BackColor = System.Drawing.Color.Teal;
            this.lblVeterinarioPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeterinarioPerfil.ForeColor = System.Drawing.Color.White;
            this.lblVeterinarioPerfil.Location = new System.Drawing.Point(32, 40);
            this.lblVeterinarioPerfil.Name = "lblVeterinarioPerfil";
            this.lblVeterinarioPerfil.Size = new System.Drawing.Size(141, 29);
            this.lblVeterinarioPerfil.TabIndex = 1;
            this.lblVeterinarioPerfil.Text = "Veterinario";
            // 
            // veterinarioExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBotonesExp);
            this.Controls.Add(this.tapExpediente);
            this.Name = "veterinarioExpediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expediente Veterinario";
            this.tabHistorialMedico.ResumeLayout(false);
            this.panelHM.ResumeLayout(false);
            this.panelHM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHExamenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHVacunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHCirugia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHCitas)).EndInit();
            this.tabInformacionGeneral.ResumeLayout(false);
            this.gbxDatosDueno.ResumeLayout(false);
            this.gbxDatosDueno.PerformLayout();
            this.gbxDatosMascota.ResumeLayout(false);
            this.gbxDatosMascota.PerformLayout();
            this.tapExpediente.ResumeLayout(false);
            this.panelBotonesExp.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnIrCita;
        private System.Windows.Forms.TabPage tabHistorialMedico;
        private System.Windows.Forms.Panel panelHM;
        private System.Windows.Forms.Label lblHistorialCitas;
        private System.Windows.Forms.Label lblHistorialCirugias;
        private System.Windows.Forms.DataGridView dgvHVacunas;
        private System.Windows.Forms.DataGridView dgvHCirugia;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblHistorialVacunas;
        private System.Windows.Forms.TabPage tabInformacionGeneral;
        private System.Windows.Forms.GroupBox gbxDatosDueno;
        private System.Windows.Forms.Label lblNomDueno;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblIdDueno;
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
        private System.Windows.Forms.Label lblIdMascota;
        private System.Windows.Forms.DataGridView dgvHCitas;
        private System.Windows.Forms.DataGridView dgvHExamenes;
        private System.Windows.Forms.Label lblHistorialExamenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sintomas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamenFisico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCirugia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraCirugia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCirugia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCirugia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotivoCirugia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAplicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotivoVacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotivoExamen;
        private System.Windows.Forms.Panel panelBotonesExp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVeterinarioPerfil;
    }
}