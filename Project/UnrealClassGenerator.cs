namespace UnrealClassGenerator;

using System.Text;
using System.Text.RegularExpressions;
using Scriban;

public partial class UnrealClassGenerator : Form
{
	private FolderBrowserDialog folderBrowserDialog;

	public UnrealClassGenerator()
	{
		InitializeComponent();

		folderBrowserDialog = new FolderBrowserDialog();
	}

	private void SaveFolderBrowserButton_Click(object sender, EventArgs e)
	{
		if (SavePathTextBox.Text != "" && IsValidPath(SavePathTextBox.Text))
			folderBrowserDialog.SelectedPath = SavePathTextBox.Text;

		if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			SavePathTextBox.Text = folderBrowserDialog.SelectedPath;
	}

	private void GenerateClassFilesButton_Click(object sender, EventArgs e)
	{
		if (SavePathTextBox.Text.Length == 0 || ClassNameTextBox.Text.Length == 0)
			return;

		if (IsValidPath(SavePathTextBox.Text) == false)
			return;

		string savePath = SavePathTextBox.Text;
		string prefix = ClassNameTextBox.Text.Substring(startIndex: 0, length: 1);
		string name = ClassNameTextBox.Text.Substring(startIndex: 1);

		const string headerTemplateFilePath = "Templates/HeaderTemplate.txt";
		string headerTemplateContent = File.ReadAllText(headerTemplateFilePath);
		Template headerTemplate = Template.ParseLiquid(headerTemplateContent);
		string headerResult = headerTemplate.Render(new { data = new { prefix, name } });
		File.WriteAllText($"{savePath}/{name}.h", headerResult, Encoding.UTF8);

		const string sourceTemplateFilePath = "Templates/ClassTemplate.txt";
		string sourceTemplateContent = File.ReadAllText(sourceTemplateFilePath);
		Template sourceTemplate = Template.ParseLiquid(sourceTemplateContent);
		string sourceResult = sourceTemplate.Render(new { data = new { prefix, name } });
		File.WriteAllText($"{savePath}/{name}.cpp", sourceResult, Encoding.UTF8);
	}

	private bool IsValidPath(string path)
	{
		if (path.Length < 3)
			return false;

		Regex driveCheck = new Regex(@"^[a-zA-Z]:\\$");
		if (driveCheck.IsMatch(path.Substring(0, 3)) == false)
			return false;

		string invalidPathChars = new string(Path.GetInvalidPathChars());
		invalidPathChars += @":/?*" + "\"";

		Regex regexInvalidPath = new Regex("[" + Regex.Escape(invalidPathChars) + "]");
		if (regexInvalidPath.IsMatch(path.Substring(3, path.Length - 3)))
			return false;

		try
		{
			DirectoryInfo dir = new DirectoryInfo(Path.GetFullPath(path));
			if (dir.Exists == false)
			{
				string drive = Path.GetPathRoot(path);
				if (Directory.Exists(drive) == false)
				{
					return false;
				}
			}
		}
		catch
		{
			return false;
		}

		return true;
	}
}
