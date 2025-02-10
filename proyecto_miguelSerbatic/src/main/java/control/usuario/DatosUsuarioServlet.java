package control.usuario;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

import model.DAO.UsuarioDAO;
import model.VO.UsuarioVO;
import service.UsuarioServicio;

@WebServlet("/DatosUsuarioServlet")
public class DatosUsuarioServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static Logger log = Logger.getLogger(DatosUsuarioServlet.class);

	public DatosUsuarioServlet() {
		super();
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
		try {
			String email = request.getParameter("email");
			String nombre = request.getParameter("nombre");
			String apellido1 = request.getParameter("primer_apellido");
			String apellido2 = request.getParameter("segundo_apellido");
			String clave = request.getParameter("clave");
			String confirmarClave = request.getParameter("Confirmarclave");
			String direccion = request.getParameter("direccion");
			String provincia = request.getParameter("provincia");
			String localidad = request.getParameter("localidad");
			String telefono = request.getParameter("telefono");
			String dni = request.getParameter("dni");
			UsuarioVO usuario = (UsuarioVO) request.getSession().getAttribute("usuarioGuardado");
			int id = usuario.getId();

			UsuarioServicio.verificarCambioContrasena(id, email, clave, confirmarClave, nombre, apellido1, apellido2,
					direccion, provincia, localidad, telefono, dni);
			
			request.getSession().setAttribute("usuarioGuardado", null);
			UsuarioVO usuarioNuevo = UsuarioDAO.getUsuario(id);
			request.getSession().setAttribute("usuarioGuardado", usuarioNuevo);

			response.sendRedirect(request.getContextPath());
		} catch (Exception e) {
			log.error("Error en la actualización de datos del usuario", e);
			response.sendRedirect("error.jsp");
		}
	}
}
