namespace DoAn_QLCF_cs_WinForm.View
{
	partial class CaPheView
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
			dataGridView1 = new DataGridView();
			searchTxt = new TextBox();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(42, 196);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(765, 308);
			dataGridView1.TabIndex = 0;
			// 
			// searchTxt
			// 
			searchTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			searchTxt.Location = new Point(654, 35);
			searchTxt.Name = "searchTxt";
			searchTxt.Size = new Size(174, 23);
			searchTxt.TabIndex = 1;
			// 
			// CaPheView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(840, 525);
			Controls.Add(searchTxt);
			Controls.Add(dataGridView1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "CaPheView";
			Text = "CaPheView";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private TextBox searchTxt;
	}
}