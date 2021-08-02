using System;
using static System.Console;
public class EcoTankPrinter : IPrinter
{
    int jobId = 0;
    public void PowerOn()=>WriteLine("Printer ON");
    public void PowerOff()=>WriteLine("Printer OFF");
    public int Submit(PrintJob job)
    {
        WriteLine($"Received Job {job}");
        TryPrint();
        return jobId++;
    }
    public bool Cancel(int jobId)
    {
        WriteLine($"Cancelled Job {jobId}");
        return true;
    }

    public bool IsCartridgeEmpty()
    {
        // Assume tank is full always
        // But this is wrong, the tank can become empty 
        // we don't have a mechanism to find out
        return false; 
    }

    private bool TryPrint()
    {
        // We don't know when the ink runs out. Since the tank can be continously topped up
        // If the print fails we should return false.
        // For this example we assume this to be true always.
        return true;
    }
}