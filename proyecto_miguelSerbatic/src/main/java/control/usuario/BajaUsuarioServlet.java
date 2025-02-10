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

@WebServlet("/bajaUsuario")
public class BajaUsuarioServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static Logger log = Logger.getLogger(BajaUsuarioServlet.class);

	public BajaUsuarioServlet() {
		super();
	}

	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
		try {
			String id = request.getParameter("id");
			UsuarioServicio.bajaUsuario(Integer.parseInt(id));
			String cliente = (String) request.getSession().getAttribute("cliente");
			if (cliente == "cliente") {
				request.getRequestDispatcher("mostrarUsuarios").forward(request, response);
			} else if (cliente == "empleado"){
				request.getRequestDispatcher("mostrarEmpleados").forward(request, response);
			}else if(cliente == "administrador") {
				request.getRequestDispatcher("mostrarAdministradores").forward(request, response);
			}
		} catch (NumberFormatException e) {
			log.error("Error de formato al dar de baja al usuario: " + e.getMessage());
			response.sendRedirect("error.jsp");
		} catch (Exception e) {
			log.error("Error al dar de baja al usuario: " + e.getMessage());
			response.sendRedirect("error.jsp");
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		doGet(request, response);
	}

}
