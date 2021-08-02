using static System.Console;
public class InkjetPrinter : IPrinter
{
    int jobId = 0;
    InkCartridge cmy = new InkCartridge("CMY",10);
    InkCartridge black = new InkCartridge("BLACK",30);
    public void PowerOn()=>WriteLine("Printer ON");
    public void PowerOff()=>WriteLine("Printer OFF");
    public int Submit(PrintJob job)
    {
        WriteLine($"Received Job {job}");
        cmy.Consume(2);
        black.Consume(1);
        return jobId++;
    }
    public bool Cancel(int jobId)
    {
        WriteLine($"Cancelled Job {jobId}");
        return true;
    }

    public bool IsCartridgeEmpty()=>cmy.IsEmpty() || black.IsEmpty();
}