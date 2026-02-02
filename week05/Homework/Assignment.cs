public class Assignment
{
    private string _studentName;
    private string _tipic;
    public Assignment(string studentName, string tipic)
    {
        _studentName = studentName;
        _tipic = tipic;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_tipic}";
    }
    public string GetStudentName()
    {
        return _studentName;
    }
}