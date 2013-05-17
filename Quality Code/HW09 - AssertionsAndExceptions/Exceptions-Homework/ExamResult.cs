using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentException("The grade cannot be negative value");
        }
        if (minGrade < 0)
        {
            throw new ArgumentException("The minimal grade cannot be negative value");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("The maximal grade cannot be smaller than the minimal grade");
        }
        if (comments == null || comments == string.Empty)
        {
            throw new ArgumentNullException("The comments provided cannot be null or empty");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
