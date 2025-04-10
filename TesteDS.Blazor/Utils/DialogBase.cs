using Microsoft.AspNetCore.Components;
using Radzen;

namespace TesteDS.Blazor.Utils
{
    public class DialogBase
    {
        private readonly DialogService _dialogService;

        public DialogBase(DialogService dialogService)
        {
            _dialogService = dialogService;
        }

        public async Task<object> AbrirDialogRet(string titulo, RenderFragment conteudo, string largura = "auto", string altura = "auto")
        {
            var opcoes = new DialogOptions
            {
                Width = largura,
                Height = altura,
                Style = "border-radius: 12px; box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.2);",
                CloseDialogOnEsc = true,
                CloseDialogOnOverlayClick = true
            };

            return await _dialogService.OpenAsync(titulo, ds => conteudo, opcoes);
        }

        public async Task AbrirDialog(string titulo, RenderFragment conteudo, string largura = "auto", string altura = "auto")
        {
            var opcoes = new DialogOptions
            {
                Width = largura,
                Height = altura,
                Style = "border-radius: 12px; box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.2);",
                CloseDialogOnEsc = true,
                CloseDialogOnOverlayClick = true
            };

            await _dialogService.OpenAsync(titulo, ds => conteudo, opcoes);
        }
    }
}
