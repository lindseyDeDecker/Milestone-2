namespace Milestone_2._1
{
    partial class inventoryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inventoryButton = new Button();
            lblInventory = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // inventoryButton
            // 
            inventoryButton.BackColor = Color.FromArgb(255, 128, 255);
            inventoryButton.Font = new Font("Open Sans", 14F, FontStyle.Bold);
            inventoryButton.Location = new Point(403, 12);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(193, 68);
            inventoryButton.TabIndex = 0;
            inventoryButton.Text = "Display Inventory";
            inventoryButton.UseVisualStyleBackColor = false;
            inventoryButton.Click += lblInventory_Click;
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Location = new Point(213, 284);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(55, 22);
            lblInventory.TabIndex = 1;
            lblInventory.Text = "label1";
            lblInventory.Click += lblInventory_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Open Sans", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(210, 247);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(58, 22);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "label1";
            lblTitle.Click += label1_Click;
            // 
            // inventoryForm
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkViolet;
            ClientSize = new Size(1113, 637);
            Controls.Add(lblTitle);
            Controls.Add(lblInventory);
            Controls.Add(inventoryButton);
            Font = new Font("Open Sans", 12F);
            Margin = new Padding(4);
            Name = "inventoryForm";
            Text = "Inventory";
            Load += inventoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button inventoryButton;
        private Label lblInventory;
        private Label lblTitle;
    }
}
