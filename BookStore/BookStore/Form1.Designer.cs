﻿namespace BookStore
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
            this.bttnDatabase = new System.Windows.Forms.Button();
            this.bttnQueries = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelTables = new System.Windows.Forms.Panel();
            this.bttnBookOperations = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBoxCourriers = new System.Windows.Forms.ListBox();
            this.lstBoxPublishers = new System.Windows.Forms.ListBox();
            this.lstBoxOrders = new System.Windows.Forms.ListBox();
            this.lstBoxBooks = new System.Windows.Forms.ListBox();
            this.bttnRaw = new System.Windows.Forms.Button();
            this.bttnHome = new System.Windows.Forms.Button();
            this.bttnPublisherOperations = new System.Windows.Forms.Button();
            this.bttnCourriersOperations = new System.Windows.Forms.Button();
            this.panelHome.SuspendLayout();
            this.panelTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnDatabase
            // 
            this.bttnDatabase.Location = new System.Drawing.Point(20, 230);
            this.bttnDatabase.Name = "bttnDatabase";
            this.bttnDatabase.Size = new System.Drawing.Size(136, 39);
            this.bttnDatabase.TabIndex = 0;
            this.bttnDatabase.Text = "Database";
            this.bttnDatabase.UseVisualStyleBackColor = true;
            this.bttnDatabase.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnQueries
            // 
            this.bttnQueries.Location = new System.Drawing.Point(179, 230);
            this.bttnQueries.Name = "bttnQueries";
            this.bttnQueries.Size = new System.Drawing.Size(136, 39);
            this.bttnQueries.TabIndex = 0;
            this.bttnQueries.Text = "Queries";
            this.bttnQueries.UseVisualStyleBackColor = true;
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.bttnQueries);
            this.panelHome.Controls.Add(this.bttnDatabase);
            this.panelHome.Location = new System.Drawing.Point(54, 841);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(364, 338);
            this.panelHome.TabIndex = 1;
            // 
            // panelTables
            // 
            this.panelTables.Controls.Add(this.bttnCourriersOperations);
            this.panelTables.Controls.Add(this.bttnPublisherOperations);
            this.panelTables.Controls.Add(this.bttnBookOperations);
            this.panelTables.Controls.Add(this.label4);
            this.panelTables.Controls.Add(this.label3);
            this.panelTables.Controls.Add(this.label2);
            this.panelTables.Controls.Add(this.label1);
            this.panelTables.Controls.Add(this.lstBoxCourriers);
            this.panelTables.Controls.Add(this.lstBoxPublishers);
            this.panelTables.Controls.Add(this.lstBoxOrders);
            this.panelTables.Controls.Add(this.lstBoxBooks);
            this.panelTables.Controls.Add(this.bttnRaw);
            this.panelTables.Controls.Add(this.bttnHome);
            this.panelTables.Location = new System.Drawing.Point(2, 3);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(1498, 790);
            this.panelTables.TabIndex = 2;
            // 
            // bttnBookOperations
            // 
            this.bttnBookOperations.Location = new System.Drawing.Point(10, 686);
            this.bttnBookOperations.Name = "bttnBookOperations";
            this.bttnBookOperations.Size = new System.Drawing.Size(475, 47);
            this.bttnBookOperations.TabIndex = 5;
            this.bttnBookOperations.Text = "Добави / Редактирай / Изтрий";
            this.bttnBookOperations.UseVisualStyleBackColor = true;
            this.bttnBookOperations.Click += new System.EventHandler(this.bttnBookOperations_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(968, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Поръчки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(728, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Куриери";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Издателства";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Книги";
            // 
            // lstBoxCourriers
            // 
            this.lstBoxCourriers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxCourriers.FormattingEnabled = true;
            this.lstBoxCourriers.ItemHeight = 20;
            this.lstBoxCourriers.Location = new System.Drawing.Point(731, 76);
            this.lstBoxCourriers.Name = "lstBoxCourriers";
            this.lstBoxCourriers.Size = new System.Drawing.Size(234, 604);
            this.lstBoxCourriers.TabIndex = 3;
            // 
            // lstBoxPublishers
            // 
            this.lstBoxPublishers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxPublishers.FormattingEnabled = true;
            this.lstBoxPublishers.ItemHeight = 20;
            this.lstBoxPublishers.Location = new System.Drawing.Point(491, 76);
            this.lstBoxPublishers.Name = "lstBoxPublishers";
            this.lstBoxPublishers.Size = new System.Drawing.Size(234, 604);
            this.lstBoxPublishers.TabIndex = 3;
            // 
            // lstBoxOrders
            // 
            this.lstBoxOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxOrders.FormattingEnabled = true;
            this.lstBoxOrders.ItemHeight = 20;
            this.lstBoxOrders.Location = new System.Drawing.Point(971, 76);
            this.lstBoxOrders.Name = "lstBoxOrders";
            this.lstBoxOrders.Size = new System.Drawing.Size(475, 604);
            this.lstBoxOrders.TabIndex = 3;
            // 
            // lstBoxBooks
            // 
            this.lstBoxBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxBooks.FormattingEnabled = true;
            this.lstBoxBooks.ItemHeight = 20;
            this.lstBoxBooks.Location = new System.Drawing.Point(10, 76);
            this.lstBoxBooks.Name = "lstBoxBooks";
            this.lstBoxBooks.Size = new System.Drawing.Size(475, 604);
            this.lstBoxBooks.TabIndex = 3;
            // 
            // bttnRaw
            // 
            this.bttnRaw.Location = new System.Drawing.Point(108, 9);
            this.bttnRaw.Name = "bttnRaw";
            this.bttnRaw.Size = new System.Drawing.Size(129, 35);
            this.bttnRaw.TabIndex = 1;
            this.bttnRaw.Text = "Обнови";
            this.bttnRaw.UseVisualStyleBackColor = true;
            this.bttnRaw.Click += new System.EventHandler(this.bttnRaw_Click);
            // 
            // bttnHome
            // 
            this.bttnHome.Location = new System.Drawing.Point(10, 9);
            this.bttnHome.Name = "bttnHome";
            this.bttnHome.Size = new System.Drawing.Size(91, 36);
            this.bttnHome.TabIndex = 0;
            this.bttnHome.Text = "Home";
            this.bttnHome.UseVisualStyleBackColor = true;
            this.bttnHome.Click += new System.EventHandler(this.button3_Click);
            // 
            // bttnPublisherOperations
            // 
            this.bttnPublisherOperations.Location = new System.Drawing.Point(491, 686);
            this.bttnPublisherOperations.Name = "bttnPublisherOperations";
            this.bttnPublisherOperations.Size = new System.Drawing.Size(234, 47);
            this.bttnPublisherOperations.TabIndex = 5;
            this.bttnPublisherOperations.Text = "Добави / Редактирай / Изтрий";
            this.bttnPublisherOperations.UseVisualStyleBackColor = true;
            this.bttnPublisherOperations.Click += new System.EventHandler(this.bttnPublisherOperations_Click);
            // 
            // bttnCourriersOperations
            // 
            this.bttnCourriersOperations.Location = new System.Drawing.Point(731, 686);
            this.bttnCourriersOperations.Name = "bttnCourriersOperations";
            this.bttnCourriersOperations.Size = new System.Drawing.Size(234, 47);
            this.bttnCourriersOperations.TabIndex = 5;
            this.bttnCourriersOperations.Text = "Добави / Редактирай / Изтрий";
            this.bttnCourriersOperations.UseVisualStyleBackColor = true;
            this.bttnCourriersOperations.Click += new System.EventHandler(this.bttnCourriersOperations_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1837, 1055);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelTables);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookStore";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHome.ResumeLayout(false);
            this.panelTables.ResumeLayout(false);
            this.panelTables.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnDatabase;
        private System.Windows.Forms.Button bttnQueries;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelTables;
        private System.Windows.Forms.Button bttnHome;
        private System.Windows.Forms.Button bttnRaw;
        private System.Windows.Forms.ListBox lstBoxPublishers;
        private System.Windows.Forms.ListBox lstBoxBooks;
        private System.Windows.Forms.ListBox lstBoxCourriers;
        private System.Windows.Forms.ListBox lstBoxOrders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnBookOperations;
        private System.Windows.Forms.Button bttnCourriersOperations;
        private System.Windows.Forms.Button bttnPublisherOperations;
    }
}

