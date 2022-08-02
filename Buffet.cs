class Buffet
{
    public List<IConsumable> Menu;

    public Buffet()
    {
        Menu = new List<IConsumable>()
        {
            new Food("Buffalo chicken", 1000, true, false),
            new Food("Sweet and sour chicken", 1500, false, true),
            new Food("Shrimp scampi", 900, false, false),
            new Food("Spaghetti", 500, false, false),
            new Food("Chicken caesar salad", 400, false, false),
            new Food("Pizza", 1500, false, false),
            new Food("Apple pie", 500, false, true),
            new Drink("Coca Cola", 200, false, true),
            new Drink("Apple cider", 150, false, true),
            new Drink("Cranberry juice", 100, false, true)
        };
    }

    public IConsumable Serve()
    {
        Random rand = new Random();
        IConsumable item = Menu[rand.Next(Menu.Count())];
        return item;
    }
}