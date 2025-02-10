package control.producto;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.ProductoDAO;
import model.VO.ProductoVO;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/precioDESC")
public class PrecioProductosDESCServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(PrecioProductosDESCServlet.class);

    public PrecioProductosDESCServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
        try {
            List<ProductoVO> catalogo = ProductoDAO.getProductosPrecio("DESC");
            if (catalogo != null) {
                request.setAttribute("catalogo", catalogo);
                request.getRequestDispatcher("index.jsp").forward(request, response);
            } else {
                response.sendRedirect("error.jsp");
            }
        } catch (Exception e) {
            log.error("Error al obtener los productos ordenados por precio descendente: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doGet(request, response);
    }
}
