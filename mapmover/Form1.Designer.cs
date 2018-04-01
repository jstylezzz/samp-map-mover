namespace mapmover
{
    partial class ConverterMainPage
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
            this.m_originalMapBox = new System.Windows.Forms.RichTextBox();
            this.m_movedMapBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_clearOriginalButton = new System.Windows.Forms.Button();
            this.m_clearMovedButton = new System.Windows.Forms.Button();
            this.m_clearBothButton = new System.Windows.Forms.Button();
            this.m_moveObjectsButton = new System.Windows.Forms.Button();
            this.m_moveXBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_moveYBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m_moveZBox = new System.Windows.Forms.TextBox();
            this.m_copyToClipboard = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.m_interiorIDBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.m_vWorldBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.m_streamDistBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m_originalMapBox
            // 
            this.m_originalMapBox.Location = new System.Drawing.Point(12, 35);
            this.m_originalMapBox.Name = "m_originalMapBox";
            this.m_originalMapBox.Size = new System.Drawing.Size(522, 439);
            this.m_originalMapBox.TabIndex = 0;
            this.m_originalMapBox.Text = "";
            // 
            // m_movedMapBox
            // 
            this.m_movedMapBox.Location = new System.Drawing.Point(816, 35);
            this.m_movedMapBox.Name = "m_movedMapBox";
            this.m_movedMapBox.ReadOnly = true;
            this.m_movedMapBox.Size = new System.Drawing.Size(522, 439);
            this.m_movedMapBox.TabIndex = 1;
            this.m_movedMapBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original Map Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(813, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Moved Map Code";
            // 
            // m_clearOriginalButton
            // 
            this.m_clearOriginalButton.Location = new System.Drawing.Point(473, 5);
            this.m_clearOriginalButton.Name = "m_clearOriginalButton";
            this.m_clearOriginalButton.Size = new System.Drawing.Size(61, 27);
            this.m_clearOriginalButton.TabIndex = 4;
            this.m_clearOriginalButton.Text = "Clear";
            this.m_clearOriginalButton.UseVisualStyleBackColor = true;
            this.m_clearOriginalButton.Click += new System.EventHandler(this.m_clearOriginalButton_Click);
            // 
            // m_clearMovedButton
            // 
            this.m_clearMovedButton.Location = new System.Drawing.Point(1277, 2);
            this.m_clearMovedButton.Name = "m_clearMovedButton";
            this.m_clearMovedButton.Size = new System.Drawing.Size(61, 27);
            this.m_clearMovedButton.TabIndex = 5;
            this.m_clearMovedButton.Text = "Clear";
            this.m_clearMovedButton.UseVisualStyleBackColor = true;
            this.m_clearMovedButton.Click += new System.EventHandler(this.m_clearMovedButton_Click);
            // 
            // m_clearBothButton
            // 
            this.m_clearBothButton.Location = new System.Drawing.Point(540, 35);
            this.m_clearBothButton.Name = "m_clearBothButton";
            this.m_clearBothButton.Size = new System.Drawing.Size(270, 27);
            this.m_clearBothButton.TabIndex = 6;
            this.m_clearBothButton.Text = "Clear Both";
            this.m_clearBothButton.UseVisualStyleBackColor = true;
            this.m_clearBothButton.Click += new System.EventHandler(this.m_clearBothButton_Click);
            // 
            // m_moveObjectsButton
            // 
            this.m_moveObjectsButton.Location = new System.Drawing.Point(543, 410);
            this.m_moveObjectsButton.Name = "m_moveObjectsButton";
            this.m_moveObjectsButton.Size = new System.Drawing.Size(270, 64);
            this.m_moveObjectsButton.TabIndex = 7;
            this.m_moveObjectsButton.Text = "Move Map Objects";
            this.m_moveObjectsButton.UseVisualStyleBackColor = true;
            this.m_moveObjectsButton.Click += new System.EventHandler(this.m_moveObjectsButton_Click);
            // 
            // m_moveXBox
            // 
            this.m_moveXBox.Location = new System.Drawing.Point(543, 168);
            this.m_moveXBox.Name = "m_moveXBox";
            this.m_moveXBox.Size = new System.Drawing.Size(100, 20);
            this.m_moveXBox.TabIndex = 8;
            this.m_moveXBox.Text = "0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Move X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Move Y";
            // 
            // m_moveYBox
            // 
            this.m_moveYBox.Location = new System.Drawing.Point(543, 217);
            this.m_moveYBox.Name = "m_moveYBox";
            this.m_moveYBox.Size = new System.Drawing.Size(100, 20);
            this.m_moveYBox.TabIndex = 10;
            this.m_moveYBox.Text = "0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Move Z";
            // 
            // m_moveZBox
            // 
            this.m_moveZBox.Location = new System.Drawing.Point(543, 267);
            this.m_moveZBox.Name = "m_moveZBox";
            this.m_moveZBox.Size = new System.Drawing.Size(100, 20);
            this.m_moveZBox.TabIndex = 12;
            this.m_moveZBox.Text = "0.0";
            // 
            // m_copyToClipboard
            // 
            this.m_copyToClipboard.Location = new System.Drawing.Point(1152, 2);
            this.m_copyToClipboard.Name = "m_copyToClipboard";
            this.m_copyToClipboard.Size = new System.Drawing.Size(119, 27);
            this.m_copyToClipboard.TabIndex = 14;
            this.m_copyToClipboard.Text = "Copy To Clipboard";
            this.m_copyToClipboard.UseVisualStyleBackColor = true;
            this.m_copyToClipboard.Click += new System.EventHandler(this.m_copyToClipboard_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Interior ID";
            // 
            // m_interiorIDBox
            // 
            this.m_interiorIDBox.Location = new System.Drawing.Point(543, 316);
            this.m_interiorIDBox.Name = "m_interiorIDBox";
            this.m_interiorIDBox.Size = new System.Drawing.Size(100, 20);
            this.m_interiorIDBox.TabIndex = 15;
            this.m_interiorIDBox.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Virtual World";
            // 
            // m_vWorldBox
            // 
            this.m_vWorldBox.Location = new System.Drawing.Point(543, 360);
            this.m_vWorldBox.Name = "m_vWorldBox";
            this.m_vWorldBox.Size = new System.Drawing.Size(100, 20);
            this.m_vWorldBox.TabIndex = 17;
            this.m_vWorldBox.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(707, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Stream Distance";
            // 
            // m_streamDistBox
            // 
            this.m_streamDistBox.Location = new System.Drawing.Point(710, 168);
            this.m_streamDistBox.Name = "m_streamDistBox";
            this.m_streamDistBox.Size = new System.Drawing.Size(100, 20);
            this.m_streamDistBox.TabIndex = 19;
            this.m_streamDistBox.Text = "100.0";
            // 
            // ConverterMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 486);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.m_streamDistBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.m_vWorldBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.m_interiorIDBox);
            this.Controls.Add(this.m_copyToClipboard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_moveZBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_moveYBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_moveXBox);
            this.Controls.Add(this.m_moveObjectsButton);
            this.Controls.Add(this.m_clearBothButton);
            this.Controls.Add(this.m_clearMovedButton);
            this.Controls.Add(this.m_clearOriginalButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_movedMapBox);
            this.Controls.Add(this.m_originalMapBox);
            this.Name = "ConverterMainPage";
            this.Text = "SA-MP Map Mover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox m_originalMapBox;
        private System.Windows.Forms.RichTextBox m_movedMapBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button m_clearOriginalButton;
        private System.Windows.Forms.Button m_clearMovedButton;
        private System.Windows.Forms.Button m_clearBothButton;
        private System.Windows.Forms.Button m_moveObjectsButton;
        private System.Windows.Forms.TextBox m_moveXBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_moveYBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_moveZBox;
        private System.Windows.Forms.Button m_copyToClipboard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_interiorIDBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox m_vWorldBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox m_streamDistBox;
    }
}

