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
        while(true)
        {
            printer.Submit(new PrintJob("Doc.pdf"));
        }
        printer.PowerOff();
    }
}