namespace UnrealClassGenerator;

partial class UnrealClassGenerator
{
	private System.ComponentModel.IContainer components = null;

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
		SavePathLabel = new Label();
		SavePathTextBox = new TextBox();
		ClassNameLabel = new Label();
		ClassNameTextBox = new TextBox();
		GenerateClassFilesButton = new Button();
		SaveFolderBrowserButton = new Button();
		ClassPrefixLabel = new Label();
		ClassPrefixTextBox = new TextBox();
		SuspendLayout();
		// 
		// SavePathLabel
		// 
		SavePathLabel.AutoSize = true;
		SavePathLabel.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
		SavePathLabel.Location = new Point(38, 25);
		SavePathLabel.Name = "SavePathLabel";
		SavePathLabel.Size = new Size(143, 38);
		SavePathLabel.TabIndex = 0;
		SavePathLabel.Text = "Save Path";
		SavePathLabel.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// SavePathTextBox
		// 
		SavePathTextBox.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
		SavePathTextBox.Location = new Point(200, 27);
		SavePathTextBox.Name = "SavePathTextBox";
		SavePathTextBox.Size = new Size(839, 35);
		SavePathTextBox.TabIndex = 1;
		// 
		// ClassNameLabel
		// 
		ClassNameLabel.AutoSize = true;
		ClassNameLabel.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
		ClassNameLabel.Location = new Point(287, 93);
		ClassNameLabel.Name = "ClassNameLabel";
		ClassNameLabel.Size = new Size(167, 38);
		ClassNameLabel.TabIndex = 2;
		ClassNameLabel.Text = "Class Name";
		ClassNameLabel.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// ClassNameTextBox
		// 
		ClassNameTextBox.Font = new Font("Malgun Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
		ClassNameTextBox.Location = new Point(480, 89);
		ClassNameTextBox.Name = "ClassNameTextBox";
		ClassNameTextBox.Size = new Size(646, 42);
		ClassNameTextBox.TabIndex = 3;
		// 
		// GenerateClassFilesButton
		// 
		GenerateClassFilesButton.Font = new Font("Malgun Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
		GenerateClassFilesButton.Location = new Point(384, 150);
		GenerateClassFilesButton.Name = "GenerateClassFilesButton";
		GenerateClassFilesButton.Size = new Size(379, 78);
		GenerateClassFilesButton.TabIndex = 4;
		GenerateClassFilesButton.Text = "Generate Class Files";
		GenerateClassFilesButton.UseVisualStyleBackColor = true;
		GenerateClassFilesButton.Click += GenerateClassFilesButton_Click;
		// 
		// SaveFolderBrowserButton
		// 
		SaveFolderBrowserButton.Location = new Point(1045, 17);
		SaveFolderBrowserButton.Name = "SaveFolderBrowserButton";
		SaveFolderBrowserButton.Size = new Size(81, 56);
		SaveFolderBrowserButton.TabIndex = 5;
		SaveFolderBrowserButton.Text = "...";
		SaveFolderBrowserButton.UseVisualStyleBackColor = true;
		SaveFolderBrowserButton.Click += SaveFolderBrowserButton_Click;
		// 
		// ClassPrefixLabel
		// 
		ClassPrefixLabel.AutoSize = true;
		ClassPrefixLabel.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
		ClassPrefixLabel.Location = new Point(20, 91);
		ClassPrefixLabel.Name = "ClassPrefixLabel";
		ClassPrefixLabel.Size = new Size(161, 38);
		ClassPrefixLabel.TabIndex = 6;
		ClassPrefixLabel.Text = "Class Prefix";
		ClassPrefixLabel.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// ClassPrefixTextBox
		// 
		ClassPrefixTextBox.CharacterCasing = CharacterCasing.Upper;
		ClassPrefixTextBox.Font = new Font("Malgun Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
		ClassPrefixTextBox.Location = new Point(200, 89);
		ClassPrefixTextBox.MaxLength = 1;
		ClassPrefixTextBox.Name = "ClassPrefixTextBox";
		ClassPrefixTextBox.Size = new Size(56, 42);
		ClassPrefixTextBox.TabIndex = 2;
		ClassPrefixTextBox.TextAlign = HorizontalAlignment.Center;
		// 
		// UnrealClassGenerator
		// 
		AutoScaleDimensions = new SizeF(12F, 30F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1150, 254);
		Controls.Add(ClassPrefixTextBox);
		Controls.Add(ClassPrefixLabel);
		Controls.Add(SaveFolderBrowserButton);
		Controls.Add(GenerateClassFilesButton);
		Controls.Add(ClassNameTextBox);
		Controls.Add(ClassNameLabel);
		Controls.Add(SavePathTextBox);
		Controls.Add(SavePathLabel);
		Name = "UnrealClassGenerator";
		Text = "Unreal Class Generator";
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Label SavePathLabel;
	private TextBox SavePathTextBox;
	private Label ClassNameLabel;
	private TextBox ClassNameTextBox;
	private Button GenerateClassFilesButton;
	private Button SaveFolderBrowserButton;
	private Label ClassPrefixLabel;
	private TextBox ClassPrefixTextBox;
}
