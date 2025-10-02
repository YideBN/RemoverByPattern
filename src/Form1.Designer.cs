namespace RemoverByPattern
{
    partial class RemoverByPattern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoverByPattern));
            label1 = new Label();
            Advanced = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(10, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 0;
            label1.Text = "Drag'n'Drop pattern file here.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Advanced
            // 
            Advanced.AutoSize = true;
            Advanced.Location = new Point(42, 29);
            Advanced.Margin = new Padding(4, 3, 4, 3);
            Advanced.Name = "Advanced";
            Advanced.Size = new Size(79, 19);
            Advanced.TabIndex = 1;
            Advanced.Text = "Advanced";
            Advanced.UseVisualStyleBackColor = true;
            Advanced.CheckedChanged += Advanced_CheckedChanged;
            // 
            // RemoverByPattern
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(190, 50);
            Controls.Add(Advanced);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RemoverByPattern";
            Text = "RemoverByPattern";
            DragDrop += RemoverByPattern_DragDrop;
            DragEnter += RemoverByPattern_DragEnter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Advanced;
    }
}

