package control.categoria;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.CategoriaDAO;
import model.VO.CategoriaVO;
import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/editarCategoria")
public class EditarCategoriaServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(EditarCategoriaServlet.class);

    public EditarCategoriaServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
        PropertyConfigurator.configure(log4jPath);
        try {
            String id = request.getParameter("id");
            if (id != null && !id.isEmpty()) {
                CategoriaVO categoria = CategoriaDAO.obtenerPorId(Integer.parseInt(id));
                if (categoria != null) {
                    request.setAttribute("categoria", categoria);
                    request.getSession().setAttribute("id", id);
                    request.getRequestDispatcher("editarCategoria.jsp").forward(request, response);
                } else {
                    response.sendRedirect("error.jsp");
                }
            } else {
                response.sendRedirect("error.jsp");
            }
        } catch (Exception e) {
            log.error("Error al obtener la categoría para editar: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        try {
            String nombre = request.getParameter("nombre");
            String descripcion = request.getParameter("descripcion");
            String idStr = (String) request.getSession().getAttribute("id");
            if (idStr != null && !idStr.isEmpty()) {
                int id = Integer.parseInt(idStr);
                CategoriaVO categoria = new CategoriaVO(id, nombre, descripcion);
                CategoriaDAO.updateCategoria(categoria);
                request.getSession().setAttribute("id", null);
                response.sendRedirect("mostrarCategorias");
            } else {
                response.sendRedirect("error.jsp");
            }
        } catch (Exception e) {
            log.error("Error al editar la categoría: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }
}
