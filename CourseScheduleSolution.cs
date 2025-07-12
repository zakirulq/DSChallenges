
using System.Collections.Generic;

// Solution for Course Schedule II
public class CourseScheduleSolution
{
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        var adj = new Dictionary<int, List<int>>();
        var inDegree = new int[numCourses];
        var sortedOrder = new List<int>();

        for (int i = 0; i < numCourses; i++)
        {
            adj[i] = new List<int>();
        }

        foreach (var p in prerequisites)
        {
            int course = p[0];
            int prereq = p[1];
            adj[prereq].Add(course);
            inDegree[course]++;
        }

        var queue = new Queue<int>();
        for (int i = 0; i < numCourses; i++)
        {
            if (inDegree[i] == 0)
            {
                queue.Enqueue(i);
            }
        }

        while (queue.Count > 0)
        {
            int course = queue.Dequeue();
            sortedOrder.Add(course);

            if (adj.ContainsKey(course))
            {
                foreach (var neighbor in adj[course])
                {
                    inDegree[neighbor]--;
                    if (inDegree[neighbor] == 0)
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }

        if (sortedOrder.Count == numCourses)
        {
            return sortedOrder.ToArray();
        }

        return new int[0];
    }
}
