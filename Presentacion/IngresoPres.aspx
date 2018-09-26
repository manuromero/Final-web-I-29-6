<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IngresoPres.aspx.cs" Inherits="Presentacion.IngresoPres" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div class="container">
            <div class="col-md-6">
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
                            <asp:Button ID="BtnGuardar" runat="server" OnClick="BtnGuardar_Click" Text="Guardar Ingreso" class="btn btn-success col-md-6" />
                            <asp:Button ID="BtnListar" runat="server" OnClick="BtnListar_Click" Text="Listar Ingreso" class="btn btn-info col-md-6" />
                        </div>
                    </div>


                    <div class="form-group">
                    <asp:GridView ID="GdvIngresos" runat="server" AutoGenerateColumns="false" CssClass="table table-hover table-bordered table-condensed">
                        <Columns>
                            <asp:BoundField HeaderText="Nombre y Apellido" DataField="nombreApellido"/>
                            <asp:BoundField HeaderText="Documento" DataField="dni" />
                            <asp:BoundField HeaderText="Auto Ingresado" DataField="autoIngresado"/>
                            <asp:BoundField HeaderText="Fecha de ingreso" DataField="fechaIngreso"/>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="BtnEditar" OnClick="BtnEditar_Click" CommandName='<%# Eval("idIngreso") %>' CommandArgument='<%# Eval("idIngreso") %>' runat="server" Text="Editar" CssClass="btn btn-warning"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="BtnServicio" OnClick="BtnServicio_Click" CommandName='<%# Eval("idIngreso") %>' CommandArgument='<%# Eval("idIngreso") %>' runat="server" Text="Servicio" CssClass="btn btn-warning" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
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
