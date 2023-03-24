namespace BookStore
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
            this.components = new System.ComponentModel.Container();
            this.bttnDatabase = new System.Windows.Forms.Button();
            this.bttnQueries = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelTables = new System.Windows.Forms.Panel();
            this.bttnOrdersOperations = new System.Windows.Forms.Button();
            this.bttnCourriersOperations = new System.Windows.Forms.Button();
            this.bttnPublisherOperations = new System.Windows.Forms.Button();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHome.SuspendLayout();
            this.panelTables.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnDatabase
            // 
            this.bttnDatabase.Location = new System.Drawing.Point(15, 187);
            this.bttnDatabase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnDatabase.Name = "bttnDatabase";
            this.bttnDatabase.Size = new System.Drawing.Size(102, 32);
            this.bttnDatabase.TabIndex = 0;
            this.bttnDatabase.Text = "Database";
            this.bttnDatabase.UseVisualStyleBackColor = true;
            this.bttnDatabase.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnQueries
            // 
            this.bttnQueries.Location = new System.Drawing.Point(134, 187);
            this.bttnQueries.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnQueries.Name = "bttnQueries";
            this.bttnQueries.Size = new System.Drawing.Size(102, 32);
            this.bttnQueries.TabIndex = 0;
            this.bttnQueries.Text = "Queries";
            this.bttnQueries.UseVisualStyleBackColor = true;
            this.bttnQueries.Click += new System.EventHandler(this.bttnQueries_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.bttnQueries);
            this.panelHome.Controls.Add(this.bttnDatabase);
            this.panelHome.Location = new System.Drawing.Point(11, 649);
            this.panelHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(273, 275);
            this.panelHome.TabIndex = 1;
            // 
            // panelTables
            // 
            this.panelTables.Controls.Add(this.bttnOrdersOperations);
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
            this.panelTables.Location = new System.Drawing.Point(1, 10);
            this.panelTables.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(1124, 642);
            this.panelTables.TabIndex = 2;
            // 
            // bttnOrdersOperations
            // 
            this.bttnOrdersOperations.Location = new System.Drawing.Point(728, 557);
            this.bttnOrdersOperations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnOrdersOperations.Name = "bttnOrdersOperations";
            this.bttnOrdersOperations.Size = new System.Drawing.Size(356, 38);
            this.bttnOrdersOperations.TabIndex = 5;
            this.bttnOrdersOperations.Text = "Добави / Редактирай / Изтрий";
            this.bttnOrdersOperations.UseVisualStyleBackColor = true;
            this.bttnOrdersOperations.Click += new System.EventHandler(this.bttnOrdersOperations_Click);
            // 
            // bttnCourriersOperations
            // 
            this.bttnCourriersOperations.Location = new System.Drawing.Point(548, 557);
            this.bttnCourriersOperations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnCourriersOperations.Name = "bttnCourriersOperations";
            this.bttnCourriersOperations.Size = new System.Drawing.Size(176, 38);
            this.bttnCourriersOperations.TabIndex = 5;
            this.bttnCourriersOperations.Text = "Добави / Редактирай / Изтрий";
            this.bttnCourriersOperations.UseVisualStyleBackColor = true;
            this.bttnCourriersOperations.Click += new System.EventHandler(this.bttnCourriersOperations_Click);
            // 
            // bttnPublisherOperations
            // 
            this.bttnPublisherOperations.Location = new System.Drawing.Point(368, 557);
            this.bttnPublisherOperations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnPublisherOperations.Name = "bttnPublisherOperations";
            this.bttnPublisherOperations.Size = new System.Drawing.Size(176, 38);
            this.bttnPublisherOperations.TabIndex = 5;
            this.bttnPublisherOperations.Text = "Добави / Редактирай / Изтрий";
            this.bttnPublisherOperations.UseVisualStyleBackColor = true;
            this.bttnPublisherOperations.Click += new System.EventHandler(this.bttnPublisherOperations_Click);
            // 
            // bttnBookOperations
            // 
            this.bttnBookOperations.Location = new System.Drawing.Point(8, 557);
            this.bttnBookOperations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnBookOperations.Name = "bttnBookOperations";
            this.bttnBookOperations.Size = new System.Drawing.Size(356, 38);
            this.bttnBookOperations.TabIndex = 5;
            this.bttnBookOperations.Text = "Добави / Редактирай / Изтрий";
            this.bttnBookOperations.UseVisualStyleBackColor = true;
            this.bttnBookOperations.Click += new System.EventHandler(this.bttnBookOperations_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(726, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Поръчки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Куриери";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Издателства";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Книги";
            // 
            // lstBoxCourriers
            // 
            this.lstBoxCourriers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxCourriers.FormattingEnabled = true;
            this.lstBoxCourriers.ItemHeight = 17;
            this.lstBoxCourriers.Location = new System.Drawing.Point(548, 62);
            this.lstBoxCourriers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstBoxCourriers.Name = "lstBoxCourriers";
            this.lstBoxCourriers.Size = new System.Drawing.Size(176, 480);
            this.lstBoxCourriers.TabIndex = 3;
            // 
            // lstBoxPublishers
            // 
            this.lstBoxPublishers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxPublishers.FormattingEnabled = true;
            this.lstBoxPublishers.ItemHeight = 17;
            this.lstBoxPublishers.Location = new System.Drawing.Point(368, 62);
            this.lstBoxPublishers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstBoxPublishers.Name = "lstBoxPublishers";
            this.lstBoxPublishers.Size = new System.Drawing.Size(176, 480);
            this.lstBoxPublishers.TabIndex = 3;
            // 
            // lstBoxOrders
            // 
            this.lstBoxOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxOrders.FormattingEnabled = true;
            this.lstBoxOrders.ItemHeight = 17;
            this.lstBoxOrders.Location = new System.Drawing.Point(728, 62);
            this.lstBoxOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstBoxOrders.Name = "lstBoxOrders";
            this.lstBoxOrders.Size = new System.Drawing.Size(357, 480);
            this.lstBoxOrders.TabIndex = 3;
            // 
            // lstBoxBooks
            // 
            this.lstBoxBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxBooks.FormattingEnabled = true;
            this.lstBoxBooks.ItemHeight = 17;
            this.lstBoxBooks.Location = new System.Drawing.Point(8, 62);
            this.lstBoxBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstBoxBooks.Name = "lstBoxBooks";
            this.lstBoxBooks.Size = new System.Drawing.Size(357, 480);
            this.lstBoxBooks.TabIndex = 3;
            // 
            // bttnRaw
            // 
            this.bttnRaw.Location = new System.Drawing.Point(81, 7);
            this.bttnRaw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnRaw.Name = "bttnRaw";
            this.bttnRaw.Size = new System.Drawing.Size(97, 28);
            this.bttnRaw.TabIndex = 1;
            this.bttnRaw.Text = "Обнови";
            this.bttnRaw.UseVisualStyleBackColor = true;
            this.bttnRaw.Click += new System.EventHandler(this.bttnRaw_Click);
            // 
            // bttnHome
            // 
            this.bttnHome.Location = new System.Drawing.Point(8, 7);
            this.bttnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnHome.Name = "bttnHome";
            this.bttnHome.Size = new System.Drawing.Size(68, 29);
            this.bttnHome.TabIndex = 0;
            this.bttnHome.Text = "Home";
            this.bttnHome.UseVisualStyleBackColor = true;
            this.bttnHome.Click += new System.EventHandler(this.button3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.queriesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDatabaseToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // showDatabaseToolStripMenuItem
            // 
            this.showDatabaseToolStripMenuItem.Name = "showDatabaseToolStripMenuItem";
            this.showDatabaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showDatabaseToolStripMenuItem.Text = "Show Database";
            this.showDatabaseToolStripMenuItem.Click += new System.EventHandler(this.showDatabaseToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.queriesToolStripMenuItem.Text = "Queries";
            this.queriesToolStripMenuItem.Click += new System.EventHandler(this.queriesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 857);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelTables);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookStore";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHome.ResumeLayout(false);
            this.panelTables.ResumeLayout(false);
            this.panelTables.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.Button bttnOrdersOperations;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
    }
}

