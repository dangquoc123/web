﻿using System;
using System.Collections.Generic;

namespace web.Data;

public partial class TbOrder
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Address { get; set; } = null!;

    public decimal TotalAmount { get; set; }

    public int Quantity { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? Modifiedby { get; set; }

    public int TypePayment { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<TbOrderDetail> TbOrderDetails { get; set; } = new List<TbOrderDetail>();
}
