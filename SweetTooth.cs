class SweetTooth : Ninja
{
    public override bool IsFull
    {
        get
        {
            if (calorieIntake >= 1500)
            {
                return true;
            }
            return false;
        }
    }
    public override void Consume(IConsumable item)
    {
        if (IsFull)
        {
            Console.WriteLine("The ninja is full and can't eat anymore.");
        }
        else
        {
            ConsumptionHistory.Add(item);
            calorieIntake += item.Calories;

            if(item.IsSweet)
            {
                calorieIntake += 10;
            }
            Console.WriteLine(item.GetInfo());
        }
    }
}