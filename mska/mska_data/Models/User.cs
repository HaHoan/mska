using System;
using System.Collections.Generic;

namespace mska_data.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Student? Student { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
