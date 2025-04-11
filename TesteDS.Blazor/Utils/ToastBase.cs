namespace TesteDS.Blazor.Utils
{
    using Radzen;

    public class ToastBase
    {
        private NotificationService _notificationService;

        public void Init(NotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        private void Show(NotificationSeverity severity, string summary, string detail, double duration)
        {
            _notificationService.Notify(new NotificationMessage
            {
                Severity = severity,
                //Summary = summary,
                Detail = detail,
                Duration = duration,
                Style = "color: white; font-weight: bold;",
            });
        }

        public void Success(string message, string titulo = "Sucesso", double duration = 3000)
        {
            Show(NotificationSeverity.Success, titulo, message, duration);
        }

        public void Warning(string message, string titulo = "Atenção", double duration = 3000)
        {
            Show(NotificationSeverity.Warning, titulo, message, duration);
        }

        public void Error(string message, string titulo = "Erro", double duration = 3000)
        {
            Show(NotificationSeverity.Error, titulo, message, duration);
        }

        public void Info(string message, string titulo = "Informação", double duration = 3000)
        {
            Show(NotificationSeverity.Info, titulo, message, duration);
        }
    }

}
