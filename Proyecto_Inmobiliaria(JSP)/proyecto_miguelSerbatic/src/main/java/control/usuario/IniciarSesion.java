package control.usuario;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import service.UsuarioServicio;
import model.VO.UsuarioVO;
import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/InicioSesion")
public class IniciarSesion extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static Logger log = Logger.getLogger(IniciarSesion.class);

	public IniciarSesion() {
		super();
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
		try {
			String email = request.getParameter("email");
			String password = request.getParameter("password");
			UsuarioVO usuario = UsuarioServicio.comprobarUsuario(email, password);

			if (usuario != null) {
				request.getSession().setAttribute("usuarioGuardado", usuario);
				request.getSession().setAttribute("nombreUsuario",
						usuario.getNombre() + " " + usuario.getApellido1() + " " + usuario.getApellido2());

				if (usuario.getRolId() == 1) {
					if(request.getSession().getAttribute("inicio") == null) {
					response.sendRedirect(request.getContextPath());
					}else {
						response.sendRedirect("compra.jsp");
					}
				} else if (usuario.getRolId() == 2) {
					response.sendRedirect("mostrarUsuarios");
				} else if (usuario.getRolId() == 3) {
					response.sendRedirect("inicioAdmin");
				} else if (usuario.getRolId() == 4) {
					if (password.equals("admin")) {
						request.setAttribute("email", email);
						request.getRequestDispatcher("claveAdmin.jsp").forward(request, response);
					} else {
						response.sendRedirect("inicioAdmin");
					}
				}
			} else {
				request.setAttribute("errorMessage", "Error: Usuario no encontrado.");
				request.getRequestDispatcher("/iniciarSesion.jsp").forward(request, response);
				log.error("Error en el inicio de sesión: Usuario no encontrado.");
			}
		} catch (Exception e) {
			log.error("Error en el inicio de sesión", e);
			response.sendRedirect("error.jsp");
		}
	}
}
