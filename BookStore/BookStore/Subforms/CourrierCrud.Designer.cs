namespace BookStore.Subforms
{
    partial class CourrierCrud
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
            this.panelAdd = new System.Windows.Forms.Panel();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddNum = new System.Windows.Forms.TextBox();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEditNum = new System.Windows.Forms.TextBox();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.txtEditId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeleteId = new System.Windows.Forms.TextBox();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.panelAdd.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.bttnAdd);
            this.panelAdd.Controls.Add(this.txtAddNum);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.txtAddName);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Location = new System.Drawing.Point(36, 85);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(399, 180);
            this.panelAdd.TabIndex = 0;
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.bttnDelete);
            this.panelDelete.Controls.Add(this.txtDeleteId);
            this.panelDelete.Controls.Add(this.label6);
            this.panelDelete.Location = new System.Drawing.Point(507, 85);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(399, 180);
            this.panelDelete.TabIndex = 0;
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.bttnEdit);
            this.panelEdit.Controls.Add(this.txtEditNum);
            this.panelEdit.Controls.Add(this.label5);
            this.panelEdit.Controls.Add(this.label3);
            this.panelEdit.Controls.Add(this.label4);
            this.panelEdit.Controls.Add(this.txtEditId);
            this.panelEdit.Controls.Add(this.txtEditName);
            this.panelEdit.Location = new System.Drawing.Point(36, 271);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(399, 203);
            this.panelEdit.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Изтриване";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Редактиране";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавяне";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(91, 17);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(235, 22);
            this.txtAddName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Тел.";
            // 
            // txtAddNum
            // 
            this.txtAddNum.Location = new System.Drawing.Point(91, 45);
            this.txtAddNum.Name = "txtAddNum";
            this.txtAddNum.Size = new System.Drawing.Size(235, 22);
            this.txtAddNum.TabIndex = 1;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(34, 90);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(292, 35);
            this.bttnAdd.TabIndex = 2;
            this.bttnAdd.Text = "Добави";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Име";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(91, 45);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(235, 22);
            this.txtEditName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Тел.";
            // 
            // txtEditNum
            // 
            this.txtEditNum.Location = new System.Drawing.Point(91, 73);
            this.txtEditNum.Name = "txtEditNum";
            this.txtEditNum.Size = new System.Drawing.Size(235, 22);
            this.txtEditNum.TabIndex = 1;
            // 
            // bttnEdit
            // 
            this.bttnEdit.Location = new System.Drawing.Point(34, 118);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(292, 35);
            this.bttnEdit.TabIndex = 2;
            this.bttnEdit.Text = "Редактирай";
            this.bttnEdit.UseVisualStyleBackColor = true;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // txtEditId
            // 
            this.txtEditId.Location = new System.Drawing.Point(91, 17);
            this.txtEditId.Name = "txtEditId";
            this.txtEditId.Size = new System.Drawing.Size(235, 22);
            this.txtEditId.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ид";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ид";
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.Location = new System.Drawing.Point(92, 20);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(235, 22);
            this.txtDeleteId.TabIndex = 1;
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(35, 65);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(292, 35);
            this.bttnDelete.TabIndex = 2;
            this.bttnDelete.Text = "Изтрий";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // CourrierCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 681);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.panelAdd);
            this.Name = "CourrierCrud";
            this.Text = "CourrierCrud";
            this.Load += new System.EventHandler(this.CourrierCrud_Load);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.TextBox txtAddNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.TextBox txtDeleteId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.TextBox txtEditNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEditId;
        private System.Windows.Forms.TextBox txtEditName;
    }
}