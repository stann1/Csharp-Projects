﻿using System;

public class SimpleMathExam : Exam
{
    public int ProblemsSolved { get; private set; }

    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0)
        {
            problemsSolved = 0;
        }
        if (problemsSolved > 10)
        {
            problemsSolved = 10;
        }

        this.ProblemsSolved = problemsSolved;
    }

    public override ExamResult Check()
    {
        if (ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: 1 problem solved.");
        }
        else if (ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Excellent result: all tasks were done.");
        }

        throw new ArgumentOutOfRangeException("Invalid number of problems solved!");
    }
}
