﻿
namespace Cash_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numberOfSwordsLabel = new System.Windows.Forms.Label();
            this.numberOfChestplatesLabel = new System.Windows.Forms.Label();
            this.numberOfHammersLabel = new System.Windows.Forms.Label();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.numberOfSwordsTextbox = new System.Windows.Forms.TextBox();
            this.numberOfChestplatesTextbox = new System.Windows.Forms.TextBox();
            this.numberOfHammersTextbox = new System.Windows.Forms.TextBox();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.subTotalNumLabel = new System.Windows.Forms.Label();
            this.taxNumLabel = new System.Windows.Forms.Label();
            this.totalNumLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedTextbox = new System.Windows.Forms.TextBox();
            this.anitiCrashLabel = new System.Windows.Forms.Label();
            this.changeNumLabel = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberOfSwordsLabel
            // 
            this.numberOfSwordsLabel.AutoSize = true;
            this.numberOfSwordsLabel.Location = new System.Drawing.Point(72, 54);
            this.numberOfSwordsLabel.Name = "numberOfSwordsLabel";
            this.numberOfSwordsLabel.Size = new System.Drawing.Size(127, 17);
            this.numberOfSwordsLabel.TabIndex = 0;
            this.numberOfSwordsLabel.Text = "Number Of Swords";
            // 
            // numberOfChestplatesLabel
            // 
            this.numberOfChestplatesLabel.AutoSize = true;
            this.numberOfChestplatesLabel.Location = new System.Drawing.Point(72, 83);
            this.numberOfChestplatesLabel.Name = "numberOfChestplatesLabel";
            this.numberOfChestplatesLabel.Size = new System.Drawing.Size(155, 17);
            this.numberOfChestplatesLabel.TabIndex = 1;
            this.numberOfChestplatesLabel.Text = "Number Of Chestplates";
            // 
            // numberOfHammersLabel
            // 
            this.numberOfHammersLabel.AutoSize = true;
            this.numberOfHammersLabel.Location = new System.Drawing.Point(72, 112);
            this.numberOfHammersLabel.Name = "numberOfHammersLabel";
            this.numberOfHammersLabel.Size = new System.Drawing.Size(141, 17);
            this.numberOfHammersLabel.TabIndex = 2;
            this.numberOfHammersLabel.Text = "Number Of Hammers";
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.ForeColor = System.Drawing.Color.White;
            this.calculateTotalButton.Image = global::Cash_Register.Properties.Resources.medieval_button_art;
            this.calculateTotalButton.Location = new System.Drawing.Point(75, 145);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(215, 37);
            this.calculateTotalButton.TabIndex = 3;
            this.calculateTotalButton.Text = "Calculate Total";
            this.calculateTotalButton.UseVisualStyleBackColor = true;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // numberOfSwordsTextbox
            // 
            this.numberOfSwordsTextbox.Location = new System.Drawing.Point(244, 54);
            this.numberOfSwordsTextbox.Name = "numberOfSwordsTextbox";
            this.numberOfSwordsTextbox.Size = new System.Drawing.Size(46, 22);
            this.numberOfSwordsTextbox.TabIndex = 4;
            // 
            // numberOfChestplatesTextbox
            // 
            this.numberOfChestplatesTextbox.Location = new System.Drawing.Point(244, 83);
            this.numberOfChestplatesTextbox.Name = "numberOfChestplatesTextbox";
            this.numberOfChestplatesTextbox.Size = new System.Drawing.Size(46, 22);
            this.numberOfChestplatesTextbox.TabIndex = 5;
            // 
            // numberOfHammersTextbox
            // 
            this.numberOfHammersTextbox.Location = new System.Drawing.Point(244, 112);
            this.numberOfHammersTextbox.Name = "numberOfHammersTextbox";
            this.numberOfHammersTextbox.Size = new System.Drawing.Size(46, 22);
            this.numberOfHammersTextbox.TabIndex = 6;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(72, 195);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(69, 17);
            this.subTotalLabel.TabIndex = 7;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(72, 223);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(31, 17);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(72, 253);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(40, 17);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total";
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.ForeColor = System.Drawing.Color.White;
            this.calculateChangeButton.Image = global::Cash_Register.Properties.Resources.medieval_button_art;
            this.calculateChangeButton.Location = new System.Drawing.Point(75, 322);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(215, 37);
            this.calculateChangeButton.TabIndex = 10;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = true;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(72, 371);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(57, 17);
            this.changeLabel.TabIndex = 11;
            this.changeLabel.Text = "Change";
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.ForeColor = System.Drawing.Color.White;
            this.printReceiptButton.Image = global::Cash_Register.Properties.Resources.medieval_button_art;
            this.printReceiptButton.Location = new System.Drawing.Point(75, 401);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(215, 37);
            this.printReceiptButton.TabIndex = 12;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = true;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // subTotalNumLabel
            // 
            this.subTotalNumLabel.AutoSize = true;
            this.subTotalNumLabel.Location = new System.Drawing.Point(241, 195);
            this.subTotalNumLabel.Name = "subTotalNumLabel";
            this.subTotalNumLabel.Size = new System.Drawing.Size(0, 17);
            this.subTotalNumLabel.TabIndex = 13;
            // 
            // taxNumLabel
            // 
            this.taxNumLabel.AutoSize = true;
            this.taxNumLabel.Location = new System.Drawing.Point(241, 223);
            this.taxNumLabel.Name = "taxNumLabel";
            this.taxNumLabel.Size = new System.Drawing.Size(0, 17);
            this.taxNumLabel.TabIndex = 14;
            // 
            // totalNumLabel
            // 
            this.totalNumLabel.AutoSize = true;
            this.totalNumLabel.Location = new System.Drawing.Point(241, 253);
            this.totalNumLabel.Name = "totalNumLabel";
            this.totalNumLabel.Size = new System.Drawing.Size(0, 17);
            this.totalNumLabel.TabIndex = 15;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(72, 286);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(70, 17);
            this.tenderedLabel.TabIndex = 16;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedTextbox
            // 
            this.tenderedTextbox.Location = new System.Drawing.Point(244, 286);
            this.tenderedTextbox.Name = "tenderedTextbox";
            this.tenderedTextbox.Size = new System.Drawing.Size(46, 22);
            this.tenderedTextbox.TabIndex = 17;
            // 
            // anitiCrashLabel
            // 
            this.anitiCrashLabel.AutoSize = true;
            this.anitiCrashLabel.Location = new System.Drawing.Point(72, 9);
            this.anitiCrashLabel.Name = "anitiCrashLabel";
            this.anitiCrashLabel.Size = new System.Drawing.Size(0, 17);
            this.anitiCrashLabel.TabIndex = 18;
            // 
            // changeNumLabel
            // 
            this.changeNumLabel.AutoSize = true;
            this.changeNumLabel.Location = new System.Drawing.Point(241, 371);
            this.changeNumLabel.Name = "changeNumLabel";
            this.changeNumLabel.Size = new System.Drawing.Size(0, 17);
            this.changeNumLabel.TabIndex = 19;
            // 
            // receiptLabel
            // 
            this.receiptLabel.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(355, 54);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(343, 334);
            this.receiptLabel.TabIndex = 20;
            // 
            // newOrderButton
            // 
            this.newOrderButton.ForeColor = System.Drawing.Color.White;
            this.newOrderButton.Image = global::Cash_Register.Properties.Resources.medieval_button_art;
            this.newOrderButton.Location = new System.Drawing.Point(500, 401);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(215, 37);
            this.newOrderButton.TabIndex = 21;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.changeNumLabel);
            this.Controls.Add(this.anitiCrashLabel);
            this.Controls.Add(this.tenderedTextbox);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalNumLabel);
            this.Controls.Add(this.taxNumLabel);
            this.Controls.Add(this.subTotalNumLabel);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.numberOfHammersTextbox);
            this.Controls.Add(this.numberOfChestplatesTextbox);
            this.Controls.Add(this.numberOfSwordsTextbox);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.numberOfHammersLabel);
            this.Controls.Add(this.numberOfChestplatesLabel);
            this.Controls.Add(this.numberOfSwordsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hunters Blacksmith Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberOfSwordsLabel;
        private System.Windows.Forms.Label numberOfChestplatesLabel;
        private System.Windows.Forms.Label numberOfHammersLabel;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.TextBox numberOfSwordsTextbox;
        private System.Windows.Forms.TextBox numberOfChestplatesTextbox;
        private System.Windows.Forms.TextBox numberOfHammersTextbox;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Label subTotalNumLabel;
        private System.Windows.Forms.Label taxNumLabel;
        private System.Windows.Forms.Label totalNumLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedTextbox;
        private System.Windows.Forms.Label anitiCrashLabel;
        private System.Windows.Forms.Label changeNumLabel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button newOrderButton;
    }
}

