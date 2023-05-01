
static string GetText(string path , string filename)
    {
    var reader = File.OpenText($"{AppendPathSeparator(path)}{filename}");
    var text = reader.ReadToEnd();
    return text;

    string AppendPathSeparator(string filepath)
        {
        return filepath.EndsWith(@"\") ? filepath : filepath + @"\";
        }
    }