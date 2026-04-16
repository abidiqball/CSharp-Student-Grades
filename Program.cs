int currentAssignments= 5;

int sophia1=93, sophia2=87, sophia3=98, sophia4=95, sophia5=100;
int sophiaSum= sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
decimal sophiaAverage= (decimal)sophiaSum/(decimal)currentAssignments;

int nicolas1=80, nicolas2=83, nicolas3=82, nicolas4=88, nicolas5=85;
int nicolasSum= nicolas1+nicolas2+nicolas3+nicolas4+nicolas5;
decimal nicolasAverage= (decimal)nicolasSum/currentAssignments;

int zahirah1 = 84, zahirah2 = 96, zahirah3 = 73, zahirah4 = 85, zahirah5 = 79;
int zahirahSum= zahirah1+zahirah2+zahirah3+zahirah4+zahirah5;
decimal zahirahAverage= (decimal)zahirahSum/currentAssignments;

int jeong1 = 90, jeong2 = 92, jeong3 = 98, jeong4 = 100, jeong5 = 97;
int jeongSum= jeong1 + jeong2 + jeong3 + jeong4 + jeong5;
decimal jeongAverage= (decimal)jeongSum/currentAssignments;

Console.WriteLine("Student  Score\tAverage\tGrade \n");
Console.WriteLine($"Sophia:  {sophiaSum}\t {sophiaAverage}\t A");
Console.WriteLine($"Nicolas: {nicolasSum}\t {nicolasAverage}\t B");
Console.WriteLine($"Zahirah: {zahirahSum}\t {zahirahAverage}\t B");
Console.WriteLine($"Jeong:   {jeongSum}\t {jeongAverage}\t A");
