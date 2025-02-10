package control.producto;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

import model.DAO.ProductoDAO;
import model.VO.ProductoVO;

@WebServlet("/crearProducto")
public class AniadirProductoServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(AniadirProductoServlet.class);

    public AniadirProductoServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        response.getWriter().append("Served at: ").append(request.getContextPath());
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
        try {
            int idCategoria = Integer.parseInt(request.getParameter("idCategoria"));
            String nombre = request.getParameter("nombre");
            String descripcion = request.getParameter("descripcion");
            double precio = Double.parseDouble(request.getParameter("precio"));
            int stock = Integer.parseInt(request.getParameter("stock"));
            double impuesto = Double.parseDouble(request.getParameter("impuesto"));
            String imagen = request.getParameter("imagen");

            ProductoVO producto = new ProductoVO();
            producto.setIdCategoria(idCategoria);
            producto.setNombre(nombre);
            producto.setDescripcion(descripcion);
            producto.setPrecio(precio);
            producto.setStock(stock);
            producto.setImpuestos(impuesto);
            producto.setImagen(imagen);

            boolean exito = ProductoDAO.insertarProducto(producto);
            request.getSession().setAttribute("id", null);
            if (exito) {
                response.sendRedirect("mostrarProductos");
            } else {
                response.getWriter().println("Error al insertar el producto.");
            }
        } catch (Exception e) {
            log.error("Error al añadir el producto: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }
}
