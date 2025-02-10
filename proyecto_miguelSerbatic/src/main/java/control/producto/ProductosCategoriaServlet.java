package control.producto;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.CategoriaDAO;
import model.DAO.ProductoDAO;
import model.VO.CategoriaVO;
import model.VO.ProductoVO;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/categ")
public class ProductosCategoriaServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(ProductosCategoriaServlet.class);

    public ProductosCategoriaServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
        try {
            String categoria = request.getParameter("categoria");
            List<ProductoVO> catalogo = ProductoDAO.getProductosPorCategoria(categoria);
            List<CategoriaVO> categorias = CategoriaDAO.selectCategorias();
            if (catalogo != null && categorias != null) {
                request.setAttribute("catalogo", catalogo);
                request.getSession().setAttribute("categorias", categorias);
                request.getRequestDispatcher("index.jsp").forward(request, response);
            } else {
                response.sendRedirect("error.jsp");
            }
        } catch (Exception e) {
            log.error("Error al obtener los productos por categoría: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doGet(request, response);
    }
}
