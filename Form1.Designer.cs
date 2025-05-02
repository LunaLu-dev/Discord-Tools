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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        ServerIdInput = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        Submit = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // ServerIdInput
        // 
        ServerIdInput.Location = new System.Drawing.Point(15, 59);
        ServerIdInput.Name = "ServerIdInput";
        ServerIdInput.Size = new System.Drawing.Size(517, 23);
        ServerIdInput.TabIndex = 0;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(0, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 3;
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
        Submit.Click += Submit_Click;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 15F);
        label2.Location = new System.Drawing.Point(22, 20);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 4;
        label2.Text = "Server ID";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(544, 648);
        Controls.Add(label2);
        Controls.Add(Submit);
        Controls.Add(label1);
        Controls.Add(ServerIdInput);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        Text = "Discord Tool";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button Submit;

    private System.Windows.Forms.TextBox ServerIdInput;
    private System.Windows.Forms.Label label1;

    #endregion
}