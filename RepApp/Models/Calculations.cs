using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepApp.Models
{
    public static class Calculations
    {
        public static int[] CalculateLadder(int reps)
        {
            int totalReps = 0;
            int totalSets = 0;

            for (int i = 1; i <= reps; i++)
            {
                totalReps += i;
                totalSets++;
            }

            int[] output = new int[2];
            output[0] = totalReps;
            output[1] = totalSets;

            return output;
        }

        public static int[] CalculatePyramid(int reps)
        {
            int[] partialResult = CalculateLadder(reps);
            int totalReps = (partialResult[0] * 2) - reps;
            int totalSets = (partialResult[1] * 2) - 1;

            int[] output = new int[2];
            output[0] = totalReps;
            output[1] = totalSets;

            return output;
        }

        public static int[] CalculateM(int reps)
        {
            int[] partialResult = CalculatePyramid(reps);
            int totalReps = (partialResult[0] * 2) - 1;
            int totalSets = (partialResult[1] * 2) - 1;

            int[] output = new int[2];
            output[0] = totalReps;
            output[1] = totalSets;

            return output;
        }

        public static int[] CalculateV(int reps)
        {
            int[] partialResult = CalculateLadder(reps);
            int totalReps = (partialResult[0] * 2) - 1;
            int totalSets = (partialResult[1] * 2) - 1;

            int[] output = new int[2];
            output[0] = totalReps;
            output[1] = totalSets;

            return output;
        }

        public static int[] CalculateW(int reps)
        {
            int[] partialResult = CalculateV(reps);
            int totalReps = (partialResult[0] * 2) - reps;
            int totalSets = (partialResult[1] * 2) - 1;

            int[] output = new int[2];
            output[0] = totalReps;
            output[1] = totalSets;

            return output;
        }
    }
}
