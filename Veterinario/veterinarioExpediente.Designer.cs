
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
            this.tabHistorialMedico = new System.Windows.Forms.TabPage();
            this.panelHM = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cirugias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Examenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alergias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicamentosActuales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimaVacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaProximaVacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvHM = new System.Windows.Forms.DataGridView();
            this.IdCitaAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotivoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sintomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamenFisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHistorialVacunas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabInformacionGeneral = new System.Windows.Forms.TabPage();
            this.gbxDatosDueno = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.gbxDatosMascota = new System.Windows.Forms.GroupBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtIdExpediente = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblIdMascota = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtIdMascota = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtNomMascota = new System.Windows.Forms.TextBox();
            this.lblIdExpediente = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblNomMascota = new System.Windows.Forms.Label();
            this.tapExpediente = new System.Windows.Forms.TabControl();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Vacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProximaDosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHistorialPaciente = new System.Windows.Forms.Label();
            this.lblHistorialCitas = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnIrCita = new System.Windows.Forms.Button();
            this.tabHistorialMedico.SuspendLayout();
            this.panelHM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHM)).BeginInit();
            this.tabInformacionGeneral.SuspendLayout();
            this.gbxDatosDueno.SuspendLayout();
            this.gbxDatosMascota.SuspendLayout();
            this.tapExpediente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabHistorialMedico
            // 
            this.tabHistorialMedico.Controls.Add(this.panelHM);
            this.tabHistorialMedico.Location = new System.Drawing.Point(4, 22);
            this.tabHistorialMedico.Name = "tabHistorialMedico";
            this.tabHistorialMedico.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorialMedico.Size = new System.Drawing.Size(906, 621);
            this.tabHistorialMedico.TabIndex = 2;
            this.tabHistorialMedico.Text = "Historial Medico";
            this.tabHistorialMedico.UseVisualStyleBackColor = true;
            // 
            // panelHM
            // 
            this.panelHM.AutoScroll = true;
            this.panelHM.Controls.Add(this.lblHistorialCitas);
            this.panelHM.Controls.Add(this.lblHistorialPaciente);
            this.panelHM.Controls.Add(this.dataGridView2);
            this.panelHM.Controls.Add(this.dataGridView1);
            this.panelHM.Controls.Add(this.dtpFecha);
            this.panelHM.Controls.Add(this.dgvHM);
            this.panelHM.Controls.Add(this.lblHistorialVacunas);
            this.panelHM.Controls.Add(this.label2);
            this.panelHM.Location = new System.Drawing.Point(0, 0);
            this.panelHM.Name = "panelHM";
            this.panelHM.Size = new System.Drawing.Size(900, 615);
            this.panelHM.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cirugias,
            this.Examenes,
            this.Alergias,
            this.MedicamentosActuales,
            this.UltimaVacuna,
            this.Fecha,
            this.FechaProximaVacuna});
            this.dataGridView1.Location = new System.Drawing.Point(12, 453);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 150);
            this.dataGridView1.TabIndex = 5;
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
            // dgvHM
            // 
            this.dgvHM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCitaAnterior,
            this.MotivoConsulta,
            this.Sintomas,
            this.ExamenFisico,
            this.Diagnostico,
            this.Tratamiento,
            this.Medicamentos,
            this.Notas});
            this.dgvHM.Location = new System.Drawing.Point(12, 203);
            this.dgvHM.Name = "dgvHM";
            this.dgvHM.Size = new System.Drawing.Size(848, 161);
            this.dgvHM.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // tabInformacionGeneral
            // 
            this.tabInformacionGeneral.Controls.Add(this.gbxDatosDueno);
            this.tabInformacionGeneral.Controls.Add(this.gbxDatosMascota);
            this.tabInformacionGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabInformacionGeneral.Name = "tabInformacionGeneral";
            this.tabInformacionGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabInformacionGeneral.Size = new System.Drawing.Size(906, 615);
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
            this.gbxDatosDueno.Controls.Add(this.textBox1);
            this.gbxDatosDueno.Controls.Add(this.textBox2);
            this.gbxDatosDueno.Controls.Add(this.textBox3);
            this.gbxDatosDueno.Controls.Add(this.textBox4);
            this.gbxDatosDueno.Controls.Add(this.textBox5);
            this.gbxDatosDueno.Location = new System.Drawing.Point(16, 23);
            this.gbxDatosDueno.Name = "gbxDatosDueno";
            this.gbxDatosDueno.Size = new System.Drawing.Size(856, 161);
            this.gbxDatosDueno.TabIndex = 24;
            this.gbxDatosDueno.TabStop = false;
            this.gbxDatosDueno.Text = "Datos Dueño";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Telefono";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(711, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Direccion";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(714, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(554, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 32;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(232, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 31;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(391, 91);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 30;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(69, 91);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 29;
            // 
            // gbxDatosMascota
            // 
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
            this.gbxDatosMascota.Location = new System.Drawing.Point(16, 237);
            this.gbxDatosMascota.Name = "gbxDatosMascota";
            this.gbxDatosMascota.Size = new System.Drawing.Size(856, 300);
            this.gbxDatosMascota.TabIndex = 23;
            this.gbxDatosMascota.TabStop = false;
            this.gbxDatosMascota.Text = "Datos Mascota";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(266, 231);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 20;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(599, 231);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.ReadOnly = true;
            this.txtFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNacimiento.TabIndex = 22;
            // 
            // txtIdExpediente
            // 
            this.txtIdExpediente.Location = new System.Drawing.Point(102, 78);
            this.txtIdExpediente.Name = "txtIdExpediente";
            this.txtIdExpediente.ReadOnly = true;
            this.txtIdExpediente.Size = new System.Drawing.Size(100, 20);
            this.txtIdExpediente.TabIndex = 0;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(444, 231);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 21;
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
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(441, 192);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 9;
            this.lblPeso.Text = "Peso";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(102, 231);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.ReadOnly = true;
            this.txtRaza.Size = new System.Drawing.Size(100, 20);
            this.txtRaza.TabIndex = 19;
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
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(599, 78);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.ReadOnly = true;
            this.txtEspecie.Size = new System.Drawing.Size(100, 20);
            this.txtEspecie.TabIndex = 18;
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
            // txtIdMascota
            // 
            this.txtIdMascota.Location = new System.Drawing.Point(265, 78);
            this.txtIdMascota.Name = "txtIdMascota";
            this.txtIdMascota.ReadOnly = true;
            this.txtIdMascota.Size = new System.Drawing.Size(100, 20);
            this.txtIdMascota.TabIndex = 17;
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
            // txtNomMascota
            // 
            this.txtNomMascota.Location = new System.Drawing.Point(424, 78);
            this.txtNomMascota.Name = "txtNomMascota";
            this.txtNomMascota.ReadOnly = true;
            this.txtNomMascota.Size = new System.Drawing.Size(100, 20);
            this.txtNomMascota.TabIndex = 16;
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
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(596, 40);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(89, 13);
            this.lblEspecie.TabIndex = 15;
            this.lblEspecie.Text = "Especie Mascota";
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
            // tapExpediente
            // 
            this.tapExpediente.Controls.Add(this.tabInformacionGeneral);
            this.tapExpediente.Controls.Add(this.tabHistorialMedico);
            this.tapExpediente.Location = new System.Drawing.Point(1, 12);
            this.tapExpediente.Name = "tapExpediente";
            this.tapExpediente.SelectedIndex = 0;
            this.tapExpediente.Size = new System.Drawing.Size(914, 641);
            this.tapExpediente.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vacuna,
            this.FechaAplicacion,
            this.Motivo,
            this.ProximaDosis});
            this.dataGridView2.Location = new System.Drawing.Point(12, 728);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(848, 150);
            this.dataGridView2.TabIndex = 6;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHM)).EndInit();
            this.tabInformacionGeneral.ResumeLayout(false);
            this.gbxDatosDueno.ResumeLayout(false);
            this.gbxDatosDueno.PerformLayout();
            this.gbxDatosMascota.ResumeLayout(false);
            this.gbxDatosMascota.PerformLayout();
            this.tapExpediente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabHistorialMedico;
        private System.Windows.Forms.Panel panelHM;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cirugias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Examenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alergias;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicamentosActuales;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimaVacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaProximaVacuna;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvHM;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCitaAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotivoConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sintomas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamenFisico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notas;
        private System.Windows.Forms.Label lblHistorialVacunas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabInformacionGeneral;
        private System.Windows.Forms.GroupBox gbxDatosDueno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox gbxDatosMascota;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAplicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProximaDosis;
        private System.Windows.Forms.Label lblHistorialCitas;
        private System.Windows.Forms.Label lblHistorialPaciente;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnIrCita;
    }
}