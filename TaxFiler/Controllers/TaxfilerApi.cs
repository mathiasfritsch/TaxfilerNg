using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaxFiler.DB;
using TaxFiler.Model.Dto;
using TaxFiler.Service;

namespace TaxFiler.Controllers;

[Authorize]
[Route("api/documents")]
[ApiController]
public class TaxFilerApi(TaxFilerContext taxFilerContext,IDocumentService documentService) : ControllerBase
{

    [Route("testcontext")]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<DocumentDto>>> TestContext(string yearMonth)
    {
        string message = "";
        
        try
        {
            var  documents = await taxFilerContext.Documents.ToListAsync();
            message = "could read documents";
        }
        catch (Exception e)
        {
            message = e.ToString();
        }

        return Ok(message);
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<DocumentDto>>> GetDocuments(string yearMonth)
    {
        var date = Common.GetYearMonth(yearMonth);
        var documents = await documentService.GetDocumentsAsync(new DateOnly(date.Year, date.Month, 1));
        return Ok(documents);
    }

}