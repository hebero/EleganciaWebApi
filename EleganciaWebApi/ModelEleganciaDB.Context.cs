﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EleganciaWebApi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EleganciaEntitie : DbContext
    {
        public EleganciaEntitie()
            : base("name=EleganciaEntitie")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bodega> Bodegas { get; set; }
        public virtual DbSet<Boleta> Boletas { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Departamento> Departamentoes { get; set; }
        public virtual DbSet<DepartamentoCliente> DepartamentoClientes { get; set; }
        public virtual DbSet<DetalleBoleta> DetalleBoletas { get; set; }
        public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public virtual DbSet<Direccion> Direccions { get; set; }
        public virtual DbSet<DireccionCliente> DireccionClientes { get; set; }
        public virtual DbSet<FacSerieNumero> FacSerieNumeroes { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<LogsInventario> LogsInventarios { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<MunicipioCliente> MunicipioClientes { get; set; }
        public virtual DbSet<Producto> Productoes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<vBoletasDetalle> vBoletasDetalles { get; set; }
        public virtual DbSet<vBoletasEntrada> vBoletasEntradas { get; set; }
        public virtual DbSet<vDetalleBoleta> vDetalleBoletas { get; set; }
        public virtual DbSet<vDetalleFactura> vDetalleFacturas { get; set; }
        public virtual DbSet<vEncabezadoFactura> vEncabezadoFacturas { get; set; }
        public virtual DbSet<vEntradaSalida> vEntradaSalidas { get; set; }
        public virtual DbSet<vExistenciaBodega> vExistenciaBodegas { get; set; }
        public virtual DbSet<vFacturaDetalle> vFacturaDetalles { get; set; }
        public virtual DbSet<vMunicipio> vMunicipios { get; set; }
    
        public virtual int paBoletaEntrada(Nullable<int> idBoleta, Nullable<int> sku, Nullable<int> cantidad, Nullable<int> daniado, Nullable<System.DateTime> fechaVencimiento, Nullable<decimal> precioRef)
        {
            var idBoletaParameter = idBoleta.HasValue ?
                new ObjectParameter("IdBoleta", idBoleta) :
                new ObjectParameter("IdBoleta", typeof(int));
    
            var skuParameter = sku.HasValue ?
                new ObjectParameter("Sku", sku) :
                new ObjectParameter("Sku", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var daniadoParameter = daniado.HasValue ?
                new ObjectParameter("Daniado", daniado) :
                new ObjectParameter("Daniado", typeof(int));
    
            var fechaVencimientoParameter = fechaVencimiento.HasValue ?
                new ObjectParameter("FechaVencimiento", fechaVencimiento) :
                new ObjectParameter("FechaVencimiento", typeof(System.DateTime));
    
            var precioRefParameter = precioRef.HasValue ?
                new ObjectParameter("PrecioRef", precioRef) :
                new ObjectParameter("PrecioRef", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("paBoletaEntrada", idBoletaParameter, skuParameter, cantidadParameter, daniadoParameter, fechaVencimientoParameter, precioRefParameter);
        }
    
        public virtual int paBoletaSalida(Nullable<int> idBoleta, Nullable<int> sku, Nullable<int> cantidad)
        {
            var idBoletaParameter = idBoleta.HasValue ?
                new ObjectParameter("IdBoleta", idBoleta) :
                new ObjectParameter("IdBoleta", typeof(int));
    
            var skuParameter = sku.HasValue ?
                new ObjectParameter("Sku", sku) :
                new ObjectParameter("Sku", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("paBoletaSalida", idBoletaParameter, skuParameter, cantidadParameter);
        }
    
        public virtual int paFacturaAnulada(string serie, Nullable<int> numero)
        {
            var serieParameter = serie != null ?
                new ObjectParameter("Serie", serie) :
                new ObjectParameter("Serie", typeof(string));
    
            var numeroParameter = numero.HasValue ?
                new ObjectParameter("Numero", numero) :
                new ObjectParameter("Numero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("paFacturaAnulada", serieParameter, numeroParameter);
        }
    
        public virtual int paFacturaCancelada(string serie, Nullable<int> numero)
        {
            var serieParameter = serie != null ?
                new ObjectParameter("Serie", serie) :
                new ObjectParameter("Serie", typeof(string));
    
            var numeroParameter = numero.HasValue ?
                new ObjectParameter("Numero", numero) :
                new ObjectParameter("Numero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("paFacturaCancelada", serieParameter, numeroParameter);
        }
    
        public virtual int paNewBodega(string nombre, Nullable<int> municipio, string direccion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var municipioParameter = municipio.HasValue ?
                new ObjectParameter("Municipio", municipio) :
                new ObjectParameter("Municipio", typeof(int));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("paNewBodega", nombreParameter, municipioParameter, direccionParameter);
        }
    
        public virtual int paNewCliente(string nit, string nombre, string nombreSeg, string apellidoPrim, string apellidoSeg, string direccion, Nullable<int> municipio)
        {
            var nitParameter = nit != null ?
                new ObjectParameter("Nit", nit) :
                new ObjectParameter("Nit", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var nombreSegParameter = nombreSeg != null ?
                new ObjectParameter("NombreSeg", nombreSeg) :
                new ObjectParameter("NombreSeg", typeof(string));
    
            var apellidoPrimParameter = apellidoPrim != null ?
                new ObjectParameter("ApellidoPrim", apellidoPrim) :
                new ObjectParameter("ApellidoPrim", typeof(string));
    
            var apellidoSegParameter = apellidoSeg != null ?
                new ObjectParameter("ApellidoSeg", apellidoSeg) :
                new ObjectParameter("ApellidoSeg", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var municipioParameter = municipio.HasValue ?
                new ObjectParameter("Municipio", municipio) :
                new ObjectParameter("Municipio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("paNewCliente", nitParameter, nombreParameter, nombreSegParameter, apellidoPrimParameter, apellidoSegParameter, direccionParameter, municipioParameter);
        }
    
        public virtual int paNewEncabezadoBoleta(Nullable<int> idBodega, Nullable<System.DateTime> fechaBoleta, string tipoBoleta, string descripcion)
        {
            var idBodegaParameter = idBodega.HasValue ?
                new ObjectParameter("IdBodega", idBodega) :
                new ObjectParameter("IdBodega", typeof(int));
    
            var fechaBoletaParameter = fechaBoleta.HasValue ?
                new ObjectParameter("FechaBoleta", fechaBoleta) :
                new ObjectParameter("FechaBoleta", typeof(System.DateTime));
    
            var tipoBoletaParameter = tipoBoleta != null ?
                new ObjectParameter("TipoBoleta", tipoBoleta) :
                new ObjectParameter("TipoBoleta", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("paNewEncabezadoBoleta", idBodegaParameter, fechaBoletaParameter, tipoBoletaParameter, descripcionParameter);
        }
    
        public virtual int paNewFacturaDetalle(Nullable<int> idFactura, Nullable<int> sku, Nullable<int> cantidad, Nullable<decimal> precio)
        {
            var idFacturaParameter = idFactura.HasValue ?
                new ObjectParameter("IdFactura", idFactura) :
                new ObjectParameter("IdFactura", typeof(int));
    
            var skuParameter = sku.HasValue ?
                new ObjectParameter("Sku", sku) :
                new ObjectParameter("Sku", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("paNewFacturaDetalle", idFacturaParameter, skuParameter, cantidadParameter, precioParameter);
        }
    
        public virtual int paNewFacturaEncabezado(string nit, Nullable<int> idBodega, Nullable<System.DateTime> fechaEncabezado)
        {
            var nitParameter = nit != null ?
                new ObjectParameter("Nit", nit) :
                new ObjectParameter("Nit", typeof(string));
    
            var idBodegaParameter = idBodega.HasValue ?
                new ObjectParameter("IdBodega", idBodega) :
                new ObjectParameter("IdBodega", typeof(int));
    
            var fechaEncabezadoParameter = fechaEncabezado.HasValue ?
                new ObjectParameter("FechaEncabezado", fechaEncabezado) :
                new ObjectParameter("FechaEncabezado", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("paNewFacturaEncabezado", nitParameter, idBodegaParameter, fechaEncabezadoParameter);
        }
    
        public virtual int paNewProducto(Nullable<int> sKU, string nombre)
        {
            var sKUParameter = sKU.HasValue ?
                new ObjectParameter("SKU", sKU) :
                new ObjectParameter("SKU", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("paNewProducto", sKUParameter, nombreParameter);
        }
    
        public virtual int paProductoDelete(Nullable<int> idProducto)
        {
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("paProductoDelete", idProductoParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}