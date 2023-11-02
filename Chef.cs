namespace Giraffe
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        public virtual void MakeSpecialDish() //상속 키워드
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}