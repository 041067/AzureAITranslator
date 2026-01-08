using AzureAITranslator.Models;
using AzureAITranslator.Services;
using Microsoft.AspNetCore.Mvc;

namespace AzureAITranslator.Controllers;

[ApiController]
[Route("api/translate")]
public sealed class TranslateController : ControllerBase
{
    private readonly TranslatorService _translator;

    public TranslateController(TranslatorService translator)
    {
        _translator = translator;
    }

    [HttpPost]
    public async Task<IActionResult> Translate([FromBody] TranslateRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Text))
            return BadRequest("Texto para tradução é obrigatório.");

        var translated = await _translator.TranslateAsync(request.Text);

        return Ok(new
        {
            translatedText = translated
        });
    }
}
