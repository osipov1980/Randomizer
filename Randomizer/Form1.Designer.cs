namespace Randomizer
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
            this.startBtn = new System.Windows.Forms.Button();
            this.viewBinBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.digitComboBox = new System.Windows.Forms.ComboBox();
            this.viewHexBtn = new System.Windows.Forms.Button();
            this.viewDecBtn = new System.Windows.Forms.Button();
            this.decTextBox = new System.Windows.Forms.TextBox();
            this.binTextBox = new System.Windows.Forms.TextBox();
            this.hexTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(169, 200);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(72, 23);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // viewBinBtn
            // 
            this.viewBinBtn.Location = new System.Drawing.Point(170, 238);
            this.viewBinBtn.Name = "viewBinBtn";
            this.viewBinBtn.Size = new System.Drawing.Size(70, 23);
            this.viewBinBtn.TabIndex = 7;
            this.viewBinBtn.Text = "view binary";
            this.viewBinBtn.UseVisualStyleBackColor = true;
            this.viewBinBtn.Click += new System.EventHandler(this.viewBinBtn_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Randomizer";
            // 
            // digitComboBox
            // 
            this.digitComboBox.FormattingEnabled = true;
            this.digitComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.digitComboBox.Location = new System.Drawing.Point(185, 173);
            this.digitComboBox.Name = "digitComboBox";
            this.digitComboBox.Size = new System.Drawing.Size(35, 21);
            this.digitComboBox.TabIndex = 11;
            this.digitComboBox.Text = "0";
            // 
            // viewHexBtn
            // 
            this.viewHexBtn.Location = new System.Drawing.Point(257, 238);
            this.viewHexBtn.Name = "viewHexBtn";
            this.viewHexBtn.Size = new System.Drawing.Size(72, 23);
            this.viewHexBtn.TabIndex = 14;
            this.viewHexBtn.Text = "view hex";
            this.viewHexBtn.UseVisualStyleBackColor = true;
            this.viewHexBtn.Click += new System.EventHandler(this.viewHexBtn_Click);
            // 
            // viewDecBtn
            // 
            this.viewDecBtn.Location = new System.Drawing.Point(84, 238);
            this.viewDecBtn.Name = "viewDecBtn";
            this.viewDecBtn.Size = new System.Drawing.Size(70, 23);
            this.viewDecBtn.TabIndex = 15;
            this.viewDecBtn.Text = "view dec";
            this.viewDecBtn.UseVisualStyleBackColor = true;
            this.viewDecBtn.Click += new System.EventHandler(this.viewDecBtn_Click);
            // 
            // decTextBox
            // 
            this.decTextBox.Location = new System.Drawing.Point(77, 49);
            this.decTextBox.Name = "decTextBox";
            this.decTextBox.Size = new System.Drawing.Size(256, 20);
            this.decTextBox.TabIndex = 16;
            // 
            // binTextBox
            // 
            this.binTextBox.Location = new System.Drawing.Point(77, 96);
            this.binTextBox.Name = "binTextBox";
            this.binTextBox.Size = new System.Drawing.Size(256, 20);
            this.binTextBox.TabIndex = 17;
            // 
            // hexTextBox
            // 
            this.hexTextBox.Location = new System.Drawing.Point(77, 142);
            this.hexTextBox.Name = "hexTextBox";
            this.hexTextBox.Size = new System.Drawing.Size(256, 20);
            this.hexTextBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 299);
            this.Controls.Add(this.hexTextBox);
            this.Controls.Add(this.binTextBox);
            this.Controls.Add(this.decTextBox);
            this.Controls.Add(this.viewDecBtn);
            this.Controls.Add(this.viewHexBtn);
            this.Controls.Add(this.digitComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewBinBtn);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button viewBinBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox digitComboBox;
        private System.Windows.Forms.Button viewHexBtn;
        private System.Windows.Forms.Button viewDecBtn;
        private System.Windows.Forms.TextBox decTextBox;
        private System.Windows.Forms.TextBox binTextBox;
        private System.Windows.Forms.TextBox hexTextBox;
    }
}

