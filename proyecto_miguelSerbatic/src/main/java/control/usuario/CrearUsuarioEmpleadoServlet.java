package control.usuario;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

import service.UsuarioServicio;

@WebServlet("/CrearUsuarioEmpleado")
public class CrearUsuarioEmpleadoServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(CrearUsuarioEmpleadoServlet.class);

    public CrearUsuarioEmpleadoServlet() {
        super();
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
        try {
            String email = request.getParameter("email");
            String clave = request.getParameter("clave");
            String claveRepetir = request.getParameter("claveRepetir");
            String nombre = request.getParameter("nombre");
            String apellido1 = request.getParameter("apellido1");
            String apellido2 = request.getParameter("apellido2");
            String direccion = request.getParameter("direccion");
            String provincia = request.getParameter("provincia");
            String localidad = request.getParameter("localidad");
            String telefono = request.getParameter("telefono");
            String dni = request.getParameter("dni");

            UsuarioServicio.verificarContrasena(email, clave, claveRepetir, nombre, apellido1, apellido2, direccion,
                    provincia, localidad, telefono, dni);

            response.sendRedirect("mostrarUsuarios");
        } catch (Exception e) {
            log.error("Error al crear usuario empleado", e);
            response.sendRedirect("error.jsp");
        }
    }
}
