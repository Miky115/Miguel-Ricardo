package control.producto;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.ProductoDAO;
import model.VO.ProductoVO;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/editarProducto")
public class EditarProductoServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(EditarProductoServlet.class);

    public EditarProductoServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
        try {
            String id = request.getParameter("id");
            if (id != null && !id.isEmpty()) {
                ProductoVO producto = ProductoDAO.obtenerPorId(Integer.parseInt(id));
                if (producto != null) {
                    request.setAttribute("producto", producto);
                    request.getSession().setAttribute("id", id);
                    request.getRequestDispatcher("editarProducto.jsp").forward(request, response);
                } else {
                    response.sendRedirect("error.jsp");
                }
            } else {
                response.sendRedirect("error.jsp");
            }
        } catch (Exception e) {
            log.error("Error en la obtención del producto para editar: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
        try {
            int id = Integer.parseInt((String) request.getSession().getAttribute("id"));
            int idCategoria = Integer.parseInt(request.getParameter("idCategoria"));
            String nombre = request.getParameter("nombre");
            String descripcion = request.getParameter("descripcion");
            double precio = Double.parseDouble(request.getParameter("precio"));
            int stock = Integer.parseInt(request.getParameter("stock"));
            double impuesto = Double.parseDouble(request.getParameter("impuesto"));
            String imagen = request.getParameter("imagen");

            ProductoVO producto = new ProductoVO();
            producto.setId(id);
            producto.setIdCategoria(idCategoria);
            producto.setNombre(nombre);
            producto.setDescripcion(descripcion);
            producto.setPrecio(precio);
            producto.setStock(stock);
            producto.setImpuestos(impuesto);
            producto.setImagen(imagen);

            boolean exito = ProductoDAO.editarProducto(producto);
            request.getSession().setAttribute("id", null);
            if (exito) {
                response.sendRedirect("mostrarProductos");
            } else {
                response.sendRedirect("error.jsp");
            }
        } catch (Exception e) {
            log.error("Error al editar el producto: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }
}
