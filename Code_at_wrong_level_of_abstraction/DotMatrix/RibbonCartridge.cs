using System;
public class RibbonCartridge
{
    int AvailableCount;

    public RibbonCartridge()
    {
        AvailableCount = 10;
    }

    public void Consume(int count)
    {
        if(AvailableCount<count)
            throw new InvalidOperationException("Cartridge empty");
        AvailableCount-=count;
    }

    public bool IsEmpty()=> AvailableCount == 0;
}