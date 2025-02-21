﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace stocktake_V4.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class siixsem_stocktake_dbEntities : DbContext
    {
        public siixsem_stocktake_dbEntities()
            : base("name=siixsem_stocktake_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<getLabelInfoMI_Result> getLabelInfoMI(string label)
        {
            var labelParameter = label != null ?
                new ObjectParameter("label", label) :
                new ObjectParameter("label", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getLabelInfoMI_Result>("getLabelInfoMI", labelParameter);
        }
    
        public virtual ObjectResult<getLabelInfoST_Result> getLabelInfoST(string label)
        {
            var labelParameter = label != null ?
                new ObjectParameter("label", label) :
                new ObjectParameter("label", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getLabelInfoST_Result>("getLabelInfoST", labelParameter);
        }
    
        public virtual ObjectResult<string> getLabelMI(string model, string dj, string semi, string cgsroute, string qty, string qr, string mag)
        {
            var modelParameter = model != null ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(string));
    
            var djParameter = dj != null ?
                new ObjectParameter("dj", dj) :
                new ObjectParameter("dj", typeof(string));
    
            var semiParameter = semi != null ?
                new ObjectParameter("semi", semi) :
                new ObjectParameter("semi", typeof(string));
    
            var cgsrouteParameter = cgsroute != null ?
                new ObjectParameter("cgsroute", cgsroute) :
                new ObjectParameter("cgsroute", typeof(string));
    
            var qtyParameter = qty != null ?
                new ObjectParameter("qty", qty) :
                new ObjectParameter("qty", typeof(string));
    
            var qrParameter = qr != null ?
                new ObjectParameter("qr", qr) :
                new ObjectParameter("qr", typeof(string));
    
            var magParameter = mag != null ?
                new ObjectParameter("mag", mag) :
                new ObjectParameter("mag", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("getLabelMI", modelParameter, djParameter, semiParameter, cgsrouteParameter, qtyParameter, qrParameter, magParameter);
        }
    
        public virtual ObjectResult<getLabelST_Result> getLabelST(string model, string dj, string semi, string cgsroute, string qty, string qr, string mag, Nullable<int> printer, Nullable<int> idType)
        {
            var modelParameter = model != null ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(string));
    
            var djParameter = dj != null ?
                new ObjectParameter("dj", dj) :
                new ObjectParameter("dj", typeof(string));
    
            var semiParameter = semi != null ?
                new ObjectParameter("semi", semi) :
                new ObjectParameter("semi", typeof(string));
    
            var cgsrouteParameter = cgsroute != null ?
                new ObjectParameter("cgsroute", cgsroute) :
                new ObjectParameter("cgsroute", typeof(string));
    
            var qtyParameter = qty != null ?
                new ObjectParameter("qty", qty) :
                new ObjectParameter("qty", typeof(string));
    
            var qrParameter = qr != null ?
                new ObjectParameter("qr", qr) :
                new ObjectParameter("qr", typeof(string));
    
            var magParameter = mag != null ?
                new ObjectParameter("mag", mag) :
                new ObjectParameter("mag", typeof(string));
    
            var printerParameter = printer.HasValue ?
                new ObjectParameter("printer", printer) :
                new ObjectParameter("printer", typeof(int));
    
            var idTypeParameter = idType.HasValue ?
                new ObjectParameter("idType", idType) :
                new ObjectParameter("idType", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getLabelST_Result>("getLabelST", modelParameter, djParameter, semiParameter, cgsrouteParameter, qtyParameter, qrParameter, magParameter, printerParameter, idTypeParameter);
        }
    
        public virtual ObjectResult<string> getLabelSTR(string location, string scanned, string count)
        {
            var locationParameter = location != null ?
                new ObjectParameter("location", location) :
                new ObjectParameter("location", typeof(string));
    
            var scannedParameter = scanned != null ?
                new ObjectParameter("scanned", scanned) :
                new ObjectParameter("scanned", typeof(string));
    
            var countParameter = count != null ?
                new ObjectParameter("count", count) :
                new ObjectParameter("count", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("getLabelSTR", locationParameter, scannedParameter, countParameter);
        }
    
        public virtual int getLabelSTR_Gen(string location, string scanned, string count, ObjectParameter zpl)
        {
            var locationParameter = location != null ?
                new ObjectParameter("location", location) :
                new ObjectParameter("location", typeof(string));
    
            var scannedParameter = scanned != null ?
                new ObjectParameter("scanned", scanned) :
                new ObjectParameter("scanned", typeof(string));
    
            var countParameter = count != null ?
                new ObjectParameter("count", count) :
                new ObjectParameter("count", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("getLabelSTR_Gen", locationParameter, scannedParameter, countParameter, zpl);
        }
    
        public virtual ObjectResult<Nullable<int>> getLastQtyByDJ(string dj)
        {
            var djParameter = dj != null ?
                new ObjectParameter("dj", dj) :
                new ObjectParameter("dj", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getLastQtyByDJ", djParameter);
        }
    
        public virtual ObjectResult<getLastQtyByUser_Result> getLastQtyByUser(Nullable<int> idU)
        {
            var idUParameter = idU.HasValue ?
                new ObjectParameter("idU", idU) :
                new ObjectParameter("idU", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getLastQtyByUser_Result>("getLastQtyByUser", idUParameter);
        }
    
        public virtual ObjectResult<getLocLbls_Result> getLocLbls(string firstLoc)
        {
            var firstLocParameter = firstLoc != null ?
                new ObjectParameter("firstLoc", firstLoc) :
                new ObjectParameter("firstLoc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getLocLbls_Result>("getLocLbls", firstLocParameter);
        }
    
        public virtual ObjectResult<getSerialSemPen_Result> getSerialSemPen(string fecha)
        {
            var fechaParameter = fecha != null ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getSerialSemPen_Result>("getSerialSemPen", fechaParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> getSubCount(string location)
        {
            var locationParameter = location != null ?
                new ObjectParameter("location", location) :
                new ObjectParameter("location", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getSubCount", locationParameter);
        }
    
        public virtual ObjectResult<getTotCount_Result> getTotCount(string location)
        {
            var locationParameter = location != null ?
                new ObjectParameter("location", location) :
                new ObjectParameter("location", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getTotCount_Result>("getTotCount", locationParameter);
        }
    
        public virtual ObjectResult<getUserZone_Result> getUserZone(Nullable<int> idUser)
        {
            var idUserParameter = idUser.HasValue ?
                new ObjectParameter("idUser", idUser) :
                new ObjectParameter("idUser", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getUserZone_Result>("getUserZone", idUserParameter);
        }
    
        public virtual ObjectResult<insertLabel_Result> insertLabel(Nullable<int> idU, string serial, string model, string dj, string semi, string cgsroute, string qty, string qr, string mag, Nullable<int> idType, Nullable<int> quar, Nullable<int> idArea)
        {
            var idUParameter = idU.HasValue ?
                new ObjectParameter("idU", idU) :
                new ObjectParameter("idU", typeof(int));
    
            var serialParameter = serial != null ?
                new ObjectParameter("serial", serial) :
                new ObjectParameter("serial", typeof(string));
    
            var modelParameter = model != null ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(string));
    
            var djParameter = dj != null ?
                new ObjectParameter("dj", dj) :
                new ObjectParameter("dj", typeof(string));
    
            var semiParameter = semi != null ?
                new ObjectParameter("semi", semi) :
                new ObjectParameter("semi", typeof(string));
    
            var cgsrouteParameter = cgsroute != null ?
                new ObjectParameter("cgsroute", cgsroute) :
                new ObjectParameter("cgsroute", typeof(string));
    
            var qtyParameter = qty != null ?
                new ObjectParameter("qty", qty) :
                new ObjectParameter("qty", typeof(string));
    
            var qrParameter = qr != null ?
                new ObjectParameter("qr", qr) :
                new ObjectParameter("qr", typeof(string));
    
            var magParameter = mag != null ?
                new ObjectParameter("mag", mag) :
                new ObjectParameter("mag", typeof(string));
    
            var idTypeParameter = idType.HasValue ?
                new ObjectParameter("idType", idType) :
                new ObjectParameter("idType", typeof(int));
    
            var quarParameter = quar.HasValue ?
                new ObjectParameter("quar", quar) :
                new ObjectParameter("quar", typeof(int));
    
            var idAreaParameter = idArea.HasValue ?
                new ObjectParameter("idArea", idArea) :
                new ObjectParameter("idArea", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<insertLabel_Result>("insertLabel", idUParameter, serialParameter, modelParameter, djParameter, semiParameter, cgsrouteParameter, qtyParameter, qrParameter, magParameter, idTypeParameter, quarParameter, idAreaParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> insertLabelMI(Nullable<int> idU, string serial, string model, string dj, string semi, string cgsroute, string qty, string qr, string mag)
        {
            var idUParameter = idU.HasValue ?
                new ObjectParameter("idU", idU) :
                new ObjectParameter("idU", typeof(int));
    
            var serialParameter = serial != null ?
                new ObjectParameter("serial", serial) :
                new ObjectParameter("serial", typeof(string));
    
            var modelParameter = model != null ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(string));
    
            var djParameter = dj != null ?
                new ObjectParameter("dj", dj) :
                new ObjectParameter("dj", typeof(string));
    
            var semiParameter = semi != null ?
                new ObjectParameter("semi", semi) :
                new ObjectParameter("semi", typeof(string));
    
            var cgsrouteParameter = cgsroute != null ?
                new ObjectParameter("cgsroute", cgsroute) :
                new ObjectParameter("cgsroute", typeof(string));
    
            var qtyParameter = qty != null ?
                new ObjectParameter("qty", qty) :
                new ObjectParameter("qty", typeof(string));
    
            var qrParameter = qr != null ?
                new ObjectParameter("qr", qr) :
                new ObjectParameter("qr", typeof(string));
    
            var magParameter = mag != null ?
                new ObjectParameter("mag", mag) :
                new ObjectParameter("mag", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("insertLabelMI", idUParameter, serialParameter, modelParameter, djParameter, semiParameter, cgsrouteParameter, qtyParameter, qrParameter, magParameter);
        }
    
        public virtual ObjectResult<updateChecked_Result> updateChecked(string qr)
        {
            var qrParameter = qr != null ?
                new ObjectParameter("qr", qr) :
                new ObjectParameter("qr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<updateChecked_Result>("updateChecked", qrParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> updateCheckedMI(string qr)
        {
            var qrParameter = qr != null ?
                new ObjectParameter("qr", qr) :
                new ObjectParameter("qr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("updateCheckedMI", qrParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> updateCheckedPrintMI(string qr)
        {
            var qrParameter = qr != null ?
                new ObjectParameter("qr", qr) :
                new ObjectParameter("qr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("updateCheckedPrintMI", qrParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> updateCheckedPrintST(string qr)
        {
            var qrParameter = qr != null ?
                new ObjectParameter("qr", qr) :
                new ObjectParameter("qr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("updateCheckedPrintST", qrParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> updateLastQtyByDJ(string dj, Nullable<int> count)
        {
            var djParameter = dj != null ?
                new ObjectParameter("dj", dj) :
                new ObjectParameter("dj", typeof(string));
    
            var countParameter = count.HasValue ?
                new ObjectParameter("count", count) :
                new ObjectParameter("count", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("updateLastQtyByDJ", djParameter, countParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> updateLastQtyByUser(Nullable<int> idU, Nullable<int> count)
        {
            var idUParameter = idU.HasValue ?
                new ObjectParameter("idU", idU) :
                new ObjectParameter("idU", typeof(int));
    
            var countParameter = count.HasValue ?
                new ObjectParameter("count", count) :
                new ObjectParameter("count", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("updateLastQtyByUser", idUParameter, countParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> updateLblMagMI(string label, Nullable<int> newLbl)
        {
            var labelParameter = label != null ?
                new ObjectParameter("label", label) :
                new ObjectParameter("label", typeof(string));
    
            var newLblParameter = newLbl.HasValue ?
                new ObjectParameter("newLbl", newLbl) :
                new ObjectParameter("newLbl", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("updateLblMagMI", labelParameter, newLblParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> updateLblMagST(string label, Nullable<int> newLbl)
        {
            var labelParameter = label != null ?
                new ObjectParameter("label", label) :
                new ObjectParameter("label", typeof(string));
    
            var newLblParameter = newLbl.HasValue ?
                new ObjectParameter("newLbl", newLbl) :
                new ObjectParameter("newLbl", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("updateLblMagST", labelParameter, newLblParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> updateQtyMagMI(string label, Nullable<int> qty)
        {
            var labelParameter = label != null ?
                new ObjectParameter("label", label) :
                new ObjectParameter("label", typeof(string));
    
            var qtyParameter = qty.HasValue ?
                new ObjectParameter("qty", qty) :
                new ObjectParameter("qty", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("updateQtyMagMI", labelParameter, qtyParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> updateQtyMagST(string label, Nullable<int> qty)
        {
            var labelParameter = label != null ?
                new ObjectParameter("label", label) :
                new ObjectParameter("label", typeof(string));
    
            var qtyParameter = qty.HasValue ?
                new ObjectParameter("qty", qty) :
                new ObjectParameter("qty", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("updateQtyMagST", labelParameter, qtyParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> updateSemifinish(string serial, string djGroup, string semi)
        {
            var serialParameter = serial != null ?
                new ObjectParameter("serial", serial) :
                new ObjectParameter("serial", typeof(string));
    
            var djGroupParameter = djGroup != null ?
                new ObjectParameter("djGroup", djGroup) :
                new ObjectParameter("djGroup", typeof(string));
    
            var semiParameter = semi != null ?
                new ObjectParameter("semi", semi) :
                new ObjectParameter("semi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("updateSemifinish", serialParameter, djGroupParameter, semiParameter);
        }
    
        public virtual ObjectResult<getLastFive_Result> getLastFive(Nullable<int> idUser)
        {
            var idUserParameter = idUser.HasValue ?
                new ObjectParameter("idUser", idUser) :
                new ObjectParameter("idUser", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getLastFive_Result>("getLastFive", idUserParameter);
        }
    
        public virtual ObjectResult<getLastFiveScan_Result> getLastFiveScan(Nullable<int> idUser)
        {
            var idUserParameter = idUser.HasValue ?
                new ObjectParameter("idUser", idUser) :
                new ObjectParameter("idUser", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getLastFiveScan_Result>("getLastFiveScan", idUserParameter);
        }
    
        public virtual ObjectResult<updateCheckedV2_Result> updateCheckedV2(string qr, Nullable<int> idUser)
        {
            var qrParameter = qr != null ?
                new ObjectParameter("qr", qr) :
                new ObjectParameter("qr", typeof(string));
    
            var idUserParameter = idUser.HasValue ?
                new ObjectParameter("idUser", idUser) :
                new ObjectParameter("idUser", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<updateCheckedV2_Result>("updateCheckedV2", qrParameter, idUserParameter);
        }
    
        public virtual ObjectResult<getZonesQty_Result> getZonesQty()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getZonesQty_Result>("getZonesQty");
        }
    
        public virtual ObjectResult<deleteLabel_Result> deleteLabel(string barcode, Nullable<int> idUser)
        {
            var barcodeParameter = barcode != null ?
                new ObjectParameter("barcode", barcode) :
                new ObjectParameter("barcode", typeof(string));
    
            var idUserParameter = idUser.HasValue ?
                new ObjectParameter("idUser", idUser) :
                new ObjectParameter("idUser", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<deleteLabel_Result>("deleteLabel", barcodeParameter, idUserParameter);
        }
    
        public virtual ObjectResult<existsLabel_Result> existsLabel(string serial)
        {
            var serialParameter = serial != null ?
                new ObjectParameter("serial", serial) :
                new ObjectParameter("serial", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<existsLabel_Result>("existsLabel", serialParameter);
        }
    
        public virtual ObjectResult<getZones_Result> getZones()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getZones_Result>("getZones");
        }
    
        public virtual ObjectResult<getLevelProfile_Result> getLevelProfile(Nullable<int> group_id)
        {
            var group_idParameter = group_id.HasValue ?
                new ObjectParameter("group_id", group_id) :
                new ObjectParameter("group_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getLevelProfile_Result>("getLevelProfile", group_idParameter);
        }
    
        public virtual ObjectResult<getWipZonByIDArea_Result> getWipZonByIDArea(Nullable<int> idArea)
        {
            var idAreaParameter = idArea.HasValue ?
                new ObjectParameter("IdArea", idArea) :
                new ObjectParameter("IdArea", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getWipZonByIDArea_Result>("getWipZonByIDArea", idAreaParameter);
        }
    
        public virtual ObjectResult<getLabelSTV2_Result> getLabelSTV2(string model, string dj, string semi, string cgsroute, string qty, string qr, string mag, Nullable<int> printer, Nullable<int> idType, string user, string area, Nullable<int> quar)
        {
            var modelParameter = model != null ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(string));
    
            var djParameter = dj != null ?
                new ObjectParameter("dj", dj) :
                new ObjectParameter("dj", typeof(string));
    
            var semiParameter = semi != null ?
                new ObjectParameter("semi", semi) :
                new ObjectParameter("semi", typeof(string));
    
            var cgsrouteParameter = cgsroute != null ?
                new ObjectParameter("cgsroute", cgsroute) :
                new ObjectParameter("cgsroute", typeof(string));
    
            var qtyParameter = qty != null ?
                new ObjectParameter("qty", qty) :
                new ObjectParameter("qty", typeof(string));
    
            var qrParameter = qr != null ?
                new ObjectParameter("qr", qr) :
                new ObjectParameter("qr", typeof(string));
    
            var magParameter = mag != null ?
                new ObjectParameter("mag", mag) :
                new ObjectParameter("mag", typeof(string));
    
            var printerParameter = printer.HasValue ?
                new ObjectParameter("printer", printer) :
                new ObjectParameter("printer", typeof(int));
    
            var idTypeParameter = idType.HasValue ?
                new ObjectParameter("idType", idType) :
                new ObjectParameter("idType", typeof(int));
    
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));
    
            var areaParameter = area != null ?
                new ObjectParameter("area", area) :
                new ObjectParameter("area", typeof(string));
    
            var quarParameter = quar.HasValue ?
                new ObjectParameter("quar", quar) :
                new ObjectParameter("quar", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getLabelSTV2_Result>("getLabelSTV2", modelParameter, djParameter, semiParameter, cgsrouteParameter, qtyParameter, qrParameter, magParameter, printerParameter, idTypeParameter, userParameter, areaParameter, quarParameter);
        }
    
        public virtual ObjectResult<getLastFiveFin_Result> getLastFiveFin(Nullable<int> idUser)
        {
            var idUserParameter = idUser.HasValue ?
                new ObjectParameter("idUser", idUser) :
                new ObjectParameter("idUser", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getLastFiveFin_Result>("getLastFiveFin", idUserParameter);
        }
    
        public virtual ObjectResult<updateFinChecked_Result> updateFinChecked(string qr, Nullable<int> idUser, Nullable<int> qty)
        {
            var qrParameter = qr != null ?
                new ObjectParameter("qr", qr) :
                new ObjectParameter("qr", typeof(string));
    
            var idUserParameter = idUser.HasValue ?
                new ObjectParameter("idUser", idUser) :
                new ObjectParameter("idUser", typeof(int));
    
            var qtyParameter = qty.HasValue ?
                new ObjectParameter("qty", qty) :
                new ObjectParameter("qty", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<updateFinChecked_Result>("updateFinChecked", qrParameter, idUserParameter, qtyParameter);
        }
    
        public virtual ObjectResult<getBoxSemByModel_Result> getBoxSemByModel(string model)
        {
            var modelParameter = model != null ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getBoxSemByModel_Result>("getBoxSemByModel", modelParameter);
        }
    
        public virtual ObjectResult<getFinalBoxSemByModel_Result> getFinalBoxSemByModel(string model)
        {
            var modelParameter = model != null ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getFinalBoxSemByModel_Result>("getFinalBoxSemByModel", modelParameter);
        }
    }
}
