namespace Discord_Tools;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        ServerIdInput = new System.Windows.Forms.TextBox();
        ServerIDLabel = new System.Windows.Forms.Label();
        Submit = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // ServerIdInput
        // 
        ServerIdInput.Location = new System.Drawing.Point(15, 59);
        ServerIdInput.Name = "ServerIdInput";
        ServerIdInput.Size = new System.Drawing.Size(517, 27);
        ServerIdInput.TabIndex = 0;
        // 
        // ServerIDLabel
        // 
        ServerIDLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
        ServerIDLabel.Location = new System.Drawing.Point(15, 23);
        ServerIDLabel.Name = "ServerIDLabel";
        ServerIDLabel.Size = new System.Drawing.Size(277, 33);
        ServerIDLabel.TabIndex = 1;
        ServerIDLabel.Text = "Server ID";
        // 
        // Submit
        // 
        Submit.Cursor = System.Windows.Forms.Cursors.Hand;
        Submit.Font = new System.Drawing.Font("Segoe UI", 20F);
        Submit.Location = new System.Drawing.Point(15, 520);
        Submit.Name = "Submit";
        Submit.Size = new System.Drawing.Size(517, 119);
        Submit.TabIndex = 2;
        Submit.Text = "Check Server";
        Submit.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(544, 648);
        Controls.Add(Submit);
        Controls.Add(ServerIDLabel);
        Controls.Add(ServerIdInput);
        Text = "Discord Tool";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label ServerIDLabel;

    private System.Windows.Forms.Button Submit;

    private System.Windows.Forms.TextBox ServerIdInput;
    private System.Windows.Forms.Label label1;

    #endregion
}