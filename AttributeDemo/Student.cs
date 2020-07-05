namespace AttributeDemo
{
    public class Student
    {
        public int Id{get;set;}

        public string Name{get;set;}

        public virtual void Study(){
            System.Console.WriteLine("学生基础学习");
        }
    }
}