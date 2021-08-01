public class PrinterDriver
{
    IPrinter printer;
    public PrinterDriver(IPrinter printer)
    {
        this.printer = printer;
    }
    public void Run()
    {
        printer.PowerOn();
        while(!printer.IsCartridgeEmpty())
        {
            printer.Submit(new PrintJob("Doc.pdf"));
        }
        System.Console.WriteLine("Printer Cartridge empty!!");
        printer.PowerOff();
    }
}