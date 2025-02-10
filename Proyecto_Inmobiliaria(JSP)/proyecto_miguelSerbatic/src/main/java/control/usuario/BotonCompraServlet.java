package control.usuario;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.VO.UsuarioVO;
import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/compra")
public class BotonCompraServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(BotonCompraServlet.class);

    public BotonCompraServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
        try {
            UsuarioVO usuario = (UsuarioVO) request.getSession().getAttribute("usuarioGuardado");
            if (usuario == null) {
                log.error("El usuario no ha iniciado sesión.");
                request.getSession().setAttribute("inicio", "compra");
                request.getRequestDispatcher("iniciarSesion.jsp").forward(request, response);
            } else {
                request.getRequestDispatcher("compra.jsp").forward(request, response);
            }
        } catch (Exception e) {
            log.error("Error al procesar la solicitud: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
            doGet(request, response);
    }
}
