<%@ Page Title="Registro de incidencias TI"
    Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="GestorIncidenciasTI._Default" %>

<asp:Content ID="BodyContent"
    ContentPlaceHolderID="MainContent"
    runat="server">

    <main>

        <h1>Registro de incidencias TI</h1>

        <p>
            Complete la información de la incidencia.
        </p>

        <!-- Mensajes de validación del lado del cliente -->
        <div id="mensajeValidacion"
             class="alert alert-danger"
             style="display:none;">
        </div>

        <!-- Título -->
        <div class="mb-3">
            <label for="txtTitulo" class="form-label">
                Título de la incidencia
            </label>

            <asp:TextBox
                ID="txtTitulo"
                runat="server"
                ClientIDMode="Static"
                CssClass="form-control">
            </asp:TextBox>
        </div>

        <!-- Categoría -->
        <div class="mb-3">
            <label for="ddlCategoria" class="form-label">
                Categoría
            </label>

            <asp:DropDownList
                ID="ddlCategoria"
                runat="server"
                ClientIDMode="Static"
                CssClass="form-select">

                <asp:ListItem
                    Text="Seleccione una categoría"
                    Value="" />

                <asp:ListItem
                    Text="Hardware"
                    Value="Hardware" />

                <asp:ListItem
                    Text="Software"
                    Value="Software" />

                <asp:ListItem
                    Text="Red"
                    Value="Red" />

                <asp:ListItem
                    Text="Servicio"
                    Value="Servicio" />

            </asp:DropDownList>
        </div>

        <!-- Impacto -->
        <div class="mb-3">
            <label for="ddlImpacto" class="form-label">
                Impacto
            </label>

            <asp:DropDownList
                ID="ddlImpacto"
                runat="server"
                ClientIDMode="Static"
                CssClass="form-select">

                <asp:ListItem
                    Text="Seleccione el impacto"
                    Value="" />

                <asp:ListItem
                    Text="Bajo"
                    Value="Bajo" />

                <asp:ListItem
                    Text="Medio"
                    Value="Medio" />

                <asp:ListItem
                    Text="Alto"
                    Value="Alto" />

            </asp:DropDownList>
        </div>

        <!-- Urgencia -->
        <div class="mb-3">
            <label for="ddlUrgencia" class="form-label">
                Urgencia
            </label>

            <asp:DropDownList
                ID="ddlUrgencia"
                runat="server"
                ClientIDMode="Static"
                CssClass="form-select">

                <asp:ListItem
                    Text="Seleccione la urgencia"
                    Value="" />

                <asp:ListItem
                    Text="Baja"
                    Value="Baja" />

                <asp:ListItem
                    Text="Media"
                    Value="Media" />

                <asp:ListItem
                    Text="Alta"
                    Value="Alta" />

            </asp:DropDownList>
        </div>

        <!-- Descripción -->
        <div class="mb-3">
            <label for="txtDescripcion" class="form-label">
                Descripción
            </label>

            <asp:TextBox
                ID="txtDescripcion"
                runat="server"
                ClientIDMode="Static"
                TextMode="MultiLine"
                Rows="4"
                CssClass="form-control">
            </asp:TextBox>
        </div>

        <!-- Botón de registro -->
        <div class="mb-3">
            <asp:Button
                ID="btnRegistrar"
                runat="server"
                Text="Registrar incidencia"
                CssClass="btn btn-primary"
                OnClientClick="return validarIncidencia();"
                OnClick="btnRegistrar_Click" />
        </div>

        <!-- Mensaje generado desde C# -->
        <asp:Label
            ID="lblMensaje"
            runat="server">
        </asp:Label>

    </main>

    <!-- JavaScript propio del módulo -->
    <script src="Scripts/incidencias.js"></script>

</asp:Content>