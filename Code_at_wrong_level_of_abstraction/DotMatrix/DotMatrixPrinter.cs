using static System.Console;
public class DotMatrixPrinter : IPrinter
{
    int jobId = 0;
    RibbonCartridge cartridge = new RibbonCartridge();
    public void PowerOn()=>WriteLine("Printer ON");
    public void PowerOff()=>WriteLine("Printer OFF");
    public int Submit(PrintJob job)
    {
        WriteLine($"Received Job {job}");
        cartridge.Consume(2);
        return jobId++;
    }
    public bool Cancel(int jobId)
    {
        WriteLine($"Cancelled Job {jobId}");
        return true;
    }
}