using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingAlgorithms.LeetCode.Easy
{
    /*
        In a town, there are N people labelled from 1 to N.  
        There is a rumor that one of these people is secretly the town judge.

        If the town judge exists, then:

        The town judge trusts nobody.
        Everybody (except for the town judge) trusts the town judge.
        There is exactly one person that satisfies properties 1 and 2.
        You are given trust, an array of pairs trust[i] = [a, b] 
        representing that the person labelled a trusts the person labelled b.

        If the town judge exists and can be identified, return the label of the town judge.  
        Otherwise, return -1.
    */
    public class FindTownJudge
    {
        public int FindJudge(int N, int[][] trust)
        {
            if(trust.GetLength(0) < N-1) return -1;
            
            int[] indegrees = new int[N + 1];
            int[] outdegrees = new int[N + 1];
            
            foreach(int[] relation in trust)
            {
                outdegrees[relation[0]]++;
                indegrees[relation[1]]++;
            }
            
            for(int i=1; i<=N; i++)
            {
                if(indegrees[i] == N - 1 && outdegrees[i] == 0) return i;
            }
            
            return -1;  
        }
    }
}