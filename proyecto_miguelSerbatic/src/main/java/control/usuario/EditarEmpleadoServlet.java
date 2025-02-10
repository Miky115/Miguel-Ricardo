package control.usuario;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.UsuarioDAO;
import model.VO.UsuarioVO;
import service.UsuarioServicio;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/editarEmpleado")
public class EditarEmpleadoServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static Logger log = Logger.getLogger(EditarEmpleadoServlet.class);

	public EditarEmpleadoServlet() {
		super();
	}

	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
		try {
			String id = request.getParameter("id");
			UsuarioVO usuario = UsuarioDAO.obtenerPorId(Integer.parseInt(id));
			request.setAttribute("usuario", usuario);
			request.getSession().setAttribute("id", id);
			request.getRequestDispatcher("editarUsuario.jsp").forward(request, response);
		} catch (Exception e) {
			log.error("Error al obtener el usuario para editar", e);
			response.sendRedirect("error.jsp");
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
		try {
			int id = Integer.parseInt((String) request.getSession().getAttribute("id"));
			String email = request.getParameter("email");
			String nombre = request.getParameter("nombre");
			String apellido1 = request.getParameter("apellido1");
			String apellido2 = request.getParameter("apellido2");
			String clave = request.getParameter("clave");
			String confirmarClave = request.getParameter("confirmarClave");
			String direccion = request.getParameter("direccion");
			String provincia = request.getParameter("provincia");
			String localidad = request.getParameter("localidad");
			String telefono = request.getParameter("telefono");
			String dni = request.getParameter("dni");

			UsuarioServicio.verificarCambioContrasena(id, email, clave, confirmarClave, nombre, apellido1, apellido2,
					direccion, provincia, localidad, telefono, dni);
			request.getRequestDispatcher("mostrarEmpleados").forward(request, response);
		} catch (Exception e) {
			log.error("Error al editar el usuario", e);
			response.sendRedirect("error.jsp");
		}
	}
}
