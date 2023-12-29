using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EmpresaDeEntrega
{
    public short CodigoEmpresaDeEntrega { get; set; }

    public string? Nombre { get; set; }

    public string? Telefono { get; set; }

    public string? Prefijo { get; set; }

    public string? CorreosAcreditacion { get; set; }

    public string? TituloCorreoAcreditacion { get; set; }

    public string? EncabezadoCorreoAcreditacion { get; set; }

    public int? DiasAcreditacionAtrasada { get; set; }

    public int? CodigoCuentaDeposito { get; set; }

    public string? CorreosApi { get; set; }

    public int? CodigoCuentaContablePorCobrar { get; set; }

    public bool EnviarCorreoGuia { get; set; }

    public bool? AplicaCod { get; set; }

    public bool? ModificaDireccion { get; set; }

    public bool? GenerarGuiaGd { get; set; }

    public bool? AplicaManifiesto { get; set; }

    public bool Activo { get; set; }

    public string? UrlRastreoGuia { get; set; }

    public bool AplicaRecoleccion { get; set; }

    public virtual ICollection<BitacoraPorcentajeCod> BitacoraPorcentajeCods { get; set; } = new List<BitacoraPorcentajeCod>();

    public virtual CuentaContable? CodigoCuentaContablePorCobrarNavigation { get; set; }

    public virtual Cuentum? CodigoCuentaDepositoNavigation { get; set; }

    public virtual ICollection<EstadoEntregaEmpresaDeEntrega> EstadoEntregaEmpresaDeEntregas { get; set; } = new List<EstadoEntregaEmpresaDeEntrega>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<GuiaEliminadum> GuiaEliminada { get; set; } = new List<GuiaEliminadum>();

    public virtual ICollection<GuiaReclamadum> GuiaReclamada { get; set; } = new List<GuiaReclamadum>();

    public virtual ICollection<MotivoRetornoEmpresaDeEntrega> MotivoRetornoEmpresaDeEntregas { get; set; } = new List<MotivoRetornoEmpresaDeEntrega>();

    public virtual ICollection<MunicipioEmpresaDeEntrega> MunicipioEmpresaDeEntregas { get; set; } = new List<MunicipioEmpresaDeEntrega>();

    public virtual ICollection<Empaque> CodigoEmpaques { get; set; } = new List<Empaque>();

    public virtual ICollection<FormaDeEnvio> CodigoFormaDeEnvios { get; set; } = new List<FormaDeEnvio>();
}
