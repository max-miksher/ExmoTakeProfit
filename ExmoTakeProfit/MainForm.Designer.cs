using System.Windows.Forms;

namespace ExmoTakeProfit
{
    partial class ExmoTakeProfit
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
            this.login = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listCoins = new System.Windows.Forms.ListView();
            this.columnCoin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userId = new System.Windows.Forms.Label();
            this.listOpenTasks = new System.Windows.Forms.ListView();
            this.columnPair = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addTasks_button = new System.Windows.Forms.Button();
            this.deleteTask = new System.Windows.Forms.Button();
            this.editTask = new System.Windows.Forms.Button();
            this.labelOpenTasks = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.Control;
            this.login.Location = new System.Drawing.Point(863, 12);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 0;
            this.login.Text = "Войти";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(950, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // listCoins
            // 
            this.listCoins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listCoins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCoin,
            this.columnValue});
            this.listCoins.FullRowSelect = true;
            this.listCoins.GridLines = true;
            this.listCoins.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listCoins.HideSelection = false;
            this.listCoins.Location = new System.Drawing.Point(793, 41);
            this.listCoins.MultiSelect = false;
            this.listCoins.Name = "listCoins";
            this.listCoins.Size = new System.Drawing.Size(150, 385);
            this.listCoins.TabIndex = 3;
            this.listCoins.UseCompatibleStateImageBehavior = false;
            this.listCoins.View = System.Windows.Forms.View.Details;
            this.listCoins.SelectedIndexChanged += new System.EventHandler(this.listCoins_SelectedIndexChanged);
            // 
            // columnCoin
            // 
            this.columnCoin.Text = "Coin";
            this.columnCoin.Width = 55;
            // 
            // columnValue
            // 
            this.columnValue.Text = "Value";
            this.columnValue.Width = 65;
            // 
            // userId
            // 
            this.userId.AutoSize = true;
            this.userId.Location = new System.Drawing.Point(745, 16);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(0, 14);
            this.userId.TabIndex = 4;
            this.userId.Visible = false;
            // 
            // listOpenTasks
            // 
            this.listOpenTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listOpenTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPair,
            this.columnRange});
            this.listOpenTasks.FullRowSelect = true;
            this.listOpenTasks.GridLines = true;
            this.listOpenTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listOpenTasks.Location = new System.Drawing.Point(12, 41);
            this.listOpenTasks.MultiSelect = false;
            this.listOpenTasks.Name = "listOpenTasks";
            this.listOpenTasks.ShowGroups = false;
            this.listOpenTasks.Size = new System.Drawing.Size(200, 385);
            this.listOpenTasks.TabIndex = 5;
            this.listOpenTasks.UseCompatibleStateImageBehavior = false;
            this.listOpenTasks.View = System.Windows.Forms.View.Details;
            // 
            // columnPair
            // 
            this.columnPair.Text = "Пара";
            this.columnPair.Width = 100;
            // 
            // columnRange
            // 
            this.columnRange.Text = "Амплитуда";
            this.columnRange.Width = 100;
            // 
            // addTasks_button
            // 
            this.addTasks_button.Enabled = false;
            this.addTasks_button.Location = new System.Drawing.Point(793, 432);
            this.addTasks_button.Name = "addTasks_button";
            this.addTasks_button.Size = new System.Drawing.Size(150, 23);
            this.addTasks_button.TabIndex = 6;
            this.addTasks_button.Text = "Открыть задание";
            this.addTasks_button.UseVisualStyleBackColor = true;
            this.addTasks_button.Click += new System.EventHandler(this.addTasks_button_Click);
            // 
            // deleteTask
            // 
            this.deleteTask.Enabled = false;
            this.deleteTask.Location = new System.Drawing.Point(137, 432);
            this.deleteTask.Name = "deleteTask";
            this.deleteTask.Size = new System.Drawing.Size(75, 23);
            this.deleteTask.TabIndex = 7;
            this.deleteTask.Text = "Удалить";
            this.deleteTask.UseVisualStyleBackColor = true;
            // 
            // editTask
            // 
            this.editTask.Enabled = false;
            this.editTask.Location = new System.Drawing.Point(12, 432);
            this.editTask.Name = "editTask";
            this.editTask.Size = new System.Drawing.Size(75, 23);
            this.editTask.TabIndex = 8;
            this.editTask.Text = "Изменить";
            this.editTask.UseVisualStyleBackColor = true;
            // 
            // labelOpenTasks
            // 
            this.labelOpenTasks.AutoSize = true;
            this.labelOpenTasks.Location = new System.Drawing.Point(55, 16);
            this.labelOpenTasks.Name = "labelOpenTasks";
            this.labelOpenTasks.Size = new System.Drawing.Size(113, 14);
            this.labelOpenTasks.TabIndex = 10;
            this.labelOpenTasks.Text = "Открытые задания";
            // 
            // ExmoTakeProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(950, 480);
            this.Controls.Add(this.labelOpenTasks);
            this.Controls.Add(this.editTask);
            this.Controls.Add(this.deleteTask);
            this.Controls.Add(this.addTasks_button);
            this.Controls.Add(this.listOpenTasks);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.listCoins);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.login);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "ExmoTakeProfit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExmoTakeProfit";
            this.Shown += new System.EventHandler(this.ExmoTakeProfit_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button login;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ListView listCoins;
        private ColumnHeader columnCoin;
        private ColumnHeader columnValue;
        private Label userId;
        private ListView listOpenTasks;
        private Button addTasks_button;
        private ColumnHeader columnPair;
        private ColumnHeader columnRange;
        private Button deleteTask;
        private Button editTask;
        private Label labelOpenTasks;
    }
}

