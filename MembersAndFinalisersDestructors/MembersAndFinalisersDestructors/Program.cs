namespace MembersAndFinalisersDestructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Members member1 = new Members();

            member1.JobTitle = "Accountant";
            member1.Introducing(false);
        }
    }
}
