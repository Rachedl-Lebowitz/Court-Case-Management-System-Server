using Microsoft.AspNetCore.Mvc;
using Notification.DAL.Services.Interfaces;
using NotificationService.BL.Services;

[ApiController]
[Route("api/[controller]")]
public class NotificationController : ControllerBase
{
    private readonly INotificationService _notificationService;

    public NotificationController(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    [HttpPost]
    public IActionResult Start()
    {
        _notificationService.Start();
        return Ok();
    }
}