public class MathAssignment: Assignment
{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(
        string studentName,
        string tipic,
        string textbookSection,
        string problems) : base(studentName, tipic)  
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}