package control.carrito;

import java.io.IOException;
import java.util.HashMap;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

import service.CarritoServicio;
import model.VO.ProductoVO;

@WebServlet("/AniadirCarritoServlet")
public class AniadirCarritoServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
	private static Logger log = Logger.getLogger(AniadirCarritoServlet.class);

    public AniadirCarritoServlet() {
        super();
    }

    @SuppressWarnings("unchecked")
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
        PropertyConfigurator.configure(log4jPath);
        try {
            String referer = request.getHeader("referer");

            if (request.getParameter("id") != null) {
                String id = request.getParameter("id");

                HashMap<ProductoVO, Integer> carrito = (HashMap<ProductoVO, Integer>) request.getSession()
                        .getAttribute("carrito");

                if (carrito == null) {
                    carrito = new HashMap<>();
                }

                CarritoServicio.introducirCarrito(carrito, id);
                request.getSession().setAttribute("carrito", carrito);

                response.sendRedirect(referer);
            }
        } catch (Exception e) {
            log.error("Error al añadir producto al carrito: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        doGet(request, response);
    }
}
