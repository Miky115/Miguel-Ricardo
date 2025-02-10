package control.usuario;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import service.UsuarioServicio;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/activarUsuario")
public class ActivarUsuarioServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(ActivarUsuarioServlet.class);

    public ActivarUsuarioServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
        try {
            String id = request.getParameter("id");
            UsuarioServicio.activarUsuario(Integer.parseInt(id));
            String destino = "";

            String tipo = request.getParameter("tipo");
            if ("empleados".equals(tipo)) {
                destino = "mostrarEmpleados";
            } else if("usuarios".equals(tipo)) {
                destino = "mostrarUsuarios";
            } else if("administradores".equals(tipo)) {
            	destino = "mostrarAdministradores";
            }
            request.getRequestDispatcher(destino).forward(request, response);
        } catch (NumberFormatException e) {
            log.error("Error de formato al activar el usuario: " + e.getMessage());
            response.sendRedirect("error.jsp");
        } catch (Exception e) {
            log.error("Error al activar el usuario: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doGet(request, response);
    }

}
