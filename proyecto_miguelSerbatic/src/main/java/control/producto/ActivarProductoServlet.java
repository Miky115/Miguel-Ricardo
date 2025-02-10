package control.producto;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

import service.ProductoServicio;

@WebServlet("/activarProducto")
public class ActivarProductoServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(ActivarProductoServlet.class);

    public ActivarProductoServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
        
        try {
            String id = request.getParameter("id");
            if (id != null && !id.isEmpty()) {
                ProductoServicio.activarProducto(Integer.parseInt(id));
                request.getRequestDispatcher("mostrarProductos").forward(request, response);
            } else {
                log.error("ID del producto está vacío o nulo.");
                response.sendRedirect("error.jsp");
            }
        } catch (NumberFormatException e) {
            log.error("Error al activar el producto: " + e.getMessage());
            response.sendRedirect("error.jsp");
        } catch (Exception e) {
            log.error("Error al activar el producto: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doGet(request, response);
    }
}
