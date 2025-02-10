package control.carrito;

import java.io.IOException;
import java.util.HashMap;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.VO.ProductoVO;
import service.CarritoServicio;
import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/quitarCantidad")
public class QuitarCantidadServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(QuitarCantidadServlet.class);

    public QuitarCantidadServlet() {
        super();
    }

    @SuppressWarnings("unchecked")
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
        PropertyConfigurator.configure(log4jPath);

        try {
            String referer = request.getHeader("referer");
            String id = request.getParameter("id");

            HashMap<ProductoVO, Integer> carrito = (HashMap<ProductoVO, Integer>) request.getSession()
                    .getAttribute("carrito");

            if (carrito != null) {
                CarritoServicio.quitarCantidad(carrito, id);
                request.getSession().setAttribute("carrito", carrito);
            }

            response.sendRedirect(referer);
        } catch (Exception e) {
            log.error("Error al quitar cantidad del producto en el carrito: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doGet(request, response);
    }
}
