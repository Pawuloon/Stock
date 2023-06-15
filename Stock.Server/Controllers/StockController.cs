using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Stock.Server.Controllers;
[Authorize]
[Route("api/stock")]
public class StockController : ControllerBase
{
    
}