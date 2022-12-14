class Drink : IConsumable
{
    public string Name {get;set;}
    public int Calories {get;set;}
    public bool IsSpicy {get;set;}
    public bool IsSweet {get;set;}
    public string GetInfo()
    {
        return $"{Name} (Drink). Calories: {Calories}. Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
    }

    public Drink(string drinkName, int calories, bool spicy, bool sweet)
    {
        Name = drinkName;
        Calories = calories;
        IsSpicy = spicy;
        IsSweet = sweet;
    }
}