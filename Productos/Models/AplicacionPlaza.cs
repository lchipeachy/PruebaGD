using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class AplicacionPlaza
{
    public int CodigoAplicacionPlaza { get; set; }

    public int CodigoPlaza { get; set; }

    public int CodigoEstadoAplicacionPlaza { get; set; }

    public DateTime? FechaAplicacionPlaza { get; set; }

    public int? CodigoUsuarioAprobacion { get; set; }

    public DateTime? FechaAprobacion { get; set; }

    public int? CodigoUsuarioRechazo { get; set; }

    public DateTime? FechaRechazo { get; set; }

    public string? Observacion { get; set; }

    public decimal? PretensionSalarial { get; set; }

    public int CodigoCandidato { get; set; }

    public bool? RevisionCvJefatura { get; set; }

    public DateTime? FechaRegistroRevisionCvJefatura { get; set; }

    public DateTime? FechaPruebaTecnica { get; set; }

    public DateTime? FechaRegistroPruebaTecnica { get; set; }

    public bool? ConfirmaAsistencia { get; set; }

    public DateTime? FechaRegistroConfirmaAsistencia { get; set; }

    public bool? Asistencia { get; set; }

    public bool? ResultadoPruebaTecnica { get; set; }

    public DateTime? FechaRegistroResultadoPruebaTecnica { get; set; }

    public string? PruebaTecnica { get; set; }

    public DateTime? FechaRegistroDocumentoPruebaTecnica { get; set; }

    public DateTime? FechaPruebaPsicometrica { get; set; }

    public DateTime? FechaEnvioPruebaPsicometrica { get; set; }

    public string? InformePsicometrico { get; set; }

    public bool? ResultadoPruebaPsicometrica { get; set; }

    public DateTime? FechaRegistroResultadoPruebaPsicometrica { get; set; }

    public DateTime? FechaEntrevistaJefatura { get; set; }

    public DateTime? FechaRegistroEntrevistaJefatura { get; set; }

    public bool? ConfirmacionEntrevistaJefatura { get; set; }

    public DateTime? FechaRegistroConfirmacionEntrevistaJefatura { get; set; }

    public bool? AsistenciaEntrevistaJefatura { get; set; }

    public bool? ResultadoEntrevistaJefatura { get; set; }

    public DateTime? FechaResultadoEntrevistaJefatura { get; set; }

    public DateTime? FechaSolicitudReferencia { get; set; }

    public string? Referencia { get; set; }

    public bool? ResultadoReferencia { get; set; }

    public DateTime? FechaRegistroReferencia { get; set; }

    public DateTime? FechaInicioLabores { get; set; }

    public int CodigoMedioAplicacionPlaza { get; set; }

    public string? ReferenciaLaboral { get; set; }

    public virtual Candidato CodigoCandidatoNavigation { get; set; } = null!;

    public virtual EstadoAplicacionPlaza CodigoEstadoAplicacionPlazaNavigation { get; set; } = null!;

    public virtual MedioAplicacionPlaza CodigoMedioAplicacionPlazaNavigation { get; set; } = null!;

    public virtual Plaza CodigoPlazaNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioAprobacionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioRechazoNavigation { get; set; }
}
