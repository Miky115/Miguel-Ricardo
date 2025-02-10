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

@WebServlet("/CrearUsuario")
public class CrearUsuarioServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static Logger log = Logger.getLogger(CrearUsuarioServlet.class);

	public CrearUsuarioServlet() {
		super();
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
		try {
			String email = request.getParameter("email");
			String clave = request.getParameter("clave");
			String claveRepetir = request.getParameter("confirm_password");
			String nombre = request.getParameter("nombre");
			String apellido1 = request.getParameter("primer_apellido");
			String apellido2 = request.getParameter("segundo_apellido");
			String direccion = request.getParameter("direccion");
			String provincia = request.getParameter("provincia");
			String localidad = request.getParameter("localidad");
			String telefono = request.getParameter("telefono");
			String dni = request.getParameter("dni");

			UsuarioServicio.verificarContrasena(email, clave, claveRepetir, nombre, apellido1, apellido2, direccion,
					provincia, localidad, telefono, dni);

			response.sendRedirect("Catalogo");
		} catch (Exception e) {
			log.error("Error al crear usuario", e);
			response.sendRedirect("error.jsp");
		}
	}
}
