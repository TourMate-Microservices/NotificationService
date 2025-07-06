﻿using System;
using System.Collections.Generic;

namespace TourMate.NotificationService.Repositories.Models;

public partial class Notification
{
    public int NotificationId { get; set; }

    public int ReceiverAccountId { get; set; }

    public string Message { get; set; } = null!;

    public string? Link { get; set; }

    public bool IsRead { get; set; }

    public DateTime CreatedAt { get; set; }
}
