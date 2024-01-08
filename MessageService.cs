namespace EventsANDDelegates
{
    //builing a subcriber for sending a text message

    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("messageService: Sending a text message...");
        }
    }
}