try
{
    IPrinter tvs = new DotMatrixPrinter();

    PrinterDriver driver = new PrinterDriver(tvs);
    driver.Run();
}
catch(System.InvalidOperationException)
{
    System.Console.WriteLine("Please replace cartridge.");
}