namespace AttributeDemo
{
    [Discription(Description="这是公开课学员")]
    public class StudentOpen:Student
    {
        public override void Study(){
            System.Console.WriteLine("公开课学员学习");
        }
    }
}