using System.Diagnostics;
using System.Reflection;

namespace WinFormsApp1;

public partial class SortForm : Form
{
    public SortForm()
    {
        InitializeComponent();
    }

    private void Reset()
    {
        txtFilePath.Text = "";
        txtSorted.Text = "";
        txtUnsorted.Text = "";
        txtWriteFilePath.Text = "";
        btnSortAsc.Enabled = false;
        btnSortDesc.Enabled = false;
        btnReset.Enabled = false;
        btnWriteFile.Enabled = false;
    }

    private void LoadFile()
    {
        try
        {
            txtUnsorted.Text = File.ReadAllText(txtFilePath.Text);
            btnSortAsc.Enabled = true;
            btnSortDesc.Enabled = true;
            btnReset.Enabled = true;
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, $"Error Reading {txtFilePath.Text}");
            return;
        }

        var path = Path.GetDirectoryName(txtFilePath.Text);
        var filename =
            $"{Path.GetFileNameWithoutExtension(txtFilePath.Text)}_sorted{Path.GetExtension(txtFilePath.Text)}";
        txtWriteFilePath.Text = $"{Path.Combine(path ?? string.Empty, filename)}";
    }

    private void WriteFile()
    {
        try
        {
            File.WriteAllText(txtWriteFilePath.Text, txtSorted.Text);
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, $"Error Writing {txtWriteFilePath.Text}");
            return;
        }
        Process.Start("notepad.exe", txtWriteFilePath.Text);
        MessageBox.Show($"Wrote sorted numbers to {txtWriteFilePath.Text}.", "Write Successful");
    }

    private void btnPickFile_Click(object sender, EventArgs e)
    {
        var fileDialog = new OpenFileDialog();
        fileDialog.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        if (fileDialog.ShowDialog() != DialogResult.OK)
        {
            Reset();
            return;
        }

        txtFilePath.Text = fileDialog.FileName;
        LoadFile();
    }

    private int[] ConvertTextToInt()
    {
        if (string.IsNullOrWhiteSpace(txtUnsorted.Text)) return Array.Empty<int>();
        var lines = txtUnsorted.Text.Split("\r\n");
        var newArray = new int[lines.Length];
        for (var i = 0; i < lines.Length; i++)
            if (int.TryParse(lines[i], out var num))
            {
                newArray[i] = num;
            }
            else
            {
                MessageBox.Show(
                    $"Line {i + 1} contains a non-numeric value: {lines[i]}", $"Could Not Read Line {i + 1}");
                return Array.Empty<int>();
            }

        return newArray;
    }

    private void ShowSortedNumbers(int[] numbers)
    {
        txtSorted.Text = string.Join("\r\n", numbers);
        btnWriteFile.Enabled = true;
    }

    private void btnSortAsc_Click(object sender, EventArgs e)
    {
        var numbers = ConvertTextToInt();
        if (numbers.Length == 0) return;
        var sorted = SortArray(numbers);
        ShowSortedNumbers(sorted);
    }

    private void btnSortDesc_Click(object sender, EventArgs e)
    {
        var numbers = ConvertTextToInt();
        if (numbers.Length == 0) return;
        var sorted = SortArray(numbers, SortDescending);
        ShowSortedNumbers(sorted);
    }
    
    private const bool SortDescending = false;

    private static int[] SortArray(int[] toSort, bool ascending = true)
    {
        for (var outer = 0; outer < toSort.Length; outer++)
        {
            var toSwapIdx = outer;
            for (var inner = outer + 1; inner < toSort.Length; inner++)
                if (ascending)
                {
                    if (toSort[inner] < toSort[toSwapIdx]) toSwapIdx = inner;
                }
                else
                {
                    if (toSort[inner] > toSort[toSwapIdx]) toSwapIdx = inner;
                }

            var temp = toSort[outer];
            toSort[outer] = toSort[toSwapIdx];
            toSort[toSwapIdx] = temp;
        }

        return toSort;
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        Reset();
    }
    
    private void btnWrite_Click(object sender, EventArgs e)
    {
        WriteFile();
    }
}