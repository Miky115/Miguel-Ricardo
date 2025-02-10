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

@WebServlet("/QuitarCarritoServlet")
public class QuitarCarritoServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(QuitarCarritoServlet.class);

    public QuitarCarritoServlet() {
        super();
    }

    @SuppressWarnings("unchecked")
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
        PropertyConfigurator.configure(log4jPath);
        try {
            String id = request.getParameter("id");
            if (id != null) {

                HashMap<ProductoVO, Integer> carrito = (HashMap<ProductoVO, Integer>) request.getSession()
                        .getAttribute("carrito");

                if (carrito != null) {
                    CarritoServicio.quitarCarrito(carrito, id);
                    request.getSession().setAttribute("carrito", carrito);
                }

                response.sendRedirect("carrito.jsp");
            }
        } catch (Exception e) {
            log.error("Error al quitar producto del carrito: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doGet(request, response);
    }
}
