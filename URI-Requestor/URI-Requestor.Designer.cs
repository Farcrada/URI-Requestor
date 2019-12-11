namespace URIRequestor
{
	partial class URIRequestor
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
			this.RequestButton = new System.Windows.Forms.Button();
			this.AbortButton = new System.Windows.Forms.Button();
			this.AddToURIListBoxTextBox = new System.Windows.Forms.TextBox();
			this.AddToURIListBoxButton = new System.Windows.Forms.Button();
			this.RemoveFromURIListButton = new System.Windows.Forms.Button();
			this.URIListBox = new System.Windows.Forms.ListBox();
			this.URIListBoxLabel = new System.Windows.Forms.Label();
			this.AddURITextLabel = new System.Windows.Forms.Label();
			this.ResultsListBox = new System.Windows.Forms.ListBox();
			this.ContextMenuForResults = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ContextMenuForResults.SuspendLayout();
			this.SuspendLayout();
			// 
			// RequestButton
			// 
			this.RequestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.RequestButton.Location = new System.Drawing.Point(411, 401);
			this.RequestButton.Name = "RequestButton";
			this.RequestButton.Size = new System.Drawing.Size(76, 23);
			this.RequestButton.TabIndex = 0;
			this.RequestButton.Text = "Request...";
			this.RequestButton.UseVisualStyleBackColor = true;
			this.RequestButton.Click += new System.EventHandler(this.RequestButton_Click);
			// 
			// AbortButton
			// 
			this.AbortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AbortButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.AbortButton.Location = new System.Drawing.Point(646, 401);
			this.AbortButton.Name = "AbortButton";
			this.AbortButton.Size = new System.Drawing.Size(76, 23);
			this.AbortButton.TabIndex = 1;
			this.AbortButton.Text = "Abort";
			this.AbortButton.UseVisualStyleBackColor = true;
			this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
			// 
			// AddToURIListBoxTextBox
			// 
			this.AddToURIListBoxTextBox.Location = new System.Drawing.Point(12, 403);
			this.AddToURIListBoxTextBox.Name = "AddToURIListBoxTextBox";
			this.AddToURIListBoxTextBox.Size = new System.Drawing.Size(311, 20);
			this.AddToURIListBoxTextBox.TabIndex = 2;
			this.AddToURIListBoxTextBox.TextChanged += new System.EventHandler(this.AddToURIListBoxTextBox_TextChanged);
			// 
			// AddToURIListBoxButton
			// 
			this.AddToURIListBoxButton.Location = new System.Drawing.Point(329, 401);
			this.AddToURIListBoxButton.Name = "AddToURIListBoxButton";
			this.AddToURIListBoxButton.Size = new System.Drawing.Size(76, 23);
			this.AddToURIListBoxButton.TabIndex = 5;
			this.AddToURIListBoxButton.Text = "Add";
			this.AddToURIListBoxButton.UseVisualStyleBackColor = true;
			this.AddToURIListBoxButton.Click += new System.EventHandler(this.AddToListBoxButton_Click);
			// 
			// RemoveFromURIListButton
			// 
			this.RemoveFromURIListButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.RemoveFromURIListButton.Location = new System.Drawing.Point(329, 357);
			this.RemoveFromURIListButton.Name = "RemoveFromURIListButton";
			this.RemoveFromURIListButton.Size = new System.Drawing.Size(76, 23);
			this.RemoveFromURIListButton.TabIndex = 6;
			this.RemoveFromURIListButton.Text = "Remove";
			this.RemoveFromURIListButton.UseVisualStyleBackColor = true;
			this.RemoveFromURIListButton.Click += new System.EventHandler(this.RemoveFromURIListButton_Click);
			// 
			// URIListBox
			// 
			this.URIListBox.FormattingEnabled = true;
			this.URIListBox.Location = new System.Drawing.Point(12, 25);
			this.URIListBox.Name = "URIListBox";
			this.URIListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.URIListBox.Size = new System.Drawing.Size(311, 355);
			this.URIListBox.TabIndex = 7;
			// 
			// URIListBoxLabel
			// 
			this.URIListBoxLabel.AutoSize = true;
			this.URIListBoxLabel.Location = new System.Drawing.Point(12, 9);
			this.URIListBoxLabel.Name = "URIListBoxLabel";
			this.URIListBoxLabel.Size = new System.Drawing.Size(128, 13);
			this.URIListBoxLabel.TabIndex = 8;
			this.URIListBoxLabel.Text = "Currently attempted URIs:";
			// 
			// AddURITextLabel
			// 
			this.AddURITextLabel.AutoSize = true;
			this.AddURITextLabel.Location = new System.Drawing.Point(12, 387);
			this.AddURITextLabel.Name = "AddURITextLabel";
			this.AddURITextLabel.Size = new System.Drawing.Size(102, 13);
			this.AddURITextLabel.TabIndex = 9;
			this.AddURITextLabel.Text = "Enter URI to queue:";
			// 
			// ResultsListBox
			// 
			this.ResultsListBox.ContextMenuStrip = this.ContextMenuForResults;
			this.ResultsListBox.FormattingEnabled = true;
			this.ResultsListBox.Location = new System.Drawing.Point(411, 25);
			this.ResultsListBox.Name = "ResultsListBox";
			this.ResultsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.ResultsListBox.Size = new System.Drawing.Size(311, 355);
			this.ResultsListBox.TabIndex = 10;
			// 
			// ContextMenuForResults
			// 
			this.ContextMenuForResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
			this.ContextMenuForResults.Name = "ContextMenuForResults";
			this.ContextMenuForResults.ShowImageMargin = false;
			this.ContextMenuForResults.Size = new System.Drawing.Size(156, 48);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// URIRequestor
			// 
			this.AcceptButton = this.AddToURIListBoxButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.RemoveFromURIListButton;
			this.ClientSize = new System.Drawing.Size(734, 436);
			this.Controls.Add(this.ResultsListBox);
			this.Controls.Add(this.AddURITextLabel);
			this.Controls.Add(this.URIListBoxLabel);
			this.Controls.Add(this.URIListBox);
			this.Controls.Add(this.RemoveFromURIListButton);
			this.Controls.Add(this.AddToURIListBoxButton);
			this.Controls.Add(this.AddToURIListBoxTextBox);
			this.Controls.Add(this.AbortButton);
			this.Controls.Add(this.RequestButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MinimumSize = new System.Drawing.Size(750, 475);
			this.Name = "URIRequestor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "URI Requestor";
			this.ContextMenuForResults.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button RequestButton;
		private System.Windows.Forms.Button AbortButton;
		private System.Windows.Forms.TextBox AddToURIListBoxTextBox;
		private System.Windows.Forms.Button AddToURIListBoxButton;
		private System.Windows.Forms.Button RemoveFromURIListButton;
		private System.Windows.Forms.ListBox URIListBox;
		private System.Windows.Forms.Label URIListBoxLabel;
		private System.Windows.Forms.Label AddURITextLabel;
		private System.Windows.Forms.ListBox ResultsListBox;
		private System.Windows.Forms.ContextMenuStrip ContextMenuForResults;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
	}
}

