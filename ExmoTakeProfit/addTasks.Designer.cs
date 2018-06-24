namespace ExmoTakeProfit
{
    partial class AddTasks
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
            this.addTasks_listPairToOpenTask = new System.Windows.Forms.ListView();
            this.columnListPairsToOpenTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_listCoinToOpenTask = new System.Windows.Forms.Label();
            this.addTasks_buttonToOpenTaks = new System.Windows.Forms.Button();
            this.addTasks_buttonToCancel = new System.Windows.Forms.Button();
            this.addTasks_textBoxBalance = new System.Windows.Forms.TextBox();
            this.addTasks_label_h1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addTasks_label_volumeToSell = new System.Windows.Forms.Label();
            this.addTasks_textBox_volumeToSell = new System.Windows.Forms.TextBox();
            this.addTasks_button_25 = new System.Windows.Forms.Button();
            this.addTasks_button_50 = new System.Windows.Forms.Button();
            this.addTasks_button_75 = new System.Windows.Forms.Button();
            this.addTasks_button_100 = new System.Windows.Forms.Button();
            this.addTasks_checkBox_useRelativeValues = new System.Windows.Forms.CheckBox();
            this.addTasks_textBox_addProfit = new System.Windows.Forms.TextBox();
            this.addTasks_Label_addProfit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addTasks_listPairToOpenTask
            // 
            this.addTasks_listPairToOpenTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addTasks_listPairToOpenTask.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnListPairsToOpenTask});
            this.addTasks_listPairToOpenTask.FullRowSelect = true;
            this.addTasks_listPairToOpenTask.GridLines = true;
            this.addTasks_listPairToOpenTask.HideSelection = false;
            this.addTasks_listPairToOpenTask.Location = new System.Drawing.Point(12, 25);
            this.addTasks_listPairToOpenTask.MultiSelect = false;
            this.addTasks_listPairToOpenTask.Name = "addTasks_listPairToOpenTask";
            this.addTasks_listPairToOpenTask.Size = new System.Drawing.Size(121, 394);
            this.addTasks_listPairToOpenTask.TabIndex = 0;
            this.addTasks_listPairToOpenTask.UseCompatibleStateImageBehavior = false;
            this.addTasks_listPairToOpenTask.View = System.Windows.Forms.View.Details;
            this.addTasks_listPairToOpenTask.SelectedIndexChanged += new System.EventHandler(this.addTasks_listPairToOpenTask_SelectedIndexChanged);
            // 
            // columnListPairsToOpenTask
            // 
            this.columnListPairsToOpenTask.Text = "Пары";
            this.columnListPairsToOpenTask.Width = 100;
            // 
            // label_listCoinToOpenTask
            // 
            this.label_listCoinToOpenTask.AutoSize = true;
            this.label_listCoinToOpenTask.Location = new System.Drawing.Point(12, 9);
            this.label_listCoinToOpenTask.Name = "label_listCoinToOpenTask";
            this.label_listCoinToOpenTask.Size = new System.Drawing.Size(121, 13);
            this.label_listCoinToOpenTask.TabIndex = 1;
            this.label_listCoinToOpenTask.Text = "Выбор валютной пары";
            // 
            // addTasks_buttonToOpenTaks
            // 
            this.addTasks_buttonToOpenTaks.Enabled = false;
            this.addTasks_buttonToOpenTaks.Location = new System.Drawing.Point(139, 396);
            this.addTasks_buttonToOpenTaks.Name = "addTasks_buttonToOpenTaks";
            this.addTasks_buttonToOpenTaks.Size = new System.Drawing.Size(75, 23);
            this.addTasks_buttonToOpenTaks.TabIndex = 2;
            this.addTasks_buttonToOpenTaks.Text = "Создать задачу";
            this.addTasks_buttonToOpenTaks.UseVisualStyleBackColor = true;
            this.addTasks_buttonToOpenTaks.Click += new System.EventHandler(this.addTasks_buttonToOpenTaks_Click);
            // 
            // addTasks_buttonToCancel
            // 
            this.addTasks_buttonToCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addTasks_buttonToCancel.Location = new System.Drawing.Point(260, 396);
            this.addTasks_buttonToCancel.Name = "addTasks_buttonToCancel";
            this.addTasks_buttonToCancel.Size = new System.Drawing.Size(75, 23);
            this.addTasks_buttonToCancel.TabIndex = 3;
            this.addTasks_buttonToCancel.Text = "Отмена";
            this.addTasks_buttonToCancel.UseVisualStyleBackColor = true;
            this.addTasks_buttonToCancel.Click += new System.EventHandler(this.addTasks_buttonToCancel_Click);
            // 
            // addTasks_textBoxBalance
            // 
            this.addTasks_textBoxBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addTasks_textBoxBalance.Location = new System.Drawing.Point(235, 58);
            this.addTasks_textBoxBalance.Name = "addTasks_textBoxBalance";
            this.addTasks_textBoxBalance.ReadOnly = true;
            this.addTasks_textBoxBalance.Size = new System.Drawing.Size(100, 20);
            this.addTasks_textBoxBalance.TabIndex = 4;
            this.addTasks_textBoxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addTasks_label_h1
            // 
            this.addTasks_label_h1.AutoSize = true;
            this.addTasks_label_h1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTasks_label_h1.Location = new System.Drawing.Point(197, 4);
            this.addTasks_label_h1.Name = "addTasks_label_h1";
            this.addTasks_label_h1.Size = new System.Drawing.Size(52, 20);
            this.addTasks_label_h1.TabIndex = 5;
            this.addTasks_label_h1.Text = "COIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Баланс:";
            // 
            // addTasks_label_volumeToSell
            // 
            this.addTasks_label_volumeToSell.AutoSize = true;
            this.addTasks_label_volumeToSell.Location = new System.Drawing.Point(139, 132);
            this.addTasks_label_volumeToSell.Name = "addTasks_label_volumeToSell";
            this.addTasks_label_volumeToSell.Size = new System.Drawing.Size(79, 13);
            this.addTasks_label_volumeToSell.TabIndex = 7;
            this.addTasks_label_volumeToSell.Text = "Объём торгов";
            // 
            // addTasks_textBox_volumeToSell
            // 
            this.addTasks_textBox_volumeToSell.Location = new System.Drawing.Point(235, 129);
            this.addTasks_textBox_volumeToSell.Name = "addTasks_textBox_volumeToSell";
            this.addTasks_textBox_volumeToSell.Size = new System.Drawing.Size(100, 20);
            this.addTasks_textBox_volumeToSell.TabIndex = 8;
            this.addTasks_textBox_volumeToSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addTasks_textBox_volumeToSell.TextChanged += new System.EventHandler(this.addTasks_textBox_volumeToSell_TextChanged);
            // 
            // addTasks_button_25
            // 
            this.addTasks_button_25.Location = new System.Drawing.Point(139, 100);
            this.addTasks_button_25.Name = "addTasks_button_25";
            this.addTasks_button_25.Size = new System.Drawing.Size(45, 23);
            this.addTasks_button_25.TabIndex = 9;
            this.addTasks_button_25.Text = "25%";
            this.addTasks_button_25.UseVisualStyleBackColor = true;
            this.addTasks_button_25.Click += new System.EventHandler(this.addTasks_button_25_Click);
            // 
            // addTasks_button_50
            // 
            this.addTasks_button_50.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addTasks_button_50.Location = new System.Drawing.Point(188, 100);
            this.addTasks_button_50.Name = "addTasks_button_50";
            this.addTasks_button_50.Size = new System.Drawing.Size(45, 23);
            this.addTasks_button_50.TabIndex = 10;
            this.addTasks_button_50.Text = "50%";
            this.addTasks_button_50.UseVisualStyleBackColor = true;
            this.addTasks_button_50.Click += new System.EventHandler(this.addTasks_button_50_Click);
            // 
            // addTasks_button_75
            // 
            this.addTasks_button_75.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addTasks_button_75.Location = new System.Drawing.Point(239, 100);
            this.addTasks_button_75.Name = "addTasks_button_75";
            this.addTasks_button_75.Size = new System.Drawing.Size(45, 23);
            this.addTasks_button_75.TabIndex = 11;
            this.addTasks_button_75.Text = "75%";
            this.addTasks_button_75.UseVisualStyleBackColor = true;
            this.addTasks_button_75.Click += new System.EventHandler(this.addTasks_button_75_Click);
            // 
            // addTasks_button_100
            // 
            this.addTasks_button_100.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addTasks_button_100.Location = new System.Drawing.Point(290, 100);
            this.addTasks_button_100.Name = "addTasks_button_100";
            this.addTasks_button_100.Size = new System.Drawing.Size(45, 23);
            this.addTasks_button_100.TabIndex = 12;
            this.addTasks_button_100.Text = "100%";
            this.addTasks_button_100.UseVisualStyleBackColor = true;
            this.addTasks_button_100.Click += new System.EventHandler(this.addTasks_button_100_Click);
            // 
            // addTasks_checkBox_useRelativeValues
            // 
            this.addTasks_checkBox_useRelativeValues.AutoSize = true;
            this.addTasks_checkBox_useRelativeValues.Location = new System.Drawing.Point(142, 171);
            this.addTasks_checkBox_useRelativeValues.Name = "addTasks_checkBox_useRelativeValues";
            this.addTasks_checkBox_useRelativeValues.Size = new System.Drawing.Size(187, 17);
            this.addTasks_checkBox_useRelativeValues.TabIndex = 13;
            this.addTasks_checkBox_useRelativeValues.Text = "Добавлять прибыль к торговле\r\n";
            this.addTasks_checkBox_useRelativeValues.UseVisualStyleBackColor = true;
            this.addTasks_checkBox_useRelativeValues.CheckedChanged += new System.EventHandler(this.addTasks_checkBox_useRelativeValues_CheckedChanged);
            // 
            // addTasks_textBox_addProfit
            // 
            this.addTasks_textBox_addProfit.Enabled = false;
            this.addTasks_textBox_addProfit.Location = new System.Drawing.Point(235, 194);
            this.addTasks_textBox_addProfit.Name = "addTasks_textBox_addProfit";
            this.addTasks_textBox_addProfit.Size = new System.Drawing.Size(100, 20);
            this.addTasks_textBox_addProfit.TabIndex = 14;
            this.addTasks_textBox_addProfit.Text = "0";
            this.addTasks_textBox_addProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addTasks_Label_addProfit
            // 
            this.addTasks_Label_addProfit.AutoSize = true;
            this.addTasks_Label_addProfit.Location = new System.Drawing.Point(139, 197);
            this.addTasks_Label_addProfit.Name = "addTasks_Label_addProfit";
            this.addTasks_Label_addProfit.Size = new System.Drawing.Size(72, 13);
            this.addTasks_Label_addProfit.TabIndex = 15;
            this.addTasks_Label_addProfit.Text = "Но не более:";
            // 
            // AddTasks
            // 
            this.AcceptButton = this.addTasks_buttonToOpenTaks;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.addTasks_buttonToCancel;
            this.ClientSize = new System.Drawing.Size(344, 431);
            this.ControlBox = false;
            this.Controls.Add(this.addTasks_Label_addProfit);
            this.Controls.Add(this.addTasks_textBox_addProfit);
            this.Controls.Add(this.addTasks_checkBox_useRelativeValues);
            this.Controls.Add(this.addTasks_button_100);
            this.Controls.Add(this.addTasks_button_75);
            this.Controls.Add(this.addTasks_button_50);
            this.Controls.Add(this.addTasks_button_25);
            this.Controls.Add(this.addTasks_textBox_volumeToSell);
            this.Controls.Add(this.addTasks_label_volumeToSell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addTasks_label_h1);
            this.Controls.Add(this.addTasks_textBoxBalance);
            this.Controls.Add(this.addTasks_buttonToCancel);
            this.Controls.Add(this.addTasks_buttonToOpenTaks);
            this.Controls.Add(this.label_listCoinToOpenTask);
            this.Controls.Add(this.addTasks_listPairToOpenTask);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addTasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView addTasks_listPairToOpenTask;
        private System.Windows.Forms.ColumnHeader columnListPairsToOpenTask;
        private System.Windows.Forms.Label label_listCoinToOpenTask;
        private System.Windows.Forms.Button addTasks_buttonToOpenTaks;
        private System.Windows.Forms.Button addTasks_buttonToCancel;
        private System.Windows.Forms.TextBox addTasks_textBoxBalance;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label addTasks_label_h1;
        private System.Windows.Forms.Label addTasks_label_volumeToSell;
        private System.Windows.Forms.TextBox addTasks_textBox_volumeToSell;
        private System.Windows.Forms.Button addTasks_button_25;
        private System.Windows.Forms.Button addTasks_button_50;
        private System.Windows.Forms.Button addTasks_button_75;
        private System.Windows.Forms.Button addTasks_button_100;
        private System.Windows.Forms.CheckBox addTasks_checkBox_useRelativeValues;
        private System.Windows.Forms.TextBox addTasks_textBox_addProfit;
        private System.Windows.Forms.Label addTasks_Label_addProfit;
    }
}