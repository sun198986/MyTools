namespace AttributeDemo
{
    [Discription(Description="这是VIP课学员")]

    public class StudentVip:Student
    {
        public override void Study(){
            System.Console.WriteLine("VIP学员学习");
        }
    }
}