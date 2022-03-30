
namespace WindowsFormsApp2
{
    partial class FormUrl
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent ()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn4 = new System.Windows.Forms.RadioButton();
            this.btn3 = new System.Windows.Forms.RadioButton();
            this.btn2 = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.RadioButton();
            this.btn0 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.RadioButton();
            this.btnProgres = new System.Windows.Forms.RadioButton();
            this.btnFinish = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newData = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(794, 486);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Read data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of the task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deadline";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 26);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description of the task";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(434, 45);
            this.textBox2.MaximumSize = new System.Drawing.Size(500, 100);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(500, 94);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn4);
            this.groupBox2.Controls.Add(this.btn3);
            this.groupBox2.Controls.Add(this.btn2);
            this.groupBox2.Controls.Add(this.btn1);
            this.groupBox2.Controls.Add(this.btn0);
            this.groupBox2.Location = new System.Drawing.Point(34, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 186);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Priority:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.Location = new System.Drawing.Point(6, 145);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(63, 24);
            this.btn4.TabIndex = 4;
            this.btn4.TabStop = true;
            this.btn4.Text = "Low";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.CheckedChanged += new System.EventHandler(this.btn4_CheckedChanged);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.Location = new System.Drawing.Point(6, 115);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(43, 24);
            this.btn3.TabIndex = 3;
            this.btn3.TabStop = true;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.CheckedChanged += new System.EventHandler(this.btn3_CheckedChanged);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Location = new System.Drawing.Point(5, 85);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(43, 24);
            this.btn2.TabIndex = 2;
            this.btn2.TabStop = true;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.CheckedChanged += new System.EventHandler(this.btn2_CheckedChanged);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Location = new System.Drawing.Point(5, 55);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(43, 24);
            this.btn1.TabIndex = 1;
            this.btn1.TabStop = true;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.CheckedChanged += new System.EventHandler(this.btn1_CheckedChanged);
            // 
            // btn0
            // 
            this.btn0.AutoSize = true;
            this.btn0.Location = new System.Drawing.Point(5, 25);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(61, 24);
            this.btn0.TabIndex = 0;
            this.btn0.TabStop = true;
            this.btn0.Text = "Top";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.CheckedChanged += new System.EventHandler(this.btn0_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "URL:";
            // 
            // Link
            // 
            this.Link.Location = new System.Drawing.Point(434, 196);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(500, 26);
            this.Link.TabIndex = 9;
            this.Link.TextChanged += new System.EventHandler(this.Link_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Comment:";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(434, 287);
            this.tbComment.MaximumSize = new System.Drawing.Size(500, 100);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(500, 94);
            this.tbComment.TabIndex = 11;
            this.tbComment.TextChanged += new System.EventHandler(this.tbComment_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(448, 486);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 32);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update data";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSize = true;
            this.btnOpen.Location = new System.Drawing.Point(6, 25);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(73, 24);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.TabStop = true;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.CheckedChanged += new System.EventHandler(this.btnOpen_CheckedChanged);
            // 
            // btnProgres
            // 
            this.btnProgres.AutoSize = true;
            this.btnProgres.Location = new System.Drawing.Point(6, 66);
            this.btnProgres.Name = "btnProgres";
            this.btnProgres.Size = new System.Drawing.Size(106, 24);
            this.btnProgres.TabIndex = 1;
            this.btnProgres.TabStop = true;
            this.btnProgres.Text = "In progres";
            this.btnProgres.UseVisualStyleBackColor = true;
            this.btnProgres.CheckedChanged += new System.EventHandler(this.btnProgres_CheckedChanged);
            // 
            // btnFinish
            // 
            this.btnFinish.AutoSize = true;
            this.btnFinish.Location = new System.Drawing.Point(6, 106);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(94, 24);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.TabStop = true;
            this.btnFinish.Text = "Finished";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.CheckedChanged += new System.EventHandler(this.btnFinish_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFinish);
            this.groupBox1.Controls.Add(this.btnProgres);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(34, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 146);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // newData
            // 
            this.newData.Location = new System.Drawing.Point(614, 486);
            this.newData.Name = "newData";
            this.newData.Size = new System.Drawing.Size(140, 32);
            this.newData.TabIndex = 12;
            this.newData.Text = "Save new data";
            this.newData.UseVisualStyleBackColor = true;
            this.newData.Click += new System.EventHandler(this.newData_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(283, 486);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 32);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete data";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(834, 415);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 26);
            this.textBoxID.TabIndex = 15;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(788, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID :";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormUrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 560);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.newData);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "FormUrl";
            this.Text = "Task";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Link;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.RadioButton btn4;
        private System.Windows.Forms.RadioButton btn3;
        private System.Windows.Forms.RadioButton btn2;
        private System.Windows.Forms.RadioButton btn1;
        private System.Windows.Forms.RadioButton btn0;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton btnOpen;
        private System.Windows.Forms.RadioButton btnProgres;
        private System.Windows.Forms.RadioButton btnFinish;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button newData;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label6;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

