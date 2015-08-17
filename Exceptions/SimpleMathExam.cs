using System;

public class SimpleMathExam : Exam
{
    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved 
    {
        get
        {
            return this.problemsSolved;
        }

        private set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentOutOfRangeException("Solved problems should be in range [1..10]!");
            }

            this.problemsSolved = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved <= 4)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (this.ProblemsSolved > 8)
        {
            return new ExamResult(6, 2, 6, "Excellent result: everything done.");
        }
        else
        {
            return new ExamResult(4, 2, 6, "Average result: half done.");
        }
    }
}
