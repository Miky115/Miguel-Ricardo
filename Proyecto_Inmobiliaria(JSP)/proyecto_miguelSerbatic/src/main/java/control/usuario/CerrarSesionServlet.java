package control.usuario;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

/**
 * Servlet implementation class CerrarSesion
 */
@WebServlet("/cerrar")
public class CerrarSesionServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static Logger log = Logger.getLogger(CerrarSesionServlet.class);

	/**
	 * @see HttpServlet#HttpServlet()
	 */
	public CerrarSesionServlet() {
		super();
	}

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
		try {
			request.getSession().setAttribute("nombreUsuario", null);
			request.getSession().setAttribute("correoGuardado", null);
			request.getSession().setAttribute("usuarioGuardado", null);
			request.getSession().setAttribute("iniciado", false);

			response.sendRedirect(request.getContextPath());
		} catch (Exception e) {
			log.error("Error al cerrar sesión: " + e.getMessage());
			response.sendRedirect("error.jsp");
		}
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
			doGet(request, response);
	}

}
