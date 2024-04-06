using System;
using System.Collections.Generic;

namespace web.Data;

public partial class TbSubscribe
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
