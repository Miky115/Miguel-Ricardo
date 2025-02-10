package control.categoria;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.CategoriaDAO;
import model.VO.CategoriaVO;
import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/mostrarCategorias")
public class MostrarCategoriasEmpleadoServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(MostrarCategoriasEmpleadoServlet.class);

    public MostrarCategoriasEmpleadoServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
        PropertyConfigurator.configure(log4jPath);
        try {
            List<CategoriaVO> categorias = CategoriaDAO.selectCategorias();
            request.setAttribute("categorias", categorias);
            request.getRequestDispatcher("gestionCategorias.jsp").forward(request, response);
        } catch (Exception e) {
            log.error("Error al obtener las categorías: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doGet(request, response);
    }
}
