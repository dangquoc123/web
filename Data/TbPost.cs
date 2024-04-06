﻿using System;
using System.Collections.Generic;

namespace web.Data;

public partial class TbPost
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? Detail { get; set; }

    public string? Image { get; set; }

    public int CategoryId { get; set; }

    public string? SeoTitle { get; set; }

    public string? SeoDescription { get; set; }

    public string? SeoKeywords { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? Modifiedby { get; set; }

    public string? Alias { get; set; }

    public bool IsActive { get; set; }

    public virtual TbCategory Category { get; set; } = null!;
}
