<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarIngreso.aspx.cs" Inherits="Presentacion.EditarIngreso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container">
            <div class="col-md-6">

                <asp:HiddenField ID="HdfIdIngreso" runat="server" />

                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:Label ID="LblNombreApellido" runat="server" Text="Nombre y Apellido Cliente" CssClass="label control-label alert-info center-block"></asp:Label>
                            <asp:TextBox ID="TxtNomAp" placeholder="Nombre y Apellido Cliente" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:Label ID="LblDni" runat="server" Text="Documento" CssClass="label control-label alert-info"></asp:Label>
                            <asp:TextBox ID="TxtDocumento" runat="server" placeholder="d.n.i" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:Label ID="LblAutoIng" runat="server" Text="Auto Ingresado" CssClass="label control-label alert-info center-block"></asp:Label>
                            <asp:TextBox ID="TxtAutoIngresado" placeholder="Auto Ingresado" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>

                   <div class="col-md-6">
                        <div class="form-group">
                            <asp:Label ID="LblFechaIngreso" runat="server" Text="Fecha de Ingreso" CssClass="label control-label alert-info center-block"></asp:Label>
                            <div class="row">
                                <div class="container">
                                    <div class="row">

                                        <div class='col-md-3'>
                                            <div class="form-group">
                                                <div class='input-group date' id='myDate'>
                                                   <asp:TextBox ID="TxtFechaIngreso" placeholder="Fecha de ingreso" CssClass="form-control" runat="server"></asp:TextBox>
                                                    <span class="input-group-addon">
                                                        <span class="glyphicon glyphicon-calendar"></span>
                                                    </span>
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    
                       
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:Button ID="BtnGuardar" runat="server" OnClick="BtnGuardar_Click" Text="Guardar Cambio" class="btn btn-success col-md-6" />
                            <asp:Button ID="BtnVolver" Text="Volver a Ingresos" runat="server" class="btn btn-success col-md-6" OnClick="BtnVolver_Click"/>
                        </div>
                    </div>
            </div>
    </div>

    <script type="text/javascript">

        $(function () {
            $('#myDate').datetimepicker({format: 'DD-MM-YYYY'}).on('dp.change', function (e) {

                if (!e.oldDate || !e.date.isSame(e.oldDate, 'day')) {
                    $(this).data('DateTimePicker').hide();
                }
            });


        });
    </script>

</asp:Content>
