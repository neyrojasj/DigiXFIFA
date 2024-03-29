<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
         pageEncoding="ISO-8859-1"%>
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
        <script src="styles/js/jquery.js" type="text/javascript"></script>
        <script src="styles/js/uikit.js" type="text/javascript"></script>
        <script src="styles/js/ModificarForm.js" type="text/javascript"></script>
        <link href="styles/uikit.almost-flat.css" rel="stylesheet" type="text/css"/>
        <title>MyHistory</title>
    </head>
    <body>
        <div class="uk-width-9-10 uk-container-center">
            <div class="uk-grid">
                <br />
                <jsp:include page="barra.jsp"></jsp:include>
                </div>
                <hr class="uk-grid-divider" />
                <div class="uk-grid uk-container-center">
                    <div class="uk-width-2-10">
                    <jsp:include page="navegacion.jsp"></jsp:include>
                    </div>
                    <div class="uk-width-8-10">
                        <div class="uk-push-1-10">
                            <h1>Cat�logo de equipos</h1>
                            <h2>Equipos registrados</h2>
                        </div>
                        <div class="uk-width-4-6 uk-container-center">
                            <table class="uk-table" class="uk-align-center">
                                <tr>
                                    <th>Nombre de equipo</th>
                                    <th>Pa�s</th>
                                    <th>Editar</th>
                                </tr>
                            <c:forEach items="${Modelo.cEquipos}" var="mEquipo">
                                <tr>                                   
                                    <th>${mEquipo.cNombreEquipo}</th>
                                    <th>${mEquipo.cNombrePais}</th>
                                    <th>
                                        <button class ="uk-button uk-button-primary "
                                                onclick="HacerSubmitConDatoConAction('frEditarEquipo', 'hdEquipoSeleccionado',${mEquipo.cIdentificador},'Editar_Equipo');">
                                            <i class="uk-icon-magic"></i>
                                        </button>
                                    </th>
                                </tr>
                            </c:forEach>
                        </table>
                    </div>
                    <br/>
                    <form:form id = "frEditarEquipo" class="uk-form uk-form-horizontal" commandName='Modelo' action="Agregar_Equipos" method="get">
                        <form:hidden id="hdEquipoSeleccionado" path = "cEquipoSeleccionado"/>
                        <div class="uk-grid">
                            <form:button class="uk-button uk-button-primary uk-align-right" href=""><i
                                    type="submit" class="uk-icon-plus"></i>Agregar equipo</form:button>
                            </div>
                    </form:form>

                </div>

            </div>
        </div>
    </body>
</html>