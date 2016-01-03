namespace LinqExercise
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class LinqExercise
    {
        public static void Main()
        {
            const string FilePath = @"../../Students-data.txt";

            List<string> result = new List<string>();

            StreamReader readData = new StreamReader(FilePath);
            string headerLine = readData.ReadLine();

            string line;
            while ((line = readData.ReadLine()) != null)
            {
                result.Add(line);
            }

            List<Student> students = new List<Student>();


           
            // TODO need help reading the data from a file, the rest is correct :(((


            foreach (var data in result)
            {
                string[] tokens = data.Split();

                int id = int.Parse(tokens[0]);
                string firstName = tokens[1];
                string lastName = tokens[2];
                string email = tokens[3];
                string gender = tokens[4];
                string studentType = tokens[5];
                int examResult = int.Parse(tokens[6]);
                int homeworksSent = int.Parse(tokens[7]);
                int homeworksEvaluated = int.Parse(tokens[8]);
                double teamworkScore = double.Parse(tokens[9]);
                int attendancesCount = int.Parse(tokens[10]);
                double bonus = double.Parse(tokens[11]);

                students.Add(new Student(
                    id,
                    firstName,
                    lastName,
                    email,
                    gender,
                    studentType,
                    examResult,
                    homeworksSent,
                    homeworksEvaluated,
                    teamworkScore,
                    attendancesCount,
                    bonus)); 
            }

            // TODO write LINQ queries here

            //Extract all male students and print them on the console

            var maleStudents = students
                .Where(x => x.Gender.ToLower() == "male");

            //foreach (var item in maleStudents)
            //{
            //    Console.WriteLine("{0} {1} - {2}",item.FirstName, item.LastName, item.Gender);
            //}

            //Extract all students whose first names start with the letter 'A' and print them on the console.

            var studentsWithLetterA=students
                .Where(x=>x.FirstName.StartsWith("A"));

            //foreach (var student in studentsWithLetterA)
            //{
            //    Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            //}

            //•	Extract all online students with exam score greater than or equal to 350 and print them on the console.

            var onlineStudentsScoreMoreThan350 = students
                .Where(x => x.StudentType == "Online" && x.ExamResult >= 350);

            //foreach (var student in onlineStudentsScoreMoreThan350)
            //{
            //    Console.WriteLine("{0} - {1}",student, student.ExamResult);
            //}

            //•	Extract all online students with score >= 300, 
            //order them by exam score in descending order and print them on the console.

            var onlineStudentsSortedMoreThan300 = students
                .Where(x => x.ExamResult >= 300)
                .OrderByDescending(x => x.ExamResult);

            //foreach (var student in onlineStudentsSortedMoreThan300)
            //{
            //    Console.WriteLine("{0} - {1}", student, student.ExamResult);
            //}

            /*•	Extract all students without any  homework sent, 
             * order them by first name, then by last name and print them on the console.*/

            var studentsWithoutHomeworkSorted = students
                .Where(x => x.HomeworksSent == 0)
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName);

            //foreach (var student in studentsWithoutHomeworkSorted)
            //{
            //    Console.WriteLine("{0} {1} ({2} homeworks sent)",student.FirstName,student.LastName, student.HomeworksSent);
            //}

            //•	Extract the emails of all on-site students.

            var onsiteStudentsEmails = students
                .Where(x => x.StudentType == "Onsite")
                .Select(x => x.Email);

            //foreach (var email in onsiteStudentsEmails)
            //{
            //    Console.WriteLine(email);
            //}

            //•	Extract the exam results and attendance counts of all on-site students who have less than 5 attendances.

            var onsiteStudentsResultsAndAttendances = students
                .Where(student => student.StudentType == "Onsite" && student.AttendancesCount < 5)
                .Select
                (
                    student =>
                        new 
                        {
                            student.ExamResult, 
                            student.AttendancesCount 
                        }
                );

            //foreach (var item in onsiteStudentsResultsAndAttendances)
            //{
            //    Console.WriteLine("Result: {0}, attendances: {1}", item.ExamResult, item.AttendancesCount);
            //}

            //•	Find the number of students who have a bonus of 4 or more.

            var numberOfStudentsWithBonusGreaterThanFour = students
                .Where(student => student.Bonus >= 4)
                .Select(student => student.Bonus)
                .Count();

            //Console.WriteLine(numberOfStudentsWithBonusGreaterThanFour);

            //•	Find the average exam score of online and on-site students 
            //(don’t try doing it in a single query, just make two).

            var onsiteStudentsAverageScore = students
                .Where(student => student.StudentType == "Onsite")
                .Select(student => student.ExamResult)
                .Average();

            var onlineStudentsAverageScore = students
                .Where(student => student.StudentType == "Online")
                .Average(student => student.ExamResult);

            //Console.WriteLine("Online average: {0}",onlineStudentsAverageScore);

            //Console.WriteLine("Onsite average: {0}", onsiteStudentsAverageScore);

            //•	Find the number of students who have a teamwork score equal to the maximal teamwork score.

            var maxTeamScore = students.Max(student => student.TeamworkScore);

            var numberOfStudentsWithMaxTeamworkScore = students
                .Where(student =>student.TeamworkScore == maxTeamScore)
                .Count();

            //Console.WriteLine(numberOfStudentsWithMaxTeamworkScore);

            /*•	Group the students by the initials of their first names; 
             * sort the groups alphabetically and print them like the example below.*/

            var gruopedStudents = students
                .GroupBy(student => student.FirstName.FirstOrDefault())
                .OrderBy(x => x.Key);

            //foreach (var groupName in gruopedStudents)
            //{
            //    Console.WriteLine(groupName.Key);
            //    foreach (var student in groupName)
            //    {
            //        Console.WriteLine("  {0} {1}", student.FirstName, student.LastName);
            //    }
            //}

            /*•	Group the students by type (online/on-site) 
             * and sort them by exam score in descending order.*/

            var studentsByType = students
                .GroupBy(student => student.StudentType)
                .Select(type =>
                        new
                        {
                            Name = type.Key,
                            Students = type.OrderByDescending(x => x.ExamResult)
                        })
                  .OrderBy(group => group.Students.First().ExamResult);

            foreach (var type in studentsByType)
            {
                Console.WriteLine(type.Name);
                foreach (var student in type.Students)
                {
                    Console.WriteLine("  {0} {1} - {2}", student.FirstName, student.LastName, student.ExamResult);
                }
            }
                                
        }
    }
}
