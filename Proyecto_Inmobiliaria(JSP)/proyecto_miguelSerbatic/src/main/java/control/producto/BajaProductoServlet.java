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

@WebServlet("/bajaProducto")
public class BajaProductoServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(BajaProductoServlet.class);

    public BajaProductoServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
        try {
            String id = request.getParameter("id");
            ProductoServicio.bajaProducto(Integer.parseInt(id));
 
            request.getRequestDispatcher("mostrarProductos").forward(request, response);
        } catch (Exception e) {
            log.error("Error al dar de baja el producto: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        doGet(request, response);
    }
}
