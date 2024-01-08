namespace EventsANDDelegates
{
    public class MailService
    {
        //creating a method below

        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService: sending an email...");
        }
    }
}