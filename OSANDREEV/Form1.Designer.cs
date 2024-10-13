namespace OSANDREEV
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.dgvColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnCommandsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnCurrentCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.power = new System.Windows.Forms.Button();
            this.addTask = new System.Windows.Forms.Button();
            this.numberOfCommands = new System.Windows.Forms.TextBox();
            this.memory = new System.Windows.Forms.TextBox();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.numberOfCommandsLabel = new System.Windows.Forms.Label();
            this.speed_OS = new System.Windows.Forms.Label();
            this.speedOS = new System.Windows.Forms.TextBox();
            this.CPU1_Label = new System.Windows.Forms.Label();
            this.CPU2_Label = new System.Windows.Forms.Label();
            this.CPU3_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addTaskAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnId,
            this.dgvColumnMemory,
            this.dgvColumnCommandsNumber,
            this.dgvColumnCurrentCommand,
            this.dgvColumnStatus});
            this.dataGridViewTasks.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewTasks.Location = new System.Drawing.Point(633, 0);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTasks.Size = new System.Drawing.Size(494, 643);
            this.dataGridViewTasks.TabIndex = 0;
            // 
            // dgvColumnId
            // 
            this.dgvColumnId.HeaderText = "Id";
            this.dgvColumnId.Name = "dgvColumnId";
            this.dgvColumnId.ReadOnly = true;
            // 
            // dgvColumnMemory
            // 
            this.dgvColumnMemory.HeaderText = "Memory";
            this.dgvColumnMemory.Name = "dgvColumnMemory";
            this.dgvColumnMemory.ReadOnly = true;
            // 
            // dgvColumnCommandsNumber
            // 
            this.dgvColumnCommandsNumber.HeaderText = "Commands Number";
            this.dgvColumnCommandsNumber.Name = "dgvColumnCommandsNumber";
            this.dgvColumnCommandsNumber.ReadOnly = true;
            // 
            // dgvColumnCurrentCommand
            // 
            this.dgvColumnCurrentCommand.HeaderText = "Current Command";
            this.dgvColumnCurrentCommand.Name = "dgvColumnCurrentCommand";
            this.dgvColumnCurrentCommand.ReadOnly = true;
            // 
            // dgvColumnStatus
            // 
            this.dgvColumnStatus.HeaderText = "Status";
            this.dgvColumnStatus.Name = "dgvColumnStatus";
            this.dgvColumnStatus.ReadOnly = true;
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(12, 12);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(75, 23);
            this.power.TabIndex = 1;
            this.power.Text = "Power";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // addTask
            // 
            this.addTask.Location = new System.Drawing.Point(12, 73);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(75, 23);
            this.addTask.TabIndex = 2;
            this.addTask.Text = "Add Task";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // numberOfCommands
            // 
            this.numberOfCommands.Location = new System.Drawing.Point(77, 135);
            this.numberOfCommands.Name = "numberOfCommands";
            this.numberOfCommands.Size = new System.Drawing.Size(100, 20);
            this.numberOfCommands.TabIndex = 3;
            this.numberOfCommands.Text = "100";
            this.numberOfCommands.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfCommands_KeyPress);
            // 
            // memory
            // 
            this.memory.Location = new System.Drawing.Point(77, 104);
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(100, 20);
            this.memory.TabIndex = 4;
            this.memory.Text = "100";
            this.memory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.memory_KeyPress);
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Location = new System.Drawing.Point(12, 107);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(44, 13);
            this.memoryLabel.TabIndex = 5;
            this.memoryLabel.Text = "Memory";
            // 
            // numberOfCommandsLabel
            // 
            this.numberOfCommandsLabel.AutoSize = true;
            this.numberOfCommandsLabel.Location = new System.Drawing.Point(12, 138);
            this.numberOfCommandsLabel.Name = "numberOfCommandsLabel";
            this.numberOfCommandsLabel.Size = new System.Drawing.Size(59, 13);
            this.numberOfCommandsLabel.TabIndex = 6;
            this.numberOfCommandsLabel.Text = "Commands";
            // 
            // speed_OS
            // 
            this.speed_OS.AutoSize = true;
            this.speed_OS.Location = new System.Drawing.Point(112, 17);
            this.speed_OS.Name = "speed_OS";
            this.speed_OS.Size = new System.Drawing.Size(56, 13);
            this.speed_OS.TabIndex = 7;
            this.speed_OS.Text = "Speed OS";
            // 
            // speedOS
            // 
            this.speedOS.Enabled = false;
            this.speedOS.Location = new System.Drawing.Point(365, 17);
            this.speedOS.Name = "speedOS";
            this.speedOS.Size = new System.Drawing.Size(100, 20);
            this.speedOS.TabIndex = 8;
            this.speedOS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.speedOS_KeyPress);
            // 
            // CPU1_Label
            // 
            this.CPU1_Label.AutoSize = true;
            this.CPU1_Label.Location = new System.Drawing.Point(21, 194);
            this.CPU1_Label.Name = "CPU1_Label";
            this.CPU1_Label.Size = new System.Drawing.Size(38, 13);
            this.CPU1_Label.TabIndex = 9;
            this.CPU1_Label.Text = "CPU 1";
            // 
            // CPU2_Label
            // 
            this.CPU2_Label.AutoSize = true;
            this.CPU2_Label.Location = new System.Drawing.Point(21, 277);
            this.CPU2_Label.Name = "CPU2_Label";
            this.CPU2_Label.Size = new System.Drawing.Size(38, 13);
            this.CPU2_Label.TabIndex = 10;
            this.CPU2_Label.Text = "CPU 2";
            // 
            // CPU3_Label
            // 
            this.CPU3_Label.AutoSize = true;
            this.CPU3_Label.Location = new System.Drawing.Point(21, 354);
            this.CPU3_Label.Name = "CPU3_Label";
            this.CPU3_Label.Size = new System.Drawing.Size(38, 13);
            this.CPU3_Label.TabIndex = 11;
            this.CPU3_Label.Text = "CPU 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Speed";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(174, 12);
            this.trackBar1.Maximum = 10000;
            this.trackBar1.Minimum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.Size = new System.Drawing.Size(185, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 18;
            this.trackBar1.TickFrequency = 1000;
            this.trackBar1.Value = 5000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(80, 213);
            this.trackBar2.Maximum = 150;
            this.trackBar2.Minimum = 50;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 19;
            this.trackBar2.TickFrequency = 25;
            this.trackBar2.Value = 100;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(80, 296);
            this.trackBar3.Maximum = 150;
            this.trackBar3.Minimum = 50;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 45);
            this.trackBar3.TabIndex = 20;
            this.trackBar3.TickFrequency = 25;
            this.trackBar3.Value = 100;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(80, 377);
            this.trackBar4.Maximum = 150;
            this.trackBar4.Minimum = 50;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(104, 45);
            this.trackBar4.TabIndex = 21;
            this.trackBar4.TickFrequency = 25;
            this.trackBar4.Value = 100;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Command Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Command Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Command Count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "0";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(533, 0);
            this.button1.MaximumSize = new System.Drawing.Size(200, 40);
            this.button1.MinimumSize = new System.Drawing.Size(10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "Block / Unblock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "10s";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "1s";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "На комманду";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 429);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "-50%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(151, 429);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "+50%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(151, 344);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "+50%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(77, 344);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "-50%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(151, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "+50%";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(77, 261);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "-50%";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(322, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Квант";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(365, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 39;
            this.textBox1.Text = "1000";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // addTaskAuto
            // 
            this.addTaskAuto.Location = new System.Drawing.Point(102, 73);
            this.addTaskAuto.Name = "addTaskAuto";
            this.addTaskAuto.Size = new System.Drawing.Size(75, 23);
            this.addTaskAuto.TabIndex = 40;
            this.addTaskAuto.Text = "Auto Add";
            this.addTaskAuto.UseVisualStyleBackColor = true;
            this.addTaskAuto.Click += new System.EventHandler(this.addTaskAuto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 643);
            this.Controls.Add(this.addTaskAuto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CPU3_Label);
            this.Controls.Add(this.CPU2_Label);
            this.Controls.Add(this.CPU1_Label);
            this.Controls.Add(this.speedOS);
            this.Controls.Add(this.speed_OS);
            this.Controls.Add(this.numberOfCommandsLabel);
            this.Controls.Add(this.memoryLabel);
            this.Controls.Add(this.memory);
            this.Controls.Add(this.numberOfCommands);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.power);
            this.Controls.Add(this.dataGridViewTasks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.TextBox numberOfCommands;
        private System.Windows.Forms.TextBox memory;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label numberOfCommandsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnMemory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnCommandsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnCurrentCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnStatus;
        private System.Windows.Forms.Label speed_OS;
        private System.Windows.Forms.TextBox speedOS;
        private System.Windows.Forms.Label CPU1_Label;
        private System.Windows.Forms.Label CPU2_Label;
        private System.Windows.Forms.Label CPU3_Label;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addTaskAuto;
    }
}

