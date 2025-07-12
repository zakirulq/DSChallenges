using System;

public class CourseScheduleTest
{
    public static void TestCourseSchedule()
    {
        Console.WriteLine("--- Testing Course Schedule II ---");
        CourseScheduleSolution sol = new CourseScheduleSolution();

        int numCourses1 = 4;
        int[][] prerequisites1 = new int[][]
        {
            new int[] {1, 0},
            new int[] {2, 0},
            new int[] {3, 1},
            new int[] {3, 2}
        };
        int[] result1 = sol.FindOrder(numCourses1, prerequisites1);
        Console.WriteLine($"Course order for 4 courses with prerequisites [[1,0],[2,0],[3,1],[3,2]]: [{string.Join(", ", result1)}]");
        // Expected: [0, 1, 2, 3] or [0, 2, 1, 3] (valid topological order)

        int numCourses2 = 2;
        int[][] prerequisites2 = new int[][]
        {
            new int[] {1, 0}
        };
        int[] result2 = sol.FindOrder(numCourses2, prerequisites2);
        Console.WriteLine($"Course order for 2 courses with prerequisites [[1,0]]: [{string.Join(", ", result2)}]");
        // Expected: [0, 1]

        int numCourses3 = 1;
        int[][] prerequisites3 = new int[][] { };
        int[] result3 = sol.FindOrder(numCourses3, prerequisites3);
        Console.WriteLine($"Course order for 1 course with no prerequisites: [{string.Join(", ", result3)}]");
        // Expected: [0]

        int numCourses4 = 2;
        int[][] prerequisites4 = new int[][]
        {
            new int[] {1, 0},
            new int[] {0, 1}
        };
        int[] result4 = sol.FindOrder(numCourses4, prerequisites4);
        Console.WriteLine($"Course order for 2 courses with cyclic prerequisites [[1,0],[0,1]]: [{string.Join(", ", result4)}]"); // Expected: []
         Console.WriteLine();
    }
} 