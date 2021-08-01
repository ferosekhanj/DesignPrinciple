public record PrintJob(string Document);
public interface IPrinter
{
    void PowerOn();
    void PowerOff();
    int Submit(PrintJob job);
    bool Cancel(int jobId);
    bool IsCartridgeEmpty();
}