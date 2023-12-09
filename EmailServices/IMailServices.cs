
using LinkedOut.DTOs.RequestModels;

namespace LinkedOut.EmailServices
{
    public interface IMailServices
    {
       public void SendEMailAsync(MailRequest mailRequest);
    }
}
