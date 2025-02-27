namespace Domain.Events;

public class MailSentEvent
{
    public string ToEmail { get; set; }
    public string IsPersonalized { get; set; }
    public string Template { get; set; }
    public bool IsBodyHtml { get; set; }
}
