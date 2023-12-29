using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class GestionCorreoExencion
{
    public int CodigoGestionCorreoExtencion { get; set; }

    public int CodigoEstablecimiento { get; set; }

    public int CodigoUsuarioAplicacionExterna { get; set; }

    public int CodigoArancel { get; set; }

    public bool? SiempreEnviarExencion { get; set; }

    public bool? NuncaEnviarExencion { get; set; }

    public bool? EnviarCopiaExencion { get; set; }

    public virtual Arancel CodigoArancelNavigation { get; set; } = null!;

    public virtual Establecimiento CodigoEstablecimientoNavigation { get; set; } = null!;

    public virtual UsuarioAplicacionExterna CodigoUsuarioAplicacionExternaNavigation { get; set; } = null!;
}
