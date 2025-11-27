namespace FiscoTask.Views
{
    partial class EditorForm
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
            rtfEditor1 = new FiscoTask.Controls.RtfEditor();
            SuspendLayout();
            // 
            // rtfEditor1
            // 
            rtfEditor1.Location = new Point(12, 12);
            rtfEditor1.Name = "rtfEditor1";
            rtfEditor1.Size = new Size(719, 460);
            rtfEditor1.TabIndex = 0;
            // 
            // EditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 568);
            Controls.Add(rtfEditor1);
            Name = "EditorForm";
            Text = "EditorForm";
            ResumeLayout(false);
        }

        #endregion

        private Controls.RtfEditor rtfEditor1;
    }
}