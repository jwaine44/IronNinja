Buffet buffet = new Buffet();
SweetTooth sweetTooth = new SweetTooth();
SpiceHound spiceHound = new SpiceHound();

Console.WriteLine("sweetTooth's consumed food:");
while (sweetTooth.IsFull == false)
{
    sweetTooth.Consume(buffet.Serve());
}

Console.WriteLine("spiceHound's consumed food:");
while (spiceHound.IsFull == false)
{
    spiceHound.Consume(buffet.Serve());
}