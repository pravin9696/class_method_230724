using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace class_method_230724
{
   
    internal class Student
    {
        double per;
        string Grade;
        private int[] subMarks =new int[6];
        public void setSubMarks(int[] sm)
        {
            for (int i = 0; i <subMarks.Length; i++)
            {
                subMarks[i] = sm[i];
            }
           
        }
        public void calculatePer()
        {
           
            int totalMarks=0;
            for (int i = 0; i < subMarks.Length; i++)
            {
                totalMarks = totalMarks + subMarks[i];
            }
            per= (totalMarks)/((double)6);
            Console.WriteLine("per ="+per);
        }
        public void checkGrades()
        {
            
            if (per>75 && per<=100)
            {
                Grade = "distinction";
            }
            else if(per>60 && per<=75)
            {
                Grade = "First division";
            }
            else if (per >50 && per<=60)
            {
                Grade = "Second Division";
            }
            else if (per >= 40 && per <= 50)
            {
                Grade = "Third Division";
            }
            else if (per<40)
            {
                Grade = "Fail";
            }
            //Console.WriteLine("Per= "+per);
            Console.WriteLine("Grade= "+Grade);
        }
    }
}
