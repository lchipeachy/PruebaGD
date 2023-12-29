using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ProductoElementoRobot
{
    public int? CodigoProducto { get; set; }

    public int? CodigoElementoRobot { get; set; }

    public DateTime? Fecha { get; set; }

    public virtual ElementoRobot? CodigoElementoRobotNavigation { get; set; }
}
