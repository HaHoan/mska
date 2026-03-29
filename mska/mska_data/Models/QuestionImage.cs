using System;
using System.Collections.Generic;

namespace mska_data.Models;

public partial class QuestionImage
{
    public int Id { get; set; }

    public int? QuestionId { get; set; }

    public string? ImageUrl { get; set; }

    public virtual Question? Question { get; set; }
}
