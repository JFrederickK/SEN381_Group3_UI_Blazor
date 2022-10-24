namespace SEN381_UI.Data;

public class CallDetails
{
    string callDetailsID;
    DateTime startTime;
    DateTime endTime;

    public CallDetails(string callDetailsID, DateTime startTime, DateTime endTime)
    {
        this.callDetailsID = callDetailsID;
        this.startTime = startTime;
        this.endTime = endTime;
    }

    public CallDetails()
    {
    }

    public string CallDetailsID { get => callDetailsID; set => callDetailsID = value; }
    public DateTime StartTime { get => startTime; set => startTime = value; }
    public DateTime EndTime { get => endTime; set => endTime = value; }

    public void startTimer()
    {
        //Implement Logic
    }

    public void endTimer()
    {
        //Implement Logic
    }
}