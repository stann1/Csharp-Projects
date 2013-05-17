using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IList<Exam> Exams { get; set; }

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        if (firstName == null || firstName == string.Empty)
        {
            throw new ArgumentNullException("The first name cannot be null or empty");
        }
        if (lastName == null || lastName == string.Empty)
        {
            throw new ArgumentNullException("The last name cannot be null or empty");
        }

        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public IList<ExamResult> CheckExams()
    {        
        if (this.Exams.Count == 0 || this.Exams == null)
        {
            throw new ArgumentNullException(string.Format("The student {0} {1} has no exams in the records", this.FirstName, this.LastName));
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null || this.Exams.Count == 0)
        {
            throw new ArgumentNullException(string.Format("No average can be calculated because the student {0} {1} has no exams in the records",
                this.FirstName, this.LastName));
        }
        
        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
