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

@WebServlet("/cambiarClave")
public class CambiarClaveSuperAdminServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static Logger log = Logger.getLogger(CambiarClaveSuperAdminServlet.class);

    public CambiarClaveSuperAdminServlet() {
        super();
    }

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
		try {
		String email = request.getParameter("email");
		String clave = request.getParameter("clave");
		UsuarioDAO.actualizarSuperAdmin(email, clave);
		response.sendRedirect("inicioAdmin");
		} catch (Exception e) {
			log.error("Error en la actualización de datos del superAdmin", e);
			response.sendRedirect("error.jsp");
		}
	}

}
