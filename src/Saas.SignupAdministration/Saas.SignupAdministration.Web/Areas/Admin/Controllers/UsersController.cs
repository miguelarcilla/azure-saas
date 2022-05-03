namespace Saas.SignupAdministration.Web.Areas.Admin.Controllers;

[Area("Admin")]
[Controller]
[Route("[area]/tenants/{tenantid}/users")]
public class UsersController : Controller
{
    private readonly IAdminServiceClient _adminServiceClient;

    public UsersController(IAdminServiceClient adminServiceClient)
    {
        _adminServiceClient = adminServiceClient;
    }

    [HttpGet]
    public async Task<IActionResult> Index(string tenantid)
    {
        var users = await _adminServiceClient.UsersAsync(tenantid);
        return View(users);
    }
}
