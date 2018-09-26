<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ServicioAutoPres.aspx.cs" Inherits="Presentacion.ServicioAutoPres" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
            <div class="row">

                <asp:HiddenField ID="HdfIdIngreso" runat="server" />

                    
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:Label ID="LblNombreApellido" runat="server" Text="Nombre y Apellido Cliente" CssClass="label control-label alert-info center-block"></asp:Label>
                            <asp:Label ID="LblNomAp" runat="server" CssClass="form-control"></asp:Label>
                        </div>
                    </div>
  

                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:Label ID="LblAuto" runat="server" Text="Auto Cliente" CssClass="label control-label alert-info"></asp:Label>
                            <asp:Label ID="LblAutoCliente" runat="server" CssClass="form-control"></asp:Label>
                        </div>
                    </div>

                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:Label ID="LblAceite" runat="server" Text="Cambio Aceite" CssClass="label control-label alert-info center-block"></asp:Label>
                            <asp:CheckBox ID="CbxAceite" runat="server" />
                        </div>
                    </div>

                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:Label ID="LblFiltro" runat="server" Text="Cambio de Filtro" CssClass="label control-label alert-info center-block"></asp:Label>
                            <asp:CheckBox ID="CbxFiltro" runat="server" />
                        </div>
                    </div>

                   <div class="col-md-12">
                        <div class="form-group">
                            <asp:Label ID="LblReparaciones" runat="server" Text="Reparaciones Hechas" CssClass="label control-label alert-info center-block"></asp:Label>
                            <asp:TextBox ID="TxtReparaciones" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                   </div>
                   
                    
    
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:Label ID="LblObservaciones" runat="server" Text="Observaciones" CssClass="label control-label alert-info center-block"></asp:Label>
                            <asp:TextBox ID="TxtObsevaciones" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:Button ID="BtnGuardar" runat="server" OnClick="BtnGuardar_Click" Text="Guardar Servicio" class="btn btn-success col-md-6" />
                            <asp:Button ID="BtnListar" Text="Ver Servicios" runat="server" OnClick="BtnListar_Click" class="btn btn-success col-md-6"/>
                        </div>
                    </div>

                    <div class="form-group">
                    <asp:GridView ID="GdvServicio" runat="server" AutoGenerateColumns="false" CssClass="table table-hover table-bordered table-condensed">
                        <Columns>
                            <asp:BoundField HeaderText="Nombre y Apellido" DataField="nombreApellido"/>
                            <asp:BoundField HeaderText="Auto Ingresado" DataField="autoIngresado"/>
                            <asp:BoundField HeaderText="Fecha de ingreso" DataField="fechaIngreso"/>
                            <asp:BoundField HeaderText="Cambio Aceite" DataField="cambioAceite"/>
                            <asp:BoundField HeaderText="Cambio Filtro" DataField="cambioFiltro"/>
                            <asp:BoundField HeaderText="Reparaciones" DataField="reparaciones" />
                            <asp:BoundField HeaderText="Observaciones" DataField="observaciones" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
    </div>

</asp:Content>
