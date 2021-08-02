using System;
public class InkCartridge
{
    int AvailableCount;
    string InkType;
    public InkCartridge(string InkType,int AvailableInk)
    {
        AvailableCount = AvailableInk;
        this.InkType = InkType;
    }

    public void Consume(int count)
    {
        if(AvailableCount<count)
            throw new InvalidOperationException("Cartridge empty");
        AvailableCount-=count;
    }

    public bool IsEmpty()=> AvailableCount == 0;
}