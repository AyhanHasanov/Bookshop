namespace BookStore.Subforms
{
    partial class PublisherCrud
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
            this.AddBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.EditBttn = new System.Windows.Forms.Button();
            this.txtEditId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.DeleteBttn = new System.Windows.Forms.Button();
            this.txtDeleteId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.panelAdd.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.AddBttn);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Controls.Add(this.txtAddName);
            this.panelAdd.Location = new System.Drawing.Point(12, 61);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(379, 150);
            this.panelAdd.TabIndex = 0;
            // 
            // AddBttn
            // 
            this.AddBttn.Location = new System.Drawing.Point(22, 57);
            this.AddBttn.Name = "AddBttn";
            this.AddBttn.Size = new System.Drawing.Size(317, 33);
            this.AddBttn.TabIndex = 2;
            this.AddBttn.Text = "Добави";
            this.AddBttn.UseVisualStyleBackColor = true;
            this.AddBttn.Click += new System.EventHandler(this.AddBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Име";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(65, 18);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(274, 22);
            this.txtAddName.TabIndex = 0;
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.EditBttn);
            this.panelEdit.Controls.Add(this.txtEditId);
            this.panelEdit.Controls.Add(this.label3);
            this.panelEdit.Controls.Add(this.txtEditName);
            this.panelEdit.Controls.Add(this.label2);
            this.panelEdit.Location = new System.Drawing.Point(12, 286);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(366, 185);
            this.panelEdit.TabIndex = 0;
            // 
            // EditBttn
            // 
            this.EditBttn.Location = new System.Drawing.Point(17, 91);
            this.EditBttn.Name = "EditBttn";
            this.EditBttn.Size = new System.Drawing.Size(317, 33);
            this.EditBttn.TabIndex = 2;
            this.EditBttn.Text = "Редактирай";
            this.EditBttn.UseVisualStyleBackColor = true;
            this.EditBttn.Click += new System.EventHandler(this.EditBttn_Click);
            // 
            // txtEditId
            // 
            this.txtEditId.Location = new System.Drawing.Point(60, 24);
            this.txtEditId.Name = "txtEditId";
            this.txtEditId.Size = new System.Drawing.Size(274, 22);
            this.txtEditId.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ид";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(60, 52);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(274, 22);
            this.txtEditName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име";
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.DeleteBttn);
            this.panelDelete.Controls.Add(this.txtDeleteId);
            this.panelDelete.Controls.Add(this.label5);
            this.panelDelete.Location = new System.Drawing.Point(403, 449);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(366, 159);
            this.panelDelete.TabIndex = 0;
            // 
            // DeleteBttn
            // 
            this.DeleteBttn.Location = new System.Drawing.Point(22, 61);
            this.DeleteBttn.Name = "DeleteBttn";
            this.DeleteBttn.Size = new System.Drawing.Size(317, 33);
            this.DeleteBttn.TabIndex = 2;
            this.DeleteBttn.Text = "Изтриване";
            this.DeleteBttn.UseVisualStyleBackColor = true;
            this.DeleteBttn.Click += new System.EventHandler(this.DeleteBttn_Click);
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.Location = new System.Drawing.Point(65, 20);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(274, 22);
            this.txtDeleteId.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ид";
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(233, 12);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(106, 33);
            this.bttnDelete.TabIndex = 2;
            this.bttnDelete.Text = "Изтриване";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // bttnEdit
            // 
            this.bttnEdit.Location = new System.Drawing.Point(117, 12);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(110, 33);
            this.bttnEdit.TabIndex = 3;
            this.bttnEdit.Text = "Редактиране";
            this.bttnEdit.UseVisualStyleBackColor = true;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(12, 12);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(99, 33);
            this.bttnAdd.TabIndex = 4;
            this.bttnAdd.Text = "Добавяне";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // PublisherCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnEdit);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panelAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PublisherCrud";
            this.Text = "PublisherCrud";
            this.Load += new System.EventHandler(this.PublisherCrud_Load);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Button AddBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button EditBttn;
        private System.Windows.Forms.TextBox txtEditId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteBttn;
        private System.Windows.Forms.TextBox txtDeleteId;
        private System.Windows.Forms.Label label5;
    }
}