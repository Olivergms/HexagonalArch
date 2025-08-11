
using Domain.Ports.Services;
using Microsoft.Extensions.Logging;

namespace Infra.Email.Operations;

public class FakeEmailAdapter : IEmailService
{
    private readonly ILogger<FakeEmailAdapter> _logger;

    public FakeEmailAdapter(ILogger<FakeEmailAdapter> logger)
    {
        _logger = logger;
    }

    public void SendEmail(string from, string to, string subject, string title)
    {
        var logMessage = $"Enviando e-mail: \nDe: {from}\nPara: {to}\nTitle: {title}";
        _logger.LogInformation(logMessage);

    }
}
